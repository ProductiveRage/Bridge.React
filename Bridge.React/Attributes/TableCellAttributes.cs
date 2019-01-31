using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TableCellAttributes : ReactDomElementAttributes<TableCellElement>
	{
		public int ColSpan { get; set; }
		public int RowSpan { get; set; }
		public int CellIndex { get; set; }
		public string valign { get; set; }
	}
}
