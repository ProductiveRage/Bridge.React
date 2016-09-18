using Bridge.Html5;

namespace Bridge.React
{
	[ObjectLiteral]
	public abstract class DomElementsAttributes
	{
		public string ClassName { private get; set; }
		public string Id { private get; set; }
		public string AccessKey { private get; set; }
		public ContentEditable ContentEditable { private get; set; }
		public TextDirection Dir { private get; set; }
		public string Lang { private get; set; }
		public int TabIndex { private get; set; }
		public string Title { private get; set; }

		/// <summary>
		/// Warning: If this is used then the element may have no other child specified
		/// </summary>
		[Name("dangerouslySetInnerHTML")]
		public RawHtml DangerouslySetInnerHTML { private get; set; }
	}
}
