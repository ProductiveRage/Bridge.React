using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class InsAttributes : DomElementWithEventsAttributes<ModElement>
    {
        public string Cite { private get; set; }
        public string DateTime { private get; set; }
    }
}
