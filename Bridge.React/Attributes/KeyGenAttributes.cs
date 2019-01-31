using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class KeygenAttributes : ReactDomElementAttributes<HTMLKeygenElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { get; set; }
		[Name("autosave")]
		public bool AutoSave { get; set; }
		public string Challenge { get; set; }
		public bool Disabled { get; set; }
		public string KeyType { get; set; }
	}
}
