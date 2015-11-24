using Bridge.Html5;

namespace Bridge.React
{
    [External]
    public sealed class MouseEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private MouseEvent() { }

        public readonly bool AltKey;
        public readonly int Button;
        public readonly int Buttons;
        public readonly int ClientX;
        public readonly int ClientY;
        public readonly bool CtrlKey;
        public readonly bool MetaKey;
        public readonly int PageX;
        public readonly int PageY;
        public readonly Element RelatedTarget;
        public readonly int ScreenX;
        public readonly int ScreenY;
        public readonly bool ShiftKey;
        
        [External]
        public extern bool GetModifierState(int key);
    }
}
