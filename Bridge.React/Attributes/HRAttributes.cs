using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class HRAttributes : ReactDomElementAttributes<HTMLHRElement>
	{
		public string Color { get; set; }
		[Name("noshade")]
		public bool NoShade { get; set; }
		public string Size { get; set; }
		public string Width { get; set; }
	}
}
