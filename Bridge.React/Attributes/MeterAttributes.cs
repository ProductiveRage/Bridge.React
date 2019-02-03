using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class MeterAttributes : ReactDomElementAttributes<HTMLMeterElement>
	{
		public double High { get; set; }
		public double Low { get; set; }
		public double Max { get; set; }
		public double Min { get; set; }
		public double Optimum { get; set; }
	}
}
