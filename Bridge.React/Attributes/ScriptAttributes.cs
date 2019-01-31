using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ScriptAttributes : ReactDomElementAttributes<HTMLScriptElement>
	{
		public bool Async { get; set; }
		public string Charset { get; set; }
		public string CrossOrigin { get; set; }
		public bool Defer { get; set; }
		public string Text { get; set; }
		public string Type { get; set; }
		public string Src { get; set; }
	}
}
