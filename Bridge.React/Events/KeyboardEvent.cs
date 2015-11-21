using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public sealed class KeyboardEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private KeyboardEvent() { }

        public readonly bool AltKey;
        public readonly int CharCode;
        public readonly bool CtrlKey;
        public readonly string Key;
        public readonly int KeyCode;
        public readonly string Locale;
        public readonly int Location;
        public readonly bool MetaKey;
        public readonly bool Repeat;
        public readonly bool ShiftKey;
        public readonly int Which;

        [Ignore]
        public extern bool GetModifierState(int key);
    }
}
