using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class CanvasAttributes : DomElementWithEventsAttributes<CanvasElement>
    {
        public int Height { private get; set; }
        public int Width { private get; set; }
    }
}
