using Bridge.Html5;

namespace Bridge.React
{
    [External]
    public sealed class ImageEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private ImageEvent() { }
    }
}
