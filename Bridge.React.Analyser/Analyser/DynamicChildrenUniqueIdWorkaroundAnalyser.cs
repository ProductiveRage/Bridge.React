using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Bridge.React.Analyser
{
	/// <summary>
	/// When the React DOM element factory methods are called (eg. DOM.Div) a properties reference is passed and then zero, one or more children elements - this is
	/// represented by a params array so that a variable number of arguments may be specified. If child elements are specified in this manner then they are presumed
	/// to be static elements. However, it's also possible to pass an array as the second argument, in which case React presumes that these as dynamic children and
	/// ensures (when in Development mode, at least) that each has a unique key, which is important (see https://facebook.github.io/react/docs/reconciliation.html).
	/// The problem is that if the C# code passes an array, Bridge acts as if each value was individually specified as a second argument and so the React check is
	/// bypassed, which allows bad things to sneak in unchecked. Additional method signatures now exist in the bindings to provide dynamic sets of children (for
	/// example, almost all factory methods have a signature that takes a single argument of type IEnumerable ReactElement). As such, it should never be necessary
	/// to call the params array method signature and to give it an array, so this situation is now identified as a warning by analyser.
	/// </summary>
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public sealed class DynamicChildrenUniqueIdWorkaroundAnalyser : DiagnosticAnalyzer
	{
		public const string DiagnosticId = "BridgeReact";
		private const string Category = "Design";
		public static DiagnosticDescriptor DynamicChildrenUniqueIdWarningBypassRule = new DiagnosticDescriptor(
			DiagnosticId,
			GetLocalizableString(nameof(Resources.DynamicChildrenWarningBypassTitle)),
			GetLocalizableString(nameof(Resources.DynamicChildrenWarningBypassMessageFormat)),
			Category,
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
		{
			get
			{
				return ImmutableArray.Create(
					DynamicChildrenUniqueIdWarningBypassRule
				);
			}
		}

		public override void Initialize(AnalysisContext context)
		{
			context.RegisterSyntaxNodeAction(LookForElementFactoryMethodParamsThatAreGivenAnArrayInsteadOfIndividualStaticElements, SyntaxKind.InvocationExpression);
		}

		private void LookForElementFactoryMethodParamsThatAreGivenAnArrayInsteadOfIndividualStaticElements(SyntaxNodeAnalysisContext context)
		{
			var invocation = context.Node as InvocationExpressionSyntax;
			if (invocation == null)
				return;

			// The element factory methods are always of the form
			//   public extern static ReactElement A(AnchorAttributes properties, params Union<ReactElement, string>[] children);
			// so the first do-no-more-work condition is if there are not precisely two arguments passed
			var arguments = invocation.ArgumentList.Arguments;
			if (arguments.Count != 2)
				return;

			// The next early exit is to leave now if the second argument isn't a named reference, invocation, member access, etc.. - actually, it's easier to look
			// for values which CAN'T result in a dynamic array being returned, which basically means a literal value (such as null) or a cast from a literal. If we
			// can break out now then we can avoid doing the more expensive work around determining the type of the second argument in case it's the array type that
			// we're looking for).
			var secondArgument = invocation.ArgumentList.Arguments[1].Expression;
			if (IsLiteralOrCastFromLiteral(secondArgument))
				return;

			var method = context.SemanticModel.GetSymbolInfo(invocation).Symbol as IMethodSymbol;
			if (method == null)
				return; // If the method call is not valid then there's no way to confirm or deny that the call is acceptable (or even to determine whether it's a Bridge.React.DOM method)

			// If the method isn't a Bridge.React.DOM element factory method then it's not something that we should be checking
			if ((method.ContainingAssembly.Identity.Name != "Bridge.React") || (method.ContainingType.Name != "DOM"))
				return;

			// Try to confirm that the last argument of the method is "Union<ReactElement, string>[]" since that's the type that enable the warning to be bypassed
			// most easily
			if (!IsAnyOrUnionReactElementOrStringArray(method.Parameters.Last().Type))
				return;

			// Try to confirm that the value specified as the parameter value is "Union<ReactElement, string>[]" (since this argument will be a params array in the
			// factory methods, it's possible that the value could be a single ReactElement or a single string - which would be fine)
			// - context.SemanticModel.GetTypeInfo will never return null since it returns a struct value
			// - We're interested in the ConvertedType of the value, for cases where the value itself is not an "Union<ReactElement, string>[]" but one which may
			//   be cast to that type, since that's what's important here
			var argumentValueType = context.SemanticModel.GetTypeInfo(secondArgument).ConvertedType;
			if ((argumentValueType == null) || (argumentValueType is IErrorTypeSymbol) || !IsAnyOrUnionReactElementOrStringArray(argumentValueType))
				return;

			context.ReportDiagnostic(Diagnostic.Create(
				DynamicChildrenUniqueIdWarningBypassRule,
				secondArgument.GetLocation(),
				method.Name
			));
		}

		private static bool IsLiteralOrCastFromLiteral(ExpressionSyntax expression)
		{
			if (expression == null)
				throw new ArgumentNullException(nameof(expression));

			if (expression is LiteralExpressionSyntax)
				return true;

			var castExpression = expression as CastExpressionSyntax;
			if (castExpression != null)
				return IsLiteralOrCastFromLiteral(castExpression.Expression);

			return false;
		}

		private static bool IsAnyOrUnionReactElementOrStringArray(ITypeSymbol type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			var arrayType = type as IArrayTypeSymbol;
			if (arrayType == null)
				return false;
			var elementType = arrayType.ElementType as INamedTypeSymbol;
			return (elementType != null) && (elementType.Arity == 2) && (IsBridgeClass(elementType, "Any") || IsBridgeClass(elementType, "Union"));
		}

		private static bool IsBridgeClass(ITypeSymbol type, string className)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));
			if (string.IsNullOrWhiteSpace(className))
				throw new ArgumentException($"Null/blank {nameof(className)} specified");

			return 
				(type.ContainingAssembly.Identity.Name == "Bridge") &&
				(type.Name == className);
		}

		private static LocalizableString GetLocalizableString(string nameOfLocalizableResource)
		{
			return new LocalizableResourceString(nameOfLocalizableResource, Resources.ResourceManager, typeof(Resources));
		}
	}
}
