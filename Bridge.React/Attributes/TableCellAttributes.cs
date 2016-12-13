using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class TableCellAttributes : ReactDomElementAttributes<TableCellElement>
	{
		public int ColSpan { private get; set; }
		public int RowSpan { private get; set; }
		public int CellIndex { private get; set; }
		public string valign { private get; set; }
	}
}
