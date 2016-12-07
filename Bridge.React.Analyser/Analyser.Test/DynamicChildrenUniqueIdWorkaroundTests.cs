using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelper;

namespace Bridge.React.Analyser.Test
{
	[TestClass]
	public class DynamicChildrenUniqueIdWorkaroundTests : DiagnosticVerifier
	{
		[TestMethod]
		public void CorrectlyCallFactoryMethodWithParams()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return DOM.Div(null, DOM.Div(""One""), DOM.Div(""Two""));
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void CorrectlyCallFullyNamedFactoryMethodWithParams()
		{
			var testContent = @"
				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return Bridge.React.DOM.Div(null, DOM.Div(""One""), DOM.Div(""Two""));
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void PassingIEnumerableReactElementToNonParamsMethodSignaturesIsTheWayToSpecifyDynamicChildren()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get(IEnumerable<ReactElement> children)
						{
							return DOM.Div(null, children);
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void PassingArrayReferenceToParamsArgumentShouldResultInWarning()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get(Union<ReactElement, string>[] children)
						{
							return DOM.Div(null, children);
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = DynamicChildrenUniqueIdWorkaroundAnalyser.DiagnosticId,
				Message = string.Format(DynamicChildrenUniqueIdWorkaroundAnalyser.DynamicChildrenUniqueIdWarningBypassRule.MessageFormat.ToString(), "Div"),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		/// <summary>
		/// Bridge doesn't yet (as of v1.14) support C# 6 syntax such as "using static" but it will do soon, so best ensure that this still works in that case
		/// </summary>
		[TestMethod]
		public void PassingArrayReferenceToParamsArgumentWhenMethodAccessedViaStaticUsingShouldResultInWarning()
		{
			var testContent = @"
				using Bridge;
				using static Bridge.React.DOM;

				namespace TestCase
				{
					public class Example
					{
						public Bridge.React.ReactElement Get()
						{
							return Div(null, new SomethingCastableToAnyReactElementOrString());
						}
					}

					public class SomethingCastableToAnyReactElementOrString
					{
						public static implicit operator Union<Bridge.React.ReactElement, string>[](SomethingCastableToAnyReactElementOrString value)
						{
							return null; // It's not important what this returns, only that its return type is Union<ReactElement, string>[]
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = DynamicChildrenUniqueIdWorkaroundAnalyser.DiagnosticId,
				Message = string.Format(DynamicChildrenUniqueIdWorkaroundAnalyser.DynamicChildrenUniqueIdWarningBypassRule.MessageFormat.ToString(), "Div"),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 25)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		/// <summary>
		/// This scenario doesn't create any child elements, so there's no point worrying about it
		/// </summary>
		[TestMethod]
		public void CastingNullToArrayIsNotWorthIdentifying()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return DOM.Div(null, (Union<ReactElement, string>[])null);
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void PassingSomethingThatWillBeCastToArryReferenceShouldResultInWarning()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return DOM.Div(null, new SomethingCastableToAnyReactElementOrString());
						}
					}

					public class SomethingCastableToAnyReactElementOrString
					{
						public static implicit operator Union<ReactElement, string>[](SomethingCastableToAnyReactElementOrString value)
						{
							return null; // It's not important what this returns, only that its return type is Union<ReactElement, string>[]
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = DynamicChildrenUniqueIdWorkaroundAnalyser.DiagnosticId,
				Message = string.Format(DynamicChildrenUniqueIdWorkaroundAnalyser.DynamicChildrenUniqueIdWarningBypassRule.MessageFormat.ToString(), "Div"),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}


		[TestMethod]
		public void PassingArrayReturnedFromMethodToParamsArgumentShouldResultInWarning()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return DOM.Div(null, GetChildren());
						}

						private Union<ReactElement, string>[] GetChildren()
						{
							return null; // It's not important what this method returns, only that its return type is Union<ReactElement, string>[]
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = DynamicChildrenUniqueIdWorkaroundAnalyser.DiagnosticId,
				Message = string.Format(DynamicChildrenUniqueIdWorkaroundAnalyser.DynamicChildrenUniqueIdWarningBypassRule.MessageFormat.ToString(), "Div"),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void PassingArrayReturnedFromPropertyToParamsArgumentShouldResultInWarning()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public ReactElement Get()
						{
							return DOM.Div(null, Children);
						}

						private Union<ReactElement, string>[] Children
						{
							get
							{
								return null; // It's not important what this method returns, only that its return type is Union<ReactElement, string>[]
							}
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = DynamicChildrenUniqueIdWorkaroundAnalyser.DiagnosticId,
				Message = string.Format(DynamicChildrenUniqueIdWorkaroundAnalyser.DynamicChildrenUniqueIdWarningBypassRule.MessageFormat.ToString(), "Div"),
				Severity = DiagnosticSeverity.Warning,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 29)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
		{
			return new DynamicChildrenUniqueIdWorkaroundAnalyser();
		}
	}
}