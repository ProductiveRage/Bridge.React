using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class TableColAttributes : ReactDomElementAttributes<TableColElement>
    {
        public int Span { private get; set; }
    }
}
