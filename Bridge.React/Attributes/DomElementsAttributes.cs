using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public abstract class DomElementsAttributes
	{
		public string ClassName { private get; set; }
		public string Id { private get; set; }
		public string AccessKey { private get; set; }
		public ContentEditable ContentEditable { private get; set; }
		public TextDirection Dir { private get; set; }
		public bool Draggable { private get; set; }
		public string Lang { private get; set; }
		public int TabIndex { private get; set; }
		public string Title { private get; set; }

		/// <summary>
		/// Any properties on this reference will be taken to form "data-*" attributes (eg. if the Data reference has a "toggle" property set to "on" then the attributes
		/// passed to React will include a "data-toggle" value with the value "on"). The properties on the Data reference should not include the "data-" prefix. Since
		/// hyphens are not valid for use in C# property names, hyphens should be replaced by underscores and the underscores will be transformed back into hyphens
		/// when the React attributes are set (eg. if the Data reference has a property "toggle_me" then an attribute "data-toggle-me" will be set in React).
		/// </summary>
		public dynamic Data { private get; set; }

        /// <summary>
        /// Any properties on this reference will be taken to form "aria-*" attributes (eg. if the Aria reference has a "hidden" property set to "true" then the attributes
        /// passed to React will include a "aria-hidden" value with the value "true"). The properties on the Aria reference should not include the "aria-" prefix.
        /// </summary>
        public dynamic Aria { private get; set; }

		/// <summary>
		/// Warning: If this is used then the element may have no other child specified
		/// </summary>
		[Name("dangerouslySetInnerHTML")]
		public RawHtml DangerouslySetInnerHTML { private get; set; }
	}
}
