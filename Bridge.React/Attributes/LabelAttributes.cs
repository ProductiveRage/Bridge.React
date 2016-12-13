using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class LabelAttributes : ReactDomElementAttributes<HTMLLabelElement>
	{
		public string HtmlFor { private get; set; }
	}
}
