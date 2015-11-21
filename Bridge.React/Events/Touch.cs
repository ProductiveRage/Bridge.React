namespace Bridge.React
{
    public sealed class Touch
    {
        public readonly long Identifier;
        public readonly DomElementsAttributes Target;
        public readonly double ScreenX;
        public readonly double ScreenY;
        public readonly double ClientX;
        public readonly double ClientY;
        public readonly double PageX;
        public readonly double PageY;
        public readonly float RadiusX;
        public readonly float RadiusY;
        public readonly float RotationAngle;
        public readonly float Force;
    }
}
