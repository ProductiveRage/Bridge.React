using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelper;

namespace Bridge.React.Analyser.Test
{
	[TestClass]
	public class SelectAttributesTests : DiagnosticVerifier
	{
		[TestMethod]
		public void DoNotUseValueWhenMultipleIsTrue()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							new SelectAttributes { Multiple = true, Value = ""1"" };
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = SelectAttributesAnalyzer.DiagnosticId,
				Message = SelectAttributesAnalyzer.DoNotUseValueWhenMultipleIsTrueRule.MessageFormat.ToString(),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 10, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void DoNotUseValuesWhenMultipleIsFalse()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							new SelectAttributes { Multiple = false, Values = new[] { ""1"" } };
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = SelectAttributesAnalyzer.DiagnosticId,
				Message = SelectAttributesAnalyzer.DoNotUseValuesWhenMultipleIsFalseRule.MessageFormat.ToString(),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 10, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		/// <summary>
		/// It could be argued that it's a false positive to register a warning if the Values property is set and the Multiple property is not set, even though
		/// Multiple will default to false, because Multiple may then be set by a separate statement. However, I think that this is a confusing calling convention
		/// and that it would be better to set both values within the object creation initialiser and so I'm going to keep the warning in this scenario.
		/// </summary>
		[TestMethod]
		public void DoNotUseValueWhenMultipleDefaultsToFalse()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							var x = new SelectAttributes { Values = new[] { ""1"" } };
							x.Multiple = True;
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = SelectAttributesAnalyzer.DiagnosticId,
				Message = SelectAttributesAnalyzer.DoNotUseValuesWhenMultipleIsFalseRule.MessageFormat.ToString(),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 10, 37)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
		{
			return new SelectAttributesAnalyzer();
		}
	}
}