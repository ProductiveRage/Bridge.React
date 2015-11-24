using Bridge.Html5;

namespace Bridge.React
{
    [External]
    public sealed class MediaEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private MediaEvent() { }
    }
}
