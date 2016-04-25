using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
	public sealed class TextAreaAttributes : ReactDomElementAttributes<TextAreaElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { private get; set; }
		public int Cols { private get; set; }
		public string DefaultValue { private get; set; }
		public bool Disabled { private get; set; }
		public int MaxLength { private get; set; }
		public string Name { private get; set; }
		public string Placeholder { private get; set; }
		public bool ReadOnly { private get; set; }
		public bool Required { private get; set; }
		public int Rows { private get; set; }
		public string SelectionDirection { private get; set; }
		public int SelectionEnd { private get; set; }
		public int SelectionStart { private get; set; }
		/// <summary>
		/// This should be used to set the the value of a TextArea, React includes a warning if TextArea contents are set using children (so this is not allowed with these bindings)
		/// </summary>
		public string Value { private get; set; }
		public Wrap Wrap { private get; set; }
	}
}
