using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class LIAttributes : DomElementWithEventsAttributes<LIElement>
    {
        public string Type { private get; set; }
        public int Value { private get; set; }
    }
}
