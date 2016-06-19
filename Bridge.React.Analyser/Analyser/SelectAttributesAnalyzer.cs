using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Bridge.React.Analyser
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class SelectAttributesAnalyzer : DiagnosticAnalyzer
	{
		public const string DiagnosticId = "BridgeReact";
		private const string Category = "Design";
		public static DiagnosticDescriptor DoNotUseValueWhenMultipleIsTrueRule = new DiagnosticDescriptor(
			DiagnosticId,
			GetLocalizableString(nameof(Resources.SelectAttributesMisuse)),
			GetLocalizableString(nameof(Resources.SelectAttributeValueWithMultiple)),
			Category,
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);
		public static DiagnosticDescriptor DoNotUseValuesWhenMultipleIsFalseRule = new DiagnosticDescriptor(
			DiagnosticId,
			GetLocalizableString(nameof(Resources.SelectAttributesMisuse)),
			GetLocalizableString(nameof(Resources.SelectAttributesValuesButNonMultiple)),
			Category,
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
		{
			get
			{
				return ImmutableArray.Create(
					DoNotUseValueWhenMultipleIsTrueRule,
					DoNotUseValuesWhenMultipleIsFalseRule
				);
			}
		}

		public override void Initialize(AnalysisContext context)
		{
			context.RegisterSyntaxNodeAction(LookForMultiplePropertyUsedWithInappropriateValueOrValuesProperty, SyntaxKind.ObjectInitializerExpression);
		}

		private void LookForMultiplePropertyUsedWithInappropriateValueOrValuesProperty(SyntaxNodeAnalysisContext context)
		{
			var initializer = context.Node as InitializerExpressionSyntax;
			if (initializer == null)
				return;

			var parentObjectCreation = initializer.Parent as ObjectCreationExpressionSyntax;
			if (parentObjectCreation == null)
				return;

			var propertyInitialisers = parentObjectCreation.Initializer.ChildNodes()
				.OfType<AssignmentExpressionSyntax>()
				.Select(propertyInitialiser => new
				{
					PropertyName = ((IdentifierNameSyntax)propertyInitialiser.Left).Identifier.ValueText,
					ValueExpression = propertyInitialiser.Right
				});

			var multiplePropertyInitialiserIfAny = propertyInitialisers.FirstOrDefault(propertyInitialiser => propertyInitialiser.PropertyName == "Multiple");
			bool multiplePropertyValue;
			if (multiplePropertyInitialiserIfAny == null)
			{
				// If there's no explicit "Multiple" property setter then presume that it's false, since that's what it will default to. This could result
				// in a false positive warnings if a SelectAttributes instance is created and "Values" set in the initialiser and then "Multiple" set to
				// true in a separate statement but the code would (imo) be clearer if both properties were set initially, together, so I'm not upset
				// about that particular false positive.
				multiplePropertyValue = false;
			}
			else
			{
				if (multiplePropertyInitialiserIfAny.ValueExpression.Kind() == SyntaxKind.TrueLiteralExpression)
					multiplePropertyValue = true;
				else if (multiplePropertyInitialiserIfAny.ValueExpression.Kind() == SyntaxKind.FalseLiteralExpression)
					multiplePropertyValue = false;
				else
				{
					// This analyser is only looking for simple cases, where Multiple is set to true or false (or not set at all) - if it's set according
					// to a method return value or set to a variable value then all bets are off and we'll bail now (this is just intended to catch obvious
					// mistakes, not to perform deep and complex analysis on calling code)
					return;
				}
			}

			if (multiplePropertyValue && propertyInitialisers.Any(propertyInitialiser => propertyInitialiser.PropertyName == "Value"))
			{
				if (TargetTypeIsSelectAttributes(parentObjectCreation, context))
				{
					context.ReportDiagnostic(Diagnostic.Create(
						DoNotUseValueWhenMultipleIsTrueRule,
						parentObjectCreation.Initializer.GetLocation()
					));
				}
			}
			else if (!multiplePropertyValue && propertyInitialisers.Any(propertyInitialiser => propertyInitialiser.PropertyName == "Values"))
			{
				if (TargetTypeIsSelectAttributes(parentObjectCreation, context))
				{
					context.ReportDiagnostic(Diagnostic.Create(
						DoNotUseValuesWhenMultipleIsFalseRule,
						parentObjectCreation.Initializer.GetLocation()
					));
				}
			}
		}

		/// <summary>
		/// This requires querying the semantic model, which is typically more expensive that querying the syntax tree, so leave this check until last (so
		/// that as few code paths have to travel down this route as possible)
		/// </summary>
		private static bool TargetTypeIsSelectAttributes(ObjectCreationExpressionSyntax objectCreation, SyntaxNodeAnalysisContext context)
		{
			if (objectCreation == null)
				throw new ArgumentNullException(nameof(objectCreation));

			var typeToCreate = context.SemanticModel.GetTypeInfo(objectCreation);
			return
				(typeToCreate.Type != null) &&
				typeToCreate.Type.IsPartOfBridgeReact() &&
				(typeToCreate.Type.Name == "SelectAttributes");
		}

		private static LocalizableString GetLocalizableString(string nameOfLocalizableResource)
		{
			return new LocalizableResourceString(nameOfLocalizableResource, Resources.ResourceManager, typeof(Resources));
		}
	}
}
