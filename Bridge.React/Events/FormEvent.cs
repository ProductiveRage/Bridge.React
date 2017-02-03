using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class FormEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
	{
		private FormEvent() { }
	}
}
