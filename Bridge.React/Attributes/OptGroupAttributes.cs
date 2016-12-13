using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OptGroupAttributes : ReactDomElementAttributes<HTMLOptGroupElement>
	{
		public bool Disabled { private get; set; }
		public string Label { private get; set; }
	}
}
