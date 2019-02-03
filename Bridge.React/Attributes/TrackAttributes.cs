using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TrackAttributes : ReactDomElementAttributes<HTMLTrackElement>
	{
		public string Kind { get; set; }
		public string Src { get; set; }
		[Name("srclang")]
		public string SrcLang { get; set; }
		public string Label { get; set; }
		public bool Default { get; set; }
	}
}
