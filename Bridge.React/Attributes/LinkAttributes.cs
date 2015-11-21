using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class LinkAttributes : DomElementWithEventsAttributes<LinkElement>
    {
        public bool Disabled { private get; set; }
        public string Href { private get; set; }
        [Name("hreflang")]
        public string HrefLang { private get; set; }
        public string Media { private get; set; }
        public string Rel { private get; set; }
        public string Type { private get; set; }
    }
}
