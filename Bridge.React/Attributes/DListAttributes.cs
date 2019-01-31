using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class DListAttributes : ReactDomElementAttributes<HTMLDListElement>
	{
		public bool Compact { get; set; }
	}
}
