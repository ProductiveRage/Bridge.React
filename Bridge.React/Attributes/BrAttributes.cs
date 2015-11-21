using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class BrAttributes : DomElementWithEventsAttributes<BRElement>
    {
        public string Clear { private get; set; }
    }
}
