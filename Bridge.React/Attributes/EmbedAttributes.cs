using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class EmbedAttributes : ReactDomElementAttributes<HTMLEmbedElement>
	{
		public int Height { get; set; }
		public string Name { get; set; }
		public string Src { get; set; }
		public string Type { get; set; }
		public string Width { get; set; }
	}
}
