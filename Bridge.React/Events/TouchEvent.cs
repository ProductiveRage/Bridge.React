using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TouchEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
	{
		private TouchEvent() { }

		public readonly bool AltKey;
		public readonly bool CtrlKey;
		public readonly bool MetaKey;
		public readonly bool ShiftKey;

		public readonly Touch[] ChangedTouches;
		public readonly Touch[] TargetTouches;
		public readonly Touch[] Touches;

		[External]
		public extern bool GetModifierState(int key);
	}
}
