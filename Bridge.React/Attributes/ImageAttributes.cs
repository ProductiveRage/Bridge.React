using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ImageAttributes : ReactDomElementAttributes<HTMLImageElement>
	{
		public string Alt { private get; set; }
		public string CrossOrigin { private get; set; }
		public int Height { private get; set; }
		public bool IsMap { private get; set; }
		public string Src { private get; set; }
		public string SrcSet { private get; set; }
		public string UseMap { private get; set; }
		public int Width { private get; set; }
	}
}
