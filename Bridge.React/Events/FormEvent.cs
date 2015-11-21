using Bridge.Html5;

namespace Bridge.React
{
    [Ignore]
    public sealed class FormEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private FormEvent() { }
    }
}
