using Bridge.Html5;

namespace Bridge.React
{
    public abstract class ReactDomElementAttributes<TCurrentTarget> : DomElementWithEventsAttributes<TCurrentTarget> where TCurrentTarget : Element
    {
        /// <summary>
        /// It's important for React elements to have the ability for a key to be explicitly specified for them so that when dynamic children are generated,
        /// React can reconcile them (see http://facebook.github.io/react/docs/multiple-components.html#dynamic-children). It is common to use numeric keys
        /// but it is also permitted to use strings (actually, React allows any type but it to-strings its value, so it makes more sense to explicitly
        /// limit the values to integers and strings).
        /// </summary>
        public Any<string, int> Key { private get; set; }
    }
}
