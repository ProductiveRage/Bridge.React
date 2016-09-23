using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelper;

namespace Bridge.React.Analyser.Test
{
	[TestClass]
	public class ComponentTests : DiagnosticVerifier
	{
		[TestMethod]
		public void ClassesDerivedFromComponentMustNotHaveNonEmptyInstanceConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : Component<LabelComponent.Props, object>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
							_otherValue = otherValue;

						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = ComponentAnalyzer.DiagnosticId,
				Message = string.Format(ComponentAnalyzer.EmptyConstructorRule.MessageFormat.ToString(), "LabelComponent", "Component"),
				Severity = DiagnosticSeverity.Error,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 9, 7)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void ClassesDerivedFromStatelessComponentMustNotHaveNonEmptyInstanceConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : StatelessComponent<LabelComponent.Props>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
							_otherValue = otherValue;

						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = ComponentAnalyzer.DiagnosticId,
				Message = string.Format(ComponentAnalyzer.EmptyConstructorRule.MessageFormat.ToString(), "LabelComponent", "StatelessComponent"),
				Severity = DiagnosticSeverity.Error,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 9, 7)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void ClassesDerivedFromPureComponentMustNotHaveNonEmptyInstanceConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : PureComponent<LabelComponent.Props>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
							_otherValue = otherValue;

						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			var expected = new DiagnosticResult
			{
				Id = ComponentAnalyzer.DiagnosticId,
				Message = string.Format(ComponentAnalyzer.EmptyConstructorRule.MessageFormat.ToString(), "LabelComponent", "PureComponent"),
				Severity = DiagnosticSeverity.Error,
				Locations = new[]
				{
					new DiagnosticResultLocation("Test0.cs", 9, 7)
				}
			};

			VerifyCSharpDiagnostic(testContent, expected);
		}

		[TestMethod]
		public void ClassesDerivedFromComponentMayHaveEmptyConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : Component<LabelComponent.Props, object>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void ClassesDerivedFromStatelessComponentMayHaveEmptyConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : StatelessComponent<LabelComponent.Props>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void ClassesDerivedFromPureComponentMayHaveEmptyConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : PureComponent<LabelComponent.Props>
					{
						private readonly int _otherValue;
						public LabelComponent(Props props, int otherValue) : base(props)
						{
						}

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void ClassesDerivedFromComponentMayHaveNonEmptyStaticConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : Component<LabelComponent.Props, object>
					{
						private static readonly int _otherValue;
						static LabelComponent()
						{
							_otherValue = 123;

						}

						public LabelComponent(Props props) : base(props) { }

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void ClassesDerivedFromStatelessComponentMayHaveNonEmptyStaticConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : StatelessComponent<LabelComponent.Props>
					{
						private static readonly int _otherValue;
						static LabelComponent()
						{
							_otherValue = 123;

						}

						public LabelComponent(Props props) : base(props) { }

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		[TestMethod]
		public void ClassesDerivedFromPureComponentMayHaveNonEmptyStaticConstructors()
		{
			var testContent = @"
				using Bridge.React;

				namespace TestCase
				{
					public class LabelComponent : PureComponent<LabelComponent.Props>
					{
						private static readonly int _otherValue;
						static LabelComponent()
						{
							_otherValue = 123;

						}

						public LabelComponent(Props props) : base(props) { }

						public override ReactElement Render()
						{
							return DOM.Label(
								new LabelAttributes { ClassName = props.ClassName },
								props.Text + "" ("" + _otherValue + "")""
							);
						}

						public class Props
						{
							public string ClassName;
							public string Text;
						}
					}
				}";

			VerifyCSharpDiagnostic(testContent);
		}

		protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
		{
			return new ComponentAnalyzer();
		}
	}
}