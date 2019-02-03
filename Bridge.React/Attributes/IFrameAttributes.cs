using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class IFrameAttributes : ReactDomElementAttributes<HTMLIFrameElement>
	{
		[Name("allowfullscreen")]
		public bool AllowFullScreen { get; set; }
		[Name("frameborder")]
		public string FrameBorder { get; set; }
		public int Height { get; set; }
		public string LongDesc { get; set; }
		public int MarginHeight { get; set; }
		public int MarginWidth { get; set; }
		public string Name { get; set; }
		public SandboxOptions Sandbox { get; set; }
		public string Scrolling { get; set; }
		public bool Seamless { get; set; }
		public string Src { get; set; }
		public string SrcDoc { get; set; }
		public int Width { get; set; }
	}
}
