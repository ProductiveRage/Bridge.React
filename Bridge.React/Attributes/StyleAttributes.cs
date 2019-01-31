using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class StyleAttributes : ReactDomElementAttributes<HTMLStyleElement>
	{
		public string Media { get; set; }
		public string Type { get; set; }
		public bool Disabled { get; set; }
		public StyleSheet Sheet { get; set; }
	}
}
