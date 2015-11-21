using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class TableCellAttributes : DomElementWithEventsAttributes<TableCellElement>
    {
        [Name("colspan")]
        public int ColSpan { private get; set; }
        [Name("rowspan")]
        public string RowSpan { private get; set; }
        public int CellIndex { private get; set; }
    }
}
