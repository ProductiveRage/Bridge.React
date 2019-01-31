using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ObjectAttributes : ReactDomElementAttributes<HTMLObjectElement>
	{
		public new string Data { get; set; }
		public int Height { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public bool TypeMustMatch { get; set; }
		public string useMap { get; set; }
		public int Width { get; set; }
		public bool WillValidate { get; set; }
	}
}
