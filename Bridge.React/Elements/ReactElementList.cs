using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	// Note: I originally added this because ReactElement is [External] and couldn't be used as a generic type parameter - but this was fixed in 1.12.4 by adding a [Name]
	// attribute to it. However, there's still some use to this class - it makes it easy to join individual elements and/or sets of elements together into one flat list
	// (which could be done using Concat and similar LINQ functions but you would need to wrap individual elements in an array and this can confuse Bridge / the C#
	// compiler (particularly if leaving the compiler to try to infer the array element type when different ReactElement classes exist as siblings). Using this class
	// means that there is less type inference required (each Add argument is either a ReactElement or an IEnumerable<ReactElement>).
	/// <summary>
	/// This is a helper class for constructing sets of ReactElement instances. It has a single Add method that has three overloads - one to take a single ReactElement,
	/// one to take an IEnumerable of ReactElement and one to take a params array of ReactElement. Since many React library methods allow null ReactElement references,
	/// null element references are allowed here (though null sets of elements are not).
	/// </summary>
	public sealed class ReactElementList : IEnumerable<ReactElement>
	{
		public static ReactElementList Empty { get; } = new ReactElementList(new ReactElement[0]);

		private readonly IEnumerable<ReactElement> _items;
		private ReactElementList(IEnumerable<ReactElement> items)
		{
			if (items == null)
				throw new ArgumentNullException(nameof(items));

			_items = items;
		}

		/// <summary>
		/// A null item reference is acceptable here
		/// </summary>
		public ReactElementList Add(ReactElement item)
		{
			return new ReactElementList(_items.Concat(new ReactElement[] { item }));
		}

		/// <summary>
		/// The items set may contain null references but the set itself must not be null
		/// </summary>
		public ReactElementList Add(IEnumerable<ReactElement> items)
		{
			if (items == null)
				throw new ArgumentNullException(nameof(items));

			return new ReactElementList(_items.Concat(items));
		}

		/// <summary>
		/// The items params array may contain null references but the array itself must not be null
		/// </summary>
		public ReactElementList Add(params ReactElement[] items)
		{
			if (items == null)
				throw new ArgumentNullException(nameof(items));

			return new ReactElementList(_items.Concat(items));
		}

		public IEnumerator<ReactElement> GetEnumerator()
		{
			return _items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
