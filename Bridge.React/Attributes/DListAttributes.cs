using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class DListAttributes : ReactDomElementAttributes<HTMLDListElement>
    {
        public bool Compact { private get; set; }
    }
}
