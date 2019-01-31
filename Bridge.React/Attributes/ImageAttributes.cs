using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ImageAttributes : ReactDomElementAttributes<HTMLImageElement>
	{
		public string Alt { get; set; }
		public string CrossOrigin { get; set; }
		public int Height { get; set; }
		public bool IsMap { get; set; }
		public string Src { get; set; }
		public string SrcSet { get; set; }
		public string UseMap { get; set; }
		public int Width { get; set; }
	}
}
