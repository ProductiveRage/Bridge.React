using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class BaseAttributes : ReactDomElementAttributes<HTMLBaseElement>
	{
		public string Href { get; set; }
		public string Target { get; set; }
	}
}
