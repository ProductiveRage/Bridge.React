using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
	public sealed class TitleAttributes : ReactDomElementAttributes<HTMLTitleElement>
	{
		public string Text { private get; set; }
	}
}
