using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TableColAttributes : ReactDomElementAttributes<HTMLTableColElement>
	{
		public int Span { private get; set; }
	}
}
