using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class OptionAttributes : ReactDomElementAttributes<HTMLOptionElement>
    {
        public string Label { private get; set; }
        public string Value { private get; set; }
    }
}
