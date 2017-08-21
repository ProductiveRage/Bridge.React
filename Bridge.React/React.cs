using System;
using Bridge.Html5;

namespace Bridge.React
{
	[Name("ReactDOM")]
	[External]
	public static class React
	{
		/// <summary>
		/// Render a React element into the DOM in the supplied container.
		/// 
		/// If the React element was previously rendered into container, this will perform an update on it and
		/// only mutate the DOM as necessary to reflect the latest React element.
		/// </summary>
		// NOTE: ReactDOM.render actually returns "a reference to the component (or returns null for stateless components)",
		// but I'm not quite sure what type to use for those (they're not the same as the ReactElement passed in, and for
		// DOM HTML elements they return those HTML elements themselves).
		[Name("render")]
		public extern static void Render(ReactElement element, Element container);

		/// <summary>
		/// Render a React element into the DOM in the supplied container.
		/// 
		/// If the React element was previously rendered into container, this will perform an update on it and
		/// only mutate the DOM as necessary to reflect the latest React element.
		/// 
		/// The provided callback will be executed after the component is rendered or updated.
		/// </summary>
		// NOTE: ReactDOM.render actually returns "a reference to the component (or returns null for stateless components)",
		// but I'm not quite sure what type to use for those (they're not the same as the ReactElement passed in, and for
		// DOM HTML elements they return those HTML elements themselves).
		[Name("render")]
		public extern static void Render(ReactElement element, Element container, Action callback);

		/// <summary>
		/// Remove a mounted React component from the DOM and clean up its event handlers and state.
		/// If no component was mounted in the container, calling this function does nothing.
		/// Returns true if a component was unmounted and false if there was no component to unmount.
		/// </summary>
		[Name("unmountComponentAtNode")]
		public extern static bool UnmountComponentAtNode(Element container);
	}
}