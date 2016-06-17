using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
    public sealed class OptionAttributes : ReactDomElementAttributes<OptionElement>
    {
        public string Label { private get; set; }
        public string Value { private get; set; }
    }
}
