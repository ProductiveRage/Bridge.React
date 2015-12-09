using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class ProgressAttributes : ReactDomElementAttributes<ProgressElement>
    {
        public double Max { private get; set; }
        public double Value { private get; set; }
    }
}
