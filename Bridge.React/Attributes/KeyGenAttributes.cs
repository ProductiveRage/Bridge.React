using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class KeygenAttributes : ReactDomElementAttributes<HTMLKeygenElement>
	{
		[Name("autofocus")]
		public bool AutoFocus { private get; set; }
		[Name("autosave")]
		public bool AutoSave { private get; set; }
		public string Challenge { private get; set; }
		public bool Disabled { private get; set; }
		public string KeyType { private get; set; }
	}
}
