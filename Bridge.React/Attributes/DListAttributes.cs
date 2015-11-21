using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class DListAttributes : DomElementWithEventsAttributes<DListElement>
    {
        public bool Compact { private get; set; }
    }
}
