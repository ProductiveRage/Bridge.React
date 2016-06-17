using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class CanvasAttributes : ReactDomElementAttributes<HTMLCanvasElement>
    {
        public int Height { private get; set; }
        public int Width { private get; set; }
    }
}
