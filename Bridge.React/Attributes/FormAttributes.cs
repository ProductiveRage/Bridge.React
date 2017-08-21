using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class FormAttributes : ReactDomElementAttributes<HTMLFormElement>
	{
		public string AcceptCharset { private get; set; }
		public string Action { private get; set; }
		[Name("autocomplete")]
		public Union<string, AutoComplete> AutoComplete { private get; set; }
		public string Encoding { private get; set; }
		public string Enctype { private get; set; }
		public string Method { private get; set; }
		public string Name { private get; set; }
		public bool NoValidate { private get; set; }
		public string Target { private get; set; }
	}
}
