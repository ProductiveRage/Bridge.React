using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class LIAttributes : ReactDomElementAttributes<HTMLLIElement>
	{
		public string Type { get; set; }
		public int Value { get; set; }
	}
}
