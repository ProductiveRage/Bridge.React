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