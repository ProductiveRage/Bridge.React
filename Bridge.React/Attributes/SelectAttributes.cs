using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class SelectAttributes : ReactDomElementAttributes<HTMLSelectElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { get; set; }
		public bool Disabled { get; set; }
		public int Length { get; set; }
		public bool Multiple { get; set; }
		public string Name { get; set; }
		public bool Required { get; set; }
		public int Size { get; set; }
		public string Src { get; set; }
		public string Type { get; set; }
		/// <summary>
		/// This property should be used (instead of Values) if Multiple is false
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// This property should be used (instead of Value) if Multiple is true
		/// </summary>
		[Name("value")]
		public string[] Values { get; set; }
	}
}
