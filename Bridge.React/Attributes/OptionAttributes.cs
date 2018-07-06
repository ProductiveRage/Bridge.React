using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OptionAttributes : ReactDomElementAttributes<HTMLOptionElement>
	{
		public bool Disabled { private get; set; }
		public string Label { private get; set; }
		public string Value { private get; set; }
	}
}
