using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class StyleAttributes : ReactDomElementAttributes<StyleElement>
    {
        public string Media { private get; set; }
        public string Type { private get; set; }
        public bool Disabled { private get; set; }
        public StyleSheet Sheet { private get; set; }
    }
}
