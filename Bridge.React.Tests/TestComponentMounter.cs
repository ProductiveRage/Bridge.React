using System;
using Bridge.Html5;

namespace Bridge.React.Tests
{
	public static class TestComponentMounter
	{
		public delegate void ComponentReady(HTMLElement container);

		public static void Render(ReactElement component, ComponentReady ready)
		{
			if (component == null)
				throw new ArgumentNullException(nameof(component));
			if (ready == null)
				throw new ArgumentNullException(nameof(ready));

			var container = Document.CreateElement("div");
			container.Style.Display = Display.None;
			Window.SetTimeout(() => // Use SetTimeout to ensure that the DOM has updated (that the container has been added)
			{
				try
				{
					React.Render(
						new HostComponent(
							afterUpdate: () => ready(container),
							wrappedComponent: component
						),
						container
					);
				}
				catch
				{
					container.Remove();
					throw;
				}
			});
		}

		private sealed class HostComponent : Component<HostComponent.Props, object>
		{
			public HostComponent(Action afterUpdate, ReactElement wrappedComponent) : base(new Props(afterUpdate, wrappedComponent)) { }

			public override ReactElement Render()
			{
				return DOM.Div(new Attributes { ClassName = "host" }, props.WrappedComponent);
			}

			protected override void ComponentDidMount()
			{
				props.AfterUpdate();
			}

			protected override void ComponentDidUpdate(Props previousProps, object previousState)
			{
				props.AfterUpdate();
			}

			public sealed class Props
			{
				public Props(Action afterUpdate, ReactElement wrappedComponent)
				{
					if (afterUpdate == null)
						throw new ArgumentNullException(nameof(afterUpdate));
					if (wrappedComponent == null)
						throw new ArgumentNullException(nameof(wrappedComponent));

					AfterUpdate = afterUpdate;
					WrappedComponent = wrappedComponent;
				}

				public Action AfterUpdate { get; set; }
				public ReactElement WrappedComponent { get; set; }
			}
		}
	}
}
