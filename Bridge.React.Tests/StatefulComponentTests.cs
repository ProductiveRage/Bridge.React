using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public static class StatefulComponentTests
	{
		public static void RunTests()
		{
			Module("(Stateful) Component Tests");

			Test("GetInitialState is called before first Render", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					new ComponentThatRendersTextFromItsState(),
					container =>
					{
						assert.StrictEqual(container.TextContent.Trim(), "Initial Text");
						container.Remove();
						done();
					}
				);
			});
		}

		private sealed class ComponentThatRendersTextFromItsState : Component<object, ComponentThatRendersTextFromItsState.State>
		{
			public ComponentThatRendersTextFromItsState() : base(null) { }
			protected override State GetInitialState()
			{
				return new State { Text = "Initial Text" };
			}
			public override ReactElement Render()
			{
				return DOM.Div(state.Text);
			}
			public sealed class State
			{
				public string Text { get; set; }
			}
		}
	}
}
