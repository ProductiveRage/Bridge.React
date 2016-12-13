using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class SourceAttributes : ReactDomElementAttributes<HTMLSourceElement>
	{
		public string Media { private get; set; }
		public string Src { private get; set; }
		public string Type { private get; set; }
	}
}
