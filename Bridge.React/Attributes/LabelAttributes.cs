using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class LabelAttributes : ReactDomElementAttributes<LabelElement>
    {
        public string HtmlFor { private get; set; }
    }
}
