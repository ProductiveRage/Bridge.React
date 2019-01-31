using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class LinkAttributes : ReactDomElementAttributes<HTMLLinkElement>
	{
		public bool Disabled { get; set; }
		public string Href { get; set; }
		[Name("hreflang")]
		public string HrefLang { get; set; }
		public string Media { get; set; }
		public string Rel { get; set; }
		public string Type { get; set; }
	}
}
