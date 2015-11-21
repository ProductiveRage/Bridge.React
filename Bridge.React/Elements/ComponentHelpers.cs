namespace Bridge.React
{
    /// <summary>
    /// React internals do some monkeying about with props references that will cause problems if the props reference is a Bridge class which does not have
    /// the [ObjectLiteral] attribute on it. The way that the Component and StatelessComponent classes work around this is to wrap props reference in an
    /// object literal since React's meddling is not recursive, it doesn't change any property values on props, it just changes how those top-level
    /// properties are described. This class provides a standard way to wrap the props data. It also performs some magic to extract any "Key"
    /// value from the props, since this must not be tucked away one level deeper since it is a magic React property (for more information
    /// about keyed elements, see https://facebook.github.io/react/docs/multiple-components.html#dynamic-children).
    /// </summary>
    internal static class ComponentHelpers<TProps>
    {
        internal static WrappedProps WrapProps(TProps propsIfAny)
        {
            // TODO: Set children.. possibly
            // Try to extract a Key value from the props - it might be a simple "key" value or it might be a property with a "getKey" function or it
            // might be absent altogether
            Any<string, int> keyIfAny = null;
            if (propsIfAny != null)
            {
                /*@
                    if (propsIfAny.key) {
                        keyIfAny = propsIfAny.key;
                    }
                    else if (propsIfAny.getKey && (typeof(propsIfAny.getKey) == "function")) {
                        keyIfAny = propsIfAny.getKey();
                    }
                    else {
                        keyIfAny = undefined;
                    }
                */
            }
            return new WrappedProps { Value = propsIfAny, Key = keyIfAny };
        }

        [ObjectLiteral]
        internal class WrappedProps
        {
            public TProps Value { get; set; }
            public Any<string, int> Key { get; set; }
        }
    }
}