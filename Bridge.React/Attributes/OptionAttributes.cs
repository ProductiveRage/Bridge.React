using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
    public sealed class OptionAttributes : ReactDomElementAttributes<OptionElement>
    {
        public bool DefaultSelected { private get; set; }
        public bool Disable { private get; set; }
        public string Label { private get; set; }
        public bool Selected { private get; set; }
        public string Value { private get; set; }
    }
}
