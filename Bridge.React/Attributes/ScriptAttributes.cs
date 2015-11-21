using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class ScriptAttributes : DomElementWithEventsAttributes<ScriptElement>
    {
        public bool Async { private get; set; }
        public string Charset { private get; set; }
        public string CrossOrigin { private get; set; }
        public bool Defer { private get; set; }
        public string Text { private get; set; }
        public string Type { private get; set; }
        public string Src { private get; set; }
    }
}
