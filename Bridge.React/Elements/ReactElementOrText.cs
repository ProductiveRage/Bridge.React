namespace Bridge.React
{
	/// <summary>
	/// While React components must return a ReactElement instance from their Render method, when specify child elements (eg. when calling React.DOM.div) it
	/// must be possible to specify EITHER a ReactElement OR a string. This type allows for that since it means that the React method signature can specify
	/// the ReactElement type as a return type while any function that takes child components may use this class as its element type - it will then accept
	/// either of the required types.
	/// </summary>
	public sealed class ReactElementOrText
	{
		// This type is just used to say that either-text-or-a-real-ReactElement may be used for a given argument. Originally I marked this as [External]
		// since it is not a type that would ever be instantiated directly (only via casts). However, when creating dynamic elements it is common to want
		// to create a list of elements to populate and then pass to a React component to render - Bridge will error if you attempt to create a list with
		// a type that does not exist as a JavaScript class, so I've removed the [External] attribute. Since there is no React class that represents this
		// (since JavaScript doesn't worry so much about types - it will just let you pass a string or element in and then decide what to do with it at
		// runtime), it doesn't matter that this class will get a JavaScript representation.
		private ReactElementOrText() { }
		public static implicit operator ReactElementOrText(string text)
		{
			return Script.Write<ReactElementOrText>("text");
		}
		public static implicit operator ReactElementOrText(ReactElement element)
		{
			return Script.Write<ReactElementOrText>("element");
		}
	}
}
