using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class SourceAttributes : ReactDomElementAttributes<HTMLSourceElement>
	{
		public string Media { get; set; }
		public string Src { get; set; }
		public string Type { get; set; }
	}
}
