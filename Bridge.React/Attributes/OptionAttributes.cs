using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OptionAttributes : ReactDomElementAttributes<HTMLOptionElement>
	{
		public string Label { private get; set; }
		public string Value { private get; set; }
	}
}
