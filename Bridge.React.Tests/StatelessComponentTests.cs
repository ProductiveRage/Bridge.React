using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public static class StatelessComponentTests
	{
		public static void RunTests()
		{
			Module("StatelessComponent Tests");

			Test("Simple value-from-Props Render", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					new MyLabel("abc"),
					container =>
					{
						container.Remove();
						assert.StrictEqual(container.TextContent.Trim(), "abc");
						done();
					}
				);
			});
		}

		private sealed class MyLabel : StatelessComponent<MyLabel.Props>
		{
			public MyLabel(string text) : base(new Props { Text = text }) { }
			public override ReactElement Render()
			{
				return DOM.Div(props.Text);
			}
			public sealed class Props
			{
				public string Text { get; set; }
			}
		}
	}
}
