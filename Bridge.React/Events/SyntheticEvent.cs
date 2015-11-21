using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public abstract class SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        protected SyntheticEvent() { }

        public readonly bool Bubbles;
        public readonly bool Cancelable;
        public readonly TCurrentTarget CurrentTarget;
        public readonly bool DefaultPrevented;
        public readonly int EventPhase;
        public readonly bool IsTrusted;
        public readonly dynamic NativeEvent;
        public readonly DomElementsAttributes Target;
        public readonly int TimeStamp;
        public readonly string Type;

        [Ignore]
        public extern void PreventDefault();
        [Ignore]
        public extern bool IsDefaultPrevented();
        [Ignore]
        public extern void StopPropagation();
        [Ignore]
        public extern bool IsPropagationStopped();

        [Ignore]
        public extern void Persist();
    }
}
