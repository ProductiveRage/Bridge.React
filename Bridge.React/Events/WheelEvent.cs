using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public sealed class WheelEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private WheelEvent() { }

        public readonly int DeltaMode;
        public readonly int DeltaX;
        public readonly int DeltaY;
        public readonly int DeltaZ;
    }
}
