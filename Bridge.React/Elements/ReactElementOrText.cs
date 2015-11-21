namespace Bridge.React
{
    /// <summary>
    /// While React components must return a ReactElement instance from their Render method, when specify child elements (eg. when calling React.DOM.div) it
    /// must be possible to specify EITHER a ReactElement OR a string. This type allows for that since it means that the React method signature can specify
    /// the ReactElement type as a return type while any function that takes child components may use this class as its element type - it will then accept
    /// either of the required types.
    /// </summary>
    [Ignore]
    public sealed class ReactElementOrText
    {
        private ReactElementOrText() { }
        [Ignore] public extern static implicit operator ReactElementOrText(string text);
        [Ignore] public extern static implicit operator ReactElementOrText(ReactElement element);
    }
}
