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
	public class ComponentAnalyzer : DiagnosticAnalyzer
	{
		public const string DiagnosticId = "BridgeReact";
		private const string Category = "Design";
		public static DiagnosticDescriptor EmptyConstructorRule = new DiagnosticDescriptor(
			DiagnosticId,
			GetLocalizableString(nameof(Resources.ComponentAnalyserTitle)),
			GetLocalizableString(nameof(Resources.ComponentWithNonEmptyConstructorMessageFormat)),
			Category,
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
		{
			get
			{
				return ImmutableArray.Create(
					EmptyConstructorRule
				);
			}
		}

		public override void Initialize(AnalysisContext context)
		{
			context.RegisterSyntaxNodeAction(LookForComponentClassWithNonEmptyConstructors, SyntaxKind.ConstructorDeclaration);
		}

		private void LookForComponentClassWithNonEmptyConstructors(SyntaxNodeAnalysisContext context)
		{
			var constructor = context.Node as ConstructorDeclarationSyntax;
			if (constructor == null)
				return;

			if ((constructor.Body == null) // If the code is in an invalid state then the Body property might be null - safe to ignore
			|| !constructor.Body.ChildNodes().Any())
				return;

			var classDeclaration = constructor.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
			if (classDeclaration == null)
				return;

			// Note: It would seem more sensible to use typeof() to get the full type names to pass to IsDerivedFromClass but we can't do that because
			// we can't add a reference from the project to the "NonBridgeBuild" project because then that reference would get pulled in to the project
			// that the React Bindings and this Analyser were being added to - this would confuse the compiler because that project would have the "real"
			// project reference (the Bridge build of Bridge.React) AND it would get the built-for-CLR project reference, which would confuse it no end.
			var classDelarationSymbol = context.SemanticModel.GetDeclaredSymbol(classDeclaration);
			string baseClassNameIfApplicable;
			if (IsDerivedFromClass(classDelarationSymbol, "Bridge.React.Component`2"))
				baseClassNameIfApplicable = "Component";
			else if (IsDerivedFromClass(classDelarationSymbol, "Bridge.React.StatelessComponent`1"))
				baseClassNameIfApplicable = "StatelessComponent";
			else if (IsDerivedFromClass(classDelarationSymbol, "Bridge.React.PureComponent`1"))
				baseClassNameIfApplicable = "PureComponent";
			else
				return;

			context.ReportDiagnostic(Diagnostic.Create(
				EmptyConstructorRule,
				constructor.GetLocation(),
				classDeclaration.Identifier.Text,
				baseClassNameIfApplicable
			));
		}

		private static bool IsDerivedFromClass(INamedTypeSymbol classSymbol, string fullNameOfClassToTestFor)
		{
			if (classSymbol == null)
				throw new ArgumentNullException(nameof(classSymbol));
			if (string.IsNullOrWhiteSpace(fullNameOfClassToTestFor))
				throw new ArgumentNullException($"No {nameof(fullNameOfClassToTestFor)} specified");

			if (fullNameOfClassToTestFor.Contains("`"))
			{
				var classNameSegments = fullNameOfClassToTestFor.Split('`');
				if (classNameSegments.Length > 2)
					throw new Exception("Class name contains \"`\", which suggest arity details but it appears multiple times (only expected once, to be followed by a numeric value)");
				int arity;
				if (!int.TryParse(classNameSegments[1], out arity))
					throw new Exception("Class name contains \"`\", which suggest arity details but second segment is non-numeric");
				if (classSymbol.IsGenericType && ((uint)classSymbol.TypeArguments.Count() == arity))
				{
					if (classSymbol.ToString().Split('<').First() == classNameSegments[0])
						return true;
				}
			}
			else
			{
				if (!classSymbol.IsGenericType)
				{
					if (classSymbol.ToString() == fullNameOfClassToTestFor)
						return true;
				}
			}

			return (classSymbol.BaseType != null) && IsDerivedFromClass(classSymbol.BaseType, fullNameOfClassToTestFor);
		}

		private static LocalizableString GetLocalizableString(string nameOfLocalizableResource)
		{
			return new LocalizableResourceString(nameOfLocalizableResource, Resources.ResourceManager, typeof(Resources));
		}
	}
}
