using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class ParamAttributes : ReactDomElementAttributes<HTMLParamElement>
	{
		public string Name { private get; set; }
	}
}
