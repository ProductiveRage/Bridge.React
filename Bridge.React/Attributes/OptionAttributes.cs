using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OptionAttributes : ReactDomElementAttributes<HTMLOptionElement>
	{
		public bool Disabled { get; set; }
		public string Label { get; set; }
		public string Value { get; set; }
	}
}
