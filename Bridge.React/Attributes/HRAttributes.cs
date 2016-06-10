using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class HRAttributes : ReactDomElementAttributes<HTMLHRElement>
    {
        public string Color { private get; set; }
        [Name("noshade")]
        public bool NoShade { private get; set; }
        public string Size { private get; set; }
        public string Width { private get; set; }
    }
}
