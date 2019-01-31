using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class MetaAttributes : ReactDomElementAttributes<HTMLMetaElement>
	{
		public string Content { get; set; }
		public string HttpEquiv { get; set; }
		public string Name { get; set; }
	}
}
