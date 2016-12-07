using System;
using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
	public abstract class ReactDomElementAttributes<TCurrentTarget> : DomElementWithEventsAttributes<TCurrentTarget> where TCurrentTarget : Element
	{
		/// <summary>
		/// It's important for React elements to have the ability for a key to be explicitly specified for them so that when dynamic children are generated,
		/// React can reconcile them (see http://facebook.github.io/react/docs/multiple-components.html#dynamic-children). It is common to use numeric keys
		/// but it is also permitted to use strings (actually, React allows any type but it to-strings its value, so it makes more sense to explicitly
		/// limit the values to integers and strings).
		/// </summary>
		public Union<string, int> Key { private get; set; }

		/// <summary>
		/// The Ref callback allows access to the real DOM element of the React component that is being rendered - the callback will be provided a reference
		/// to the DOM element as the component is mounted (this is not something that is required very often, but may be useful for integrating with third
		/// party libraries - for more information, see https://facebook.github.io/react/docs/more-about-refs.html)
		/// </summary>
		public Action<TCurrentTarget> Ref { private get; set; }

		public ReactStyle Style { private get; set; }
	}
}
