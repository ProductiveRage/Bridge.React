using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class StyleAttributes : ReactDomElementAttributes<HTMLStyleElement>
	{
		public string Media { private get; set; }
		public string Type { private get; set; }
		public bool Disabled { private get; set; }
		public StyleSheet Sheet { private get; set; }
	}
}
