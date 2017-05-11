using System;
using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public static class PureComponentTests
	{
		public static void RunTests()
		{
			Module("PureComponent Tests");

			Test("PureComponent re-rendered with equivalent props should not have to re-render", assert =>
			{
				// We'll create a Container component that renders a PureComponent. Each component will make a callback when they render so that we can count how many times
				// they render. The container also allows us a way to receive an async "forceReRender" method which we may call to force the Container to re-render. Since
				// the PureComponent's props don't change, forcing a single re-render should result in the Container being rendered twice (once for the initial render
				// and once for the re-render) but the PureComponent only being rendered once.
				var done = assert.Async();
				var numberOfContainerRenders = 0;
				var numberOfPureComponentRenders = 0;
				Action<Action> forceReRender = null;
				TestComponentMounter.Render(
					component: new Container(
						onContainerRender: () => numberOfContainerRenders++,
						onPureComponentRender: () => numberOfPureComponentRenders++,
						reRenderProvider: force => forceReRender = force
					),
					ready: container =>
					{
						forceReRender(() =>
						{
							assert.StrictEqual(numberOfContainerRenders, 2);
							assert.StrictEqual(numberOfPureComponentRenders, 1);
							container.Remove();
							done();
						});
					}
				);
			});
		}

		private sealed class Container : Component<Container.Props, object>
		{
			public Container(Action onContainerRender, Action onPureComponentRender, Action<Action<Action>> reRenderProvider)
				: base(new Props { OnContainerRender = onContainerRender, OnPureComponentRender = onPureComponentRender, ReRenderProvider = reRenderProvider }) { }

			protected override void ComponentDidMount()
			{
				props.ReRenderProvider(
					callback => SetState(null, callback)
				);
			}

			public override ReactElement Render()
			{
				props.OnContainerRender();
				return new ExamplePureComponent("abc", props.OnPureComponentRender);
			}

			public sealed class Props
			{
				public Action OnContainerRender { get; set; }
				public Action OnPureComponentRender { get; set; }
				public Action<Action<Action>> ReRenderProvider { get; set; }
			}
		}

		private sealed class ExamplePureComponent : PureComponent<ExamplePureComponent.Props>
		{
			public ExamplePureComponent(string name, Action onPureComponentRender) : base(new Props { Name = name, OnPureComponentRender = onPureComponentRender }) { }
			public override ReactElement Render()
			{
				props.OnPureComponentRender();
				return DOM.Div(props.Name);
			}

			public sealed class Props
			{
				public string Name { get; set; }
				public Action OnPureComponentRender { get; set; }
			}
		}
	}
}