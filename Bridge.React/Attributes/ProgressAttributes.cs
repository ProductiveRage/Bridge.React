using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ProgressAttributes : ReactDomElementAttributes<HTMLProgressElement>
	{
		public double Max { get; set; }
		public double Value { get; set; }
	}
}
