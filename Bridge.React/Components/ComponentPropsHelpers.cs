namespace Bridge.React
{
	/// <summary>
	/// React internals do some monkeying about with props references that will cause problems if the props reference is a Bridge class which does not have
	/// the [ObjectLiteral] attribute on it. The way that the Component and StatelessComponent classes work around this is to wrap props reference in an
	/// object literal since React's meddling is not recursive, it doesn't change any property values on props, it just changes how those top-level
	/// properties are described. This class provides a standard way to wrap the props data. It also performs some magic to extract any "Key"
	/// value from the props, since this must not be tucked away one level deeper as it is a magic React property (for more information
	/// about keyed elements, see https://facebook.github.io/react/docs/multiple-components.html#dynamic-children).
	/// </summary>
	[IgnoreGeneric]
	internal static class ComponentPropsHelpers<TProps>
	{
		internal static WrappedProps WrapProps(TProps propsIfAny)
		{
			// Try to extract a Key value from the props - it might be a simple "key" value or it might be a property with a "getKey" function or it
			// might be absent altogether
			Any<string, int> keyIfAny = null;
			if (propsIfAny != null)
			{
				/*@
					if (propsIfAny.key || (propsIfAny.key === 0)) { // Ensure that a zero key is not considered "no-key-defined"
						keyIfAny = propsIfAny.key;
					}
					else if (propsIfAny.getKey && (typeof(propsIfAny.getKey) == "function")) {
						var keyIfAnyFromPropertyGetter = propsIfAny.getKey();
						if (keyIfAnyFromPropertyGetter || (keyIfAnyFromPropertyGetter === 0)) { // Ensure that a zero key is not considered "no-key-defined"
							keyIfAny = keyIfAnyFromPropertyGetter;
						}
						else {
							keyIfAny = undefined;
						}
					}
					else {
						keyIfAny = undefined;
					}
				*/
			}

			// With the changes in React 15.0.0 (vs 0.14.7), a null Key value will be interpreted AS a key (and will either be ".$null" or ".$undefined")
			// when really we want a null Key to mean NO KEY. Possibly related to https://github.com/facebook/react/issues/2386, but I would have expected
			// to have seen this issue in 0.14 if it was that. The workaround is to return a type of "wrapped props" that doesn't even have a Key property
			// on it if there is no key value to use.
			if (Script.Write<bool>("(typeof(keyIfAny) !== 'undefined')"))
				return new WrappedPropsWithKey { Value = propsIfAny, Key = keyIfAny };
			return new WrappedProps { Value = propsIfAny };
		}

		internal static bool DoPropsReferencesMatch(TProps props1, TProps props2)
		{
			if ((props1 == null) && (props2 == null))
				return true;
			else if ((props1 == null) || (props2 == null))
				return false;

			if (props1.GetType() != props2.GetType())
				return false;

			/*@
			for (var propName in props1) {
				var propValue1 = props1[propName];
				var propValue2 = props2[propName];
				if ((propValue1 === propValue2) 
				|| ((propValue1 === null) && (propValue2 === null))
				|| ((typeof(propValue1) === "undefined") && (typeof(propValue2) === "undefined"))) {
					// Very simple cases where the properties match
					continue;
				}
				else if ((propValue1 === null) || (propValue2 === null) || (typeof(propValue1) === "undefined") || (typeof(propValue2) === "undefined")) {
					// Simple cases where one or both of the values are some sort of no-value (but either one of them has a value or they're inconsistent types of no-value,
					// since we'd have caught them above otherwise)
					return false;
				}
				else if ((typeof(propValue1) === "function") && (typeof(propValue2) === "function")) {
					// If they're Bridge-bound functions (which is what the presence of $scope and $method properties indicates), then check whether the underlying $method
					// and $scope references match (if they do then this means that it's the same method bound to the same "this" scope, but the actual function references
					// are not the same since they were the results from two different calls to Bridge.fn.bind)
					if (propValue1.$scope && propValue1.$method && propValue2.$scope && propValue2.$method && (propValue1.$scope === propValue2.$scope)) {
						if (propValue1.$method === propValue2.$method) {
							continue;
						}
						if (propValue1.$method.toString() === propValue2.$method.toString()) {
							// If the bound method is a named function then we can use the cheap reference equality comparison above. This is the ideal case, not only because
							// the comparison is so cheap but also because it means that the function is only declared once. Anonymous functions can't be compared by reference
							// and they have a cost (in terms of creation and in terms of additional GC work) that makes them less desirable. However, if the underlying bound
							// functions are anonymous functions then so long as they have the same content then they may be considered equivalent (since we've already checked
							// the references that they're bound to are the same, above).
							continue;
						}
					}
					// Due to the way that properties are currently initialised on types in Bridge, if a property's type is a struct then the getter and setter for it will
					// be created for each instance of the type, rather than being shared across all instances of the type (which is the case for reference type properties).
					// This means that when it comes to a "getName" property, for example, the "getName" function will not be the same value for two instances of the same
					// class, which is a problem for this function since it will mean that two props references that contain the same data are not identified as such as
					// the getter / setter functions are distinct across instances. A proper fix for this has been requested at:
					//   http://forums.bridge.net/forum/general/feature-requests/1737
					// A temporary workaround is for the getter and setter functions to be identified as such, and then ignored by this process. That would not be particularly
					// easy to do in general, but it IS something that's relatively easy to add to the ProductiveRage.Immutable library (every time that CtorSet is called, the
					// getter and setter methods for the property will have a $scaffolding value set to true). This can be unpicked if the Bridge translation process changes
					// but it means that types that have struct properties that are declared using the IAmImmutable helpers will work before that time.
					if ((propValue1.$scaffolding === true) && (propValue2.$scaffolding === true)) {
						continue;
					}
				}
				else if ((typeof(propValue1.equals) === "function") && (propValue1.equals(propValue2) === true)) {
					// If propValue1 has an "equals" implementation then give that a go
					continue;
				}
				return false;
			}
			*/
			return true;
		}

		[IgnoreGeneric]
		[ObjectLiteral]
		internal class WrappedProps
		{
			public TProps Value { get; set; }
		}

		[ObjectLiteral]
		internal class WrappedPropsWithKey : WrappedProps
		{
			public Any<string, int> Key { get; set; }
		}
	}
}