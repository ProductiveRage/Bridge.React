using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class InputAttributes : ReactDomElementAttributes<HTMLInputElement>
	{
		public string Accept { get; set; }
		public string Alt { get; set; }
		public Union<string, AutoComplete> AutoComplete { get; set; }
		public bool AutoFocus { get; set; }
		public bool AutoSave { get; set; }
		public bool Checked { get; set; }
		public bool DefaultChecked { get; set; }
		public string DefaultValue { get; set; }
		public bool Disabled { get; set; }
		public string FormAction { get; set; }
		public string FormEncType { get; set; }
		public string FormMethod { get; set; }
		public bool FormNoValidate { get; set; }
		public string FormTarget { get; set; }
		public int Height { get; set; }
		// Note: "Indeterminate" is not support by React (see https://github.com/facebook/react/issues/1798)
		public string Max { get; set; }
		public int MaxLength { get; set; }
		public string Min { get; set; }
		public bool Multiple { get; set; }
		public string Name { get; set; }
		public string Pattern { get; set; }
		public string Placeholder { get; set; }
		public bool ReadOnly { get; set; }
		public bool Required { get; set; }
		public string SelectionDirection { get; set; }
		public int SelectionEnd { get; set; }
		public int SelectionStart { get; set; }
		public int Size { get; set; }
		public string Src { get; set; }
		public string Step { get; set; }
		public InputType Type { get; set; }
		public string UseMap { get; set; }
		public string Value { get; set; }
		public int Width { get; set; }
	}
}
