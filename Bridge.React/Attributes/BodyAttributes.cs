using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class BodyAttributes : ReactDomElementAttributes<HTMLBodyElement>
	{
		public string ALink { private get; set; }
		public string Background { private get; set; }
		public string BgColor { private get; set; }
		public string Link { private get; set; }
		public string Text { private get; set; }
		public string VLink { private get; set; }
	}
}
