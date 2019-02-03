using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class FormAttributes : ReactDomElementAttributes<HTMLFormElement>
	{
		public string AcceptCharset { get; set; }
		public string Action { get; set; }
		[Name("autocomplete")]
		public Union<string, AutoComplete> AutoComplete { get; set; }
		public string Encoding { get; set; }
		public string Enctype { get; set; }
		public string Method { get; set; }
		public string Name { get; set; }
		public bool NoValidate { get; set; }
		public string Target { get; set; }
	}
}
