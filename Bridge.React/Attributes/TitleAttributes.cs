using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class TitleAttributes : DomElementWithEventsAttributes<TitleElement>
    {
        public string Text { private get; set; }
    }
}
