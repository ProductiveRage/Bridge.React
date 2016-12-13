using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class InputAttributes : ReactDomElementAttributes<HTMLInputElement>
	{
		public string Accept { private get; set; }
		public string Alt { private get; set; }
		[Name("autocomplete")]
		public AutoComplete AutoComplete { private get; set; }
		[Name("autofocus")]
		public bool AutoFocus { private get; set; }
		[Name("autosave")]
		public bool AutoSave { private get; set; }
		public bool Checked { private get; set; }
		public bool DefaultChecked { private get; set; }
		public string DefaultValue { private get; set; }
		public bool Disabled { private get; set; }
		public string FormAction { private get; set; }
		public string FormEncType { private get; set; }
		public string FormMethod { private get; set; }
		public bool FormNoValidate { private get; set; }
		public string FormTarget { private get; set; }
		public int Height { private get; set; }
		// Note: "Indeterminate" is not support by React (see https://github.com/facebook/react/issues/1798)
		public string Max { private get; set; }
		public int MaxLength { private get; set; }
		public string Min { private get; set; }
		public bool Multiple { private get; set; }
		public string Name { private get; set; }
		public string Pattern { private get; set; }
		public string Placeholder { private get; set; }
		public bool ReadOnly { private get; set; }
		public bool Required { private get; set; }
		public string SelectionDirection { private get; set; }
		public int SelectionEnd { private get; set; }
		public int SelectionStart { private get; set; }
		public int Size { private get; set; }
		public string Src { private get; set; }
		public string Step { private get; set; }
		public InputType Type { private get; set; }
		public string UseMap { private get; set; }
		public string Value { private get; set; }
		public int Width { private get; set; }
	}
}
