using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OListAttributes : ReactDomElementAttributes<HTMLOListElement>
	{
		public bool Reversed { get; set; }
		public int Start { get; set; }
		public OListType Type { get; set; }
	}
}
