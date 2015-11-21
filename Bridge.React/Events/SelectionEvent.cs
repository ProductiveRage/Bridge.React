using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public sealed class SelectionEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private SelectionEvent() { }
    }
}
