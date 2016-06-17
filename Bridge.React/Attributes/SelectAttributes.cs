namespace Bridge.React
{
	[ObjectLiteral]
	public sealed class SelectAttributes : ReactDomElementAttributes<HTMLSelectElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { private get; set; }
		public bool Disabled { private get; set; }
		public int Length { private get; set; }
		public bool Multiple { private get; set; }
		public string Name { private get; set; }
		public bool Required { private get; set; }
		public int Size { private get; set; }
		public string Src { private get; set; }
		public string Type { private get; set; }
		/// <summary>
		/// This property should be used (instead of Values) if Multiple is false
		/// </summary>
		public string Value { private get; set; }
		/// <summary>
		/// This property should be used (instead of Value) if Multiple is true
		/// </summary>
		[Name("value")]
		public string[] Values { private get; set; }
	}
}
