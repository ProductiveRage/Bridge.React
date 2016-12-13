using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OutputAttributes : ReactDomElementAttributes<HTMLOutputElement>
	{
		public string DefaultValue { private get; set; }
		public string Name { private get; set; }
		public string Type { private get; set; }
	}
}
