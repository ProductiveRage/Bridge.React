using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public abstract class SyntheticEvent<TCurrentTarget> where TCurrentTarget : EventTarget
	{
		protected SyntheticEvent() { }

		public readonly bool Bubbles;
		public readonly bool Cancelable;
		public readonly TCurrentTarget CurrentTarget;
		public readonly bool DefaultPrevented;
		public readonly int EventPhase;
		public readonly bool IsTrusted;
		public readonly dynamic NativeEvent;
		public readonly EventTarget Target;
		public readonly int TimeStamp;
		public readonly string Type;

		[External]
		public extern void PreventDefault();
		[External]
		public extern bool IsDefaultPrevented();
		[External]
		public extern void StopPropagation();
		[External]
		public extern bool IsPropagationStopped();

		[External]
		public extern void Persist();
	}
}
