using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class OptGroupAttributes : ReactDomElementAttributes<OptGroupElement>
    {
        public bool Disabled { private get; set; }
        public string Label { private get; set; }
    }
}
