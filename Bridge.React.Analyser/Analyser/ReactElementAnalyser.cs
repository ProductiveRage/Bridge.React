using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Bridge.React.Analyser
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public sealed class ReactElementAnalyser : DiagnosticAnalyzer
	{
		public const string DiagnosticId = "BridgeReact";
		private const string Category = "Design";
		public static DiagnosticDescriptor InstantiationsThatReferToTypesNotAvailableAtRuntimeRule = new DiagnosticDescriptor(
			DiagnosticId,
			GetLocalizableString(nameof(Resources.InvalidReactElementUsage)),
			GetLocalizableString(nameof(Resources.InvalidReactElementInstantiation)),
			Category,
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
		{
			get
			{
				return ImmutableArray.Create(
					InstantiationsThatReferToTypesNotAvailableAtRuntimeRule
				);
			}
		}

		public override void Initialize(AnalysisContext context)
		{
			context.RegisterSyntaxNodeAction(LookForInstantiationsThatReferToTypesNotAvailableAtRuntime, SyntaxKind.ObjectCreationExpression);
		}

		private void LookForInstantiationsThatReferToTypesNotAvailableAtRuntime(SyntaxNodeAnalysisContext context)
		{
			var objectCreation = context.Node as ObjectCreationExpressionSyntax;
			if (objectCreation == null)
				return;

			foreach (var type in GetAllReferencedTypes(objectCreation.Type, context))
			{
				var typeInfo = context.SemanticModel.GetTypeInfo(type);
				if ((typeInfo.Type == null) || (typeInfo.Type is IErrorTypeSymbol))
				{
					// The documentation for the "Type" property says that "For expressions that do not have a type, null is returned. If the type
					// could not be determined due to an error, than an IErrorTypeSymbol is returned" , so we'll just push on in those cases
					continue;
				}

				// Note: ReactElement is sealed and so we don't have to worry about whether the current type is derived from it - it's either
				// simply a ReactElement or it's not
				if (typeInfo.Type.IsPartOfBridgeReact() && (typeInfo.Type.Name == "ReactElement"))
				{
					context.ReportDiagnostic(Diagnostic.Create(
						InstantiationsThatReferToTypesNotAvailableAtRuntimeRule,
						type.GetLocation()
					));
				}
			}
		}

		private static IEnumerable<TypeSyntax> GetAllReferencedTypes(TypeSyntax type, SyntaxNodeAnalysisContext context)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			// The "all referenced types" set will be the current type and any generic type parameters that it has (and any generic type parameters that
			// they might have)..
			yield return type;

			// .. so, if this type doesn't have any type parameters then we're done here..
			// If this isn't 
			var genericTypeIfApplicable = type as GenericNameSyntax;
			if (genericTypeIfApplicable == null)
				yield break;

			// .. alternatively, if the type has the Bridge [IgnoreGeneric] attribute on it then we don't need to worry about the type parameters since
			// there won't be references to them at runtime
			var typeSymbolInfo = context.SemanticModel.GetSymbolInfo(type);
			if ((typeSymbolInfo.Symbol != null) && typeSymbolInfo.Symbol.GetAttributes().Any(attribute => IsBridgeClass(attribute.AttributeClass, "IgnoreGenericAttribute")))
				yield break;

			foreach (var typeParameter in genericTypeIfApplicable.TypeArgumentList.Arguments)
			{
				foreach (var typeRelatedToTypeParameter in GetAllReferencedTypes(typeParameter, context))
					yield return typeRelatedToTypeParameter;
			}
		}

		private static bool IsBridgeClass(ITypeSymbol type, string className)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));
			if (string.IsNullOrWhiteSpace(className))
				throw new ArgumentException($"Null/blank {nameof(className)} specified");

			return 
				(type.ContainingAssembly?.Identity.Name == "Bridge") &&
				(type.Name == className);
		}

		private static LocalizableString GetLocalizableString(string nameOfLocalizableResource)
		{
			return new LocalizableResourceString(nameOfLocalizableResource, Resources.ResourceManager, typeof(Resources));
		}
	}
}
