using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class LabelAttributes : DomElementWithEventsAttributes<LabelElement>
    {
        public string HtmlFor { private get; set; }
    }
}
