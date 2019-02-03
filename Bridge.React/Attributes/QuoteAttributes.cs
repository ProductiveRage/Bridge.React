using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class QuoteAttributes : ReactDomElementAttributes<HTMLQuoteElement>
	{
		public string Cite { get; set; }
	}
}
