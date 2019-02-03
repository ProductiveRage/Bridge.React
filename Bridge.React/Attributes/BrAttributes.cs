using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class BrAttributes : ReactDomElementAttributes<HTMLBRElement>
	{
		public string Clear { get; set; }
	}
}
