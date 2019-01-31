using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class BodyAttributes : ReactDomElementAttributes<HTMLBodyElement>
	{
		public string ALink { get; set; }
		public string Background { get; set; }
		public string BgColor { get; set; }
		public string Link { get; set; }
		public string Text { get; set; }
		public string VLink { get; set; }
	}
}
