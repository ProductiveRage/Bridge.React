using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class UIEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
	{
		private UIEvent() { }

		public readonly int Detail;
		// TODO public readonly DOMAbstractView View;
	}
}
