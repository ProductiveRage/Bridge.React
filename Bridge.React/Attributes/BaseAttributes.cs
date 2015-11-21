using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class BaseAttributes : DomElementWithEventsAttributes<BaseElement>
    {
        public string Href { private get; set; }
        public string Target { private get; set; }
    }
}
