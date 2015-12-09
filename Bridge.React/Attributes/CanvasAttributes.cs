using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class CanvasAttributes : ReactDomElementAttributes<CanvasElement>
    {
        public int Height { private get; set; }
        public int Width { private get; set; }
    }
}
