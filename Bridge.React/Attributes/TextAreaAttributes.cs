using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TextAreaAttributes : ReactDomElementAttributes<HTMLTextAreaElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { get; set; }
		public int Cols { get; set; }
		public string DefaultValue { get; set; }
		public bool Disabled { get; set; }
		public int MaxLength { get; set; }
		public string Name { get; set; }
		public string Placeholder { get; set; }
		public bool ReadOnly { get; set; }
		public bool Required { get; set; }
		public int Rows { get; set; }
		public string SelectionDirection { get; set; }
		public int SelectionEnd { get; set; }
		public int SelectionStart { get; set; }
		/// <summary>
		/// This should be used to set the the value of a TextArea, React includes a warning if TextArea contents are set using children (so this is not allowed with these bindings)
		/// </summary>
		public string Value { get; set; }
		public Wrap Wrap { get; set; }
	}
}
