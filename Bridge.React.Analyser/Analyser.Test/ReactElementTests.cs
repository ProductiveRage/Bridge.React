using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelper;

namespace Bridge.React.Analyser.Test
{
	[TestClass]
	public class ReactElementTests : DiagnosticVerifier
	{
		[TestMethod]
		public void InstantiationOfListOfReactElementWillFail()
		{
			var testContent = @"
				using System.Collections.Generic;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							var x = new List<ReactElement>();
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = ReactElementAnalyser.DiagnosticId,
				Message = ReactElementAnalyser.InstantiationsThatReferToTypesNotAvailableAtRuntimeRule.MessageFormat.ToString(),
				Severity = DiagnosticSeverity.Error,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 25)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void InstantiationOfNestedGenericTypeThatReferencesReactElementWillFail()
		{
			var testContent = @"
				using System.Collections.Generic;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							var x = new List<KeyValuePair<string, ReactElement>>();
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = ReactElementAnalyser.DiagnosticId,
				Message = ReactElementAnalyser.InstantiationsThatReferToTypesNotAvailableAtRuntimeRule.MessageFormat.ToString(),
				Severity = DiagnosticSeverity.Error,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 11, 46)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void InstantiationOfGenericTypeThatReferencesReactElementIsFineIfTypeHasIgnoreGeneri()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							var x = new GenericTypeThatStripsTypeParamsFromJavaScript<ReactElement>();
						}
					}

					[IgnoreGeneric]
					public class GenericTypeThatStripsTypeParamsFromJavaScript<T>
					{
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void InstantiationOfNestedGenericTypeThatReferencesReactElementIsFineIfTypeHasIgnoreGeneri()
		{
			var testContent = @"
				using Bridge;
				using Bridge.React;

				namespace TestCase
				{
					public class Example
					{
						public void Go()
						{
							var x = new List<GenericTypeThatStripsTypeParamsFromJavaScript<ReactElement>>();
						}
					}

					[IgnoreGeneric]
					public class GenericTypeThatStripsTypeParamsFromJavaScript<T>
					{
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		/// <summary>
		/// This illustrates the fix for https://forums.bridge.net/forum/community/help/3885-unexpected-warning-in-bridge-react (the ContainingAssembly for an object array
		/// is null for some reason)
		/// </summary>
		[TestMethod]
		public void InstanceOfGenericTypeWithTypeArgumentThatIsAnArrayShouldNotThrow()
		{
			var testContent = @"
				namespace TestCase
				{
					internal static List<object[]> MailQueue = new List<object[]>();
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
		{
			return new ReactElementAnalyser();
		}
	}
}