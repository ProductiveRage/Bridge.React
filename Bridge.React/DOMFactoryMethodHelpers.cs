using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	[Name("Bridge.React")] // Reducing the length of this class name so that the "Bridge.React.toReactElementArray" reference in the React.DOM element factory overload templates are shorter
	internal static class DOMFactoryMethodHelpers
	{
		[Name("fixAttr")]
		public static DomElementsAttributes RewriteDataAttributes(DomElementsAttributes attributes)
		{
			/*@
			if (!attributes || (!attributes.hasOwnProperty("data") && !attributes.hasOwnProperty("aria")))
				return attributes;

			var data = attributes["data"];
			var aria = attributes["aria"];
			delete attributes["data"];
			delete attributes["aria"];
			if (data !== undefined) {
				for (var name in data) {
					if (!data.hasOwnProperty(name)) {
						continue;
					}
					attributes["data-" + name.replace(/_/g, '-')] = data[name];
				}
			}
			if (aria !== undefined) {
				for (var name in aria) {
					if (!aria.hasOwnProperty(name)) {
						continue;
					}
					attributes["aria-" + name.replace(/_/g, '-')] = aria[name];
				}
			}
			*/
			return attributes;
		}

		/// <summary>
		/// This should only be used by the React.DOM factory method overloads - as such, I haven't created separate strongly-typed method signatures for StatelessComponent and PureComponent,
		/// I've rolled them together by having a single signature that takes an object set. This means that this method could feasibly be called with an object of references without the
		/// private "_reactElement" property, but no-one should be able to call this anyway so that's very low risk. Note that this won't work with the Component base class, it causes
		/// React to throw a "Maximum call stack size exceeded" error that I haven't been able to get to the bottom of yet (the ToChildComponentArray extension methods only supported
		/// StatelessComponent and PureComponent, so I'm ok for now with only supporting DOM factory methods that handle dynamic sets of StatelessComponent and PureComponent but
		/// not Component)
		/// </summary>
		internal static ReactElement[] ToReactElementArray(IEnumerable<object> components)
		{
			if (components == null)
				throw new ArgumentNullException("components");

			var componentsArray = components.ToArray();
			var reactElements = new ReactElement[componentsArray.Length];
			/*@
			for (var i = 0; i < componentsArray.length; i++) {
				reactElements[i] = (componentsArray[i] == null) ? null : componentsArray[i]._reactElement;
			}
			 */
			return reactElements;
		}
	}
}