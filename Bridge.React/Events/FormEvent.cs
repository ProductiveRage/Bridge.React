using Bridge.Html5;

namespace Bridge.React
{
    [External]
    public sealed class FormEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
    {
        private FormEvent() { }
    }
}
