using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class QuoteAttributes : ReactDomElementAttributes<QuoteElement>
    {
        public string Cite { private get; set; }
    }
}
