using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public sealed class MediaEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private MediaEvent() { }
    }
}
