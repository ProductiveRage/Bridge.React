using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ButtonAttributes : ReactDomElementAttributes<HTMLButtonElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { get; set; }
		public bool Disabled { get; set; }
		public string FormAction { get; set; }
		public string FormEncType { get; set; }
		public string FormMethod { get; set; }
		public bool FormNoValidate { get; set; }
		public string FormTarget { get; set; }
		public string Name { get; set; }
		public ButtonType Type { get; set; }
	}
}
