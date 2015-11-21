using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class BodyAttributes : DomElementWithEventsAttributes<BodyElement>
    {
        public string ALink { private get; set; }
        public string Background { private get; set; }
        public string BgColor { private get; set; }
        public string Link { private get; set; }
        public string Text { private get; set; }
        public string VLink { private get; set; }
    }
}
