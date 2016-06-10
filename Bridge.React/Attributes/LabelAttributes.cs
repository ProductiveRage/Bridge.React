using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class LabelAttributes : ReactDomElementAttributes<HTMLLabelElement>
    {
        public string HtmlFor { private get; set; }
    }
}
