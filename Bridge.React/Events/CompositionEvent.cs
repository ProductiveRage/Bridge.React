using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class CompositionEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
	{
		private CompositionEvent() { }

		public readonly string Data;
	}
}
