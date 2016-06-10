using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class QuoteAttributes : ReactDomElementAttributes<HTMLQuoteElement>
    {
        public string Cite { private get; set; }
    }
}
