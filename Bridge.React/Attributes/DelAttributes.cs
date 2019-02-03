using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class DelAttributes : ReactDomElementAttributes<HTMLModElement>
	{
		public string Cite { get; set; }
		public string DateTime { get; set; }
	}
}
