using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class CanvasAttributes : ReactDomElementAttributes<HTMLCanvasElement>
	{
		public int Height { get; set; }
		public int Width { get; set; }
	}
}
