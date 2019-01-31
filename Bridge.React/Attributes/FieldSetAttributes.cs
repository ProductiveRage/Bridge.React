using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class FieldSetAttributes : ReactDomElementAttributes<HTMLFieldSetElement>
	{
		public bool Disabled { get; set; }
		public string Name { get; set; }
		public bool WillValidate { get; set; }
	}
}
