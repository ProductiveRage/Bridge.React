using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	public static class EnumerableComponentExtensions
	{
		/// <summary>
		/// When initialising a component that will accept a set of child components, each child components must be of type Any&lt;ReactElement, string&gt; - if you have an enumerable
		/// set of ReactElements then calling ToArray will not return an array of the appropriate type, so either each entry must be cast to an Any&lt;ReactElement, string&gt; before
		/// calling ToArray or this helper function may be used.
		/// </summary>
		[Obsolete("This method is not required now that the DOM element factory methods have overloads that will take enumerable sets of elements. Also, this method prevents the React warning 'Each child in an array or iterator should have a unique \"key\" prop' from being raised, which is too important to be bypassed. As such, use of this method is not recommended and it will likely be removed in a future version of this library.")]
		public static Any<ReactElement, string>[] ToChildComponentArray(this IEnumerable<ReactElement> elements)
		{
			if (elements == null)
				throw new ArgumentNullException("elements");

			return elements
				.Select(component => (Any<ReactElement, string>)component)
				.ToArray();
		}

		/// <summary>
		/// When initialising a component that will accept a set of child components, each child components must be of type Any&lt;ReactElement, string&gt; - if you have an enumerable
		/// set of PureComponents of the same type then this helper function may be called to produce an array of the correct type (otherwise, each entry must be cast to an
		/// Any&lt;ReactElement, string&gt; before ToArray is called on that set)
		/// </summary>
		[Obsolete("This method is not required now that the DOM element factory methods have overloads that will take enumerable sets of elements. Also, this method prevents the React warning 'Each child in an array or iterator should have a unique \"key\" prop' from being raised, which is too important to be bypassed. As such, use of this method is not recommended and it will likely be removed in a future version of this library.")]
		public static Any<ReactElement, string>[] ToChildComponentArray<TProps>(this IEnumerable<PureComponent<TProps>> components)
		{
			if (components == null)
				throw new ArgumentNullException("components");

			return components
				.Select(component => (Any<ReactElement, string>)component)
				.ToArray();
		}

		/// <summary>
		/// When initialising a component that will accept a set of child components, each child components must be of type Any&lt;ReactElement, string&gt; - if you have an enumerable
		/// set of PureComponents of the same type then this helper function may be called to produce an array of the correct type (otherwise, each entry must be cast to an
		/// Any&lt;ReactElement, string&gt; before ToArray is called on that set)
		/// </summary>
		[Obsolete("This method is not required now that the DOM element factory methods have overloads that will take enumerable sets of elements. Also, this method prevents the React warning 'Each child in an array or iterator should have a unique \"key\" prop' from being raised, which is too important to be bypassed. As such, use of this method is not recommended and it will likely be removed in a future version of this library.")]
		public static Any<ReactElement, string>[] ToChildComponentArray<TProps>(this IEnumerable<StatelessComponent<TProps>> components)
		{
			if (components == null)
				throw new ArgumentNullException("components");

			return components
				.Select(component => (Any<ReactElement, string>)component)
				.ToArray();
		}
	}
}