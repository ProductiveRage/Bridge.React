using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class DelAttributes : ReactDomElementAttributes<ModElement>
    {
        public string Cite { private get; set; }
        public string DateTime { private get; set; }
    }
}
