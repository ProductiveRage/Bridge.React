using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class OutputAttributes : ReactDomElementAttributes<HTMLOutputElement>
	{
		public string DefaultValue { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
	}
}
