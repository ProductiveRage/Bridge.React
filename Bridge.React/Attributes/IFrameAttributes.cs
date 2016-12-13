using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class IFrameAttributes : ReactDomElementAttributes<HTMLIFrameElement>
	{
		[Name("allowfullscreen")]
		public bool AllowFullScreen { private get; set; }
		[Name("frameborder")]
		public string FrameBorder { private get; set; }
		public int Height { private get; set; }
		public string LongDesc { private get; set; }
		public int MarginHeight { private get; set; }
		public int MarginWidth { private get; set; }
		public string Name { private get; set; }
		public SandboxOptions Sandbox { private get; set; }
		public string Scrolling { private get; set; }
		public bool Seamless { private get; set; }
		public string Src { private get; set; }
		public string SrcDoc { private get; set; }
		public int Width { private get; set; }
	}
}
