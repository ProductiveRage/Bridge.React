using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	/// <summary>
	/// Because ReactElement is an External type, it can't be used as a generic type parameter and so it's not possible to construct a List of ReactElement, for example.
	/// Although the DOM methods all support taking an IEnumerable of ReactElement (and these sets may be constructed easily using LINQ) there are still times where it
	/// is more convenient to construct a list of elements to pass elsewhere. This builder class allows you to do that - you can get a reference to ReactElementList.Empty
	/// and then add items to it (either one at a time or in IEnumerable sets) and then pass the builder reference anywhere that accepts an IEnumerable of ReactElement
	/// (for the same reason that it's difficult to define a List of ReactElement it's also difficult to create a class that is derived from IEnumerable of ReactElement
	/// without relying upon some trickery - this code takes care of that trickery).
	/// </summary>
	[External]
	public sealed class ReactElementList : IEnumerable<ReactElement>
	{
		public extern static ReactElementList Empty { [Template("Bridge.React.ReactElementList.getEmpty()")] get; }
		private ReactElementList() { }

		[External]
		public extern ReactElementList Add(ReactElement item);

		[External]
		public extern ReactElementList Add(IEnumerable<ReactElement> items);

		[Name("getEnumerator")]
		public extern IEnumerator<ReactElement> GetEnumerator();

		[Name("getEnumerator")]
		extern IEnumerator IEnumerable.GetEnumerator();
	}

	internal static class ReactElementListDefinition
	{
		[Init(InitPosition.Before)]
		private static void Configure()
		{
			// At this point (due to the Init attribute) the UntypedReactElementList class won't actually be defined yet so we can't grab a reference to it.
			// Instead, we can configure a Func that will generate it - by the point at which that may be called, the class WILL be available.
			Func<object> getEmpty = () => UntypedReactElementList.Empty;

			// Using the multiline-comment-JavaScript-injecting method would be a good fit here but it fails to compiile with a cryptic exception 
			//   Error: 'count' must be non - negative.
			//    at System.String.CtorCharCount(Char c, Int32 count)
			//    at Bridge.Translator.AbstractEmitterBlock.RemoveIndentFromString(String value, Int32 offset)
			//    at Bridge.Translator.CommentBlock.WriteMultiLineComment(String text, Boolean newline, Boolean wrap)
			// .. so I'll just stick with separate Script.Write calls for now
			Script.Write("window.Bridge.React = window.Bridge.React || {};");
			Script.Write("window.Bridge.React.ReactElementList = window.Bridge.React.ReactElementList || {};");
			Script.Write("window.Bridge.React.ReactElementList.getEmpty = getEmpty;");

			// Make the ReactElementList look like its a real class (just in case anyone tries to GetType) it. This probably a bit fragile (since it uses
			// undocumented Bridge properties) and probably not SUPER-essential. It may need rejigging in the future.
			Script.Write("window.Bridge.React.ReactElementList.$$name = 'ReactElementList';");
			Script.Write("window.Bridge.React.ReactElementList.$$fullname = 'Bridge.React.ReactElementList';");
			Script.Write("window.Bridge.React.ReactElementList.$assembly = $asm;");
		}

		[Name("ReactElementList")]
		private sealed class UntypedReactElementList : IEnumerable<object>
		{
			public static UntypedReactElementList Empty => new UntypedReactElementList(new object[0]);

			private readonly IEnumerable<object> _items;
			private UntypedReactElementList(IEnumerable<object> items)
			{
				if (items == null)
					throw new ArgumentNullException(nameof(items));
				_items = items;
			}

			public UntypedReactElementList Add(ReactElement item)
			{
				return new UntypedReactElementList(_items.Concat(new[] { item }));
			}

			public UntypedReactElementList Add(IEnumerable<ReactElement> items)
			{
				if (items == null)
					throw new ArgumentNullException(nameof(items));
				return new UntypedReactElementList(_items.Concat(items));
			}

			public IEnumerator<object> GetEnumerator() { return _items.GetEnumerator(); }
			IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		}
	}
}
