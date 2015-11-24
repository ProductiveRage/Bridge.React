namespace Bridge.React
{
    [Name("React.DOM")]
    [External]
    public static class DOM
    {
        [Name("a")]
        public extern static ReactElement A(AnchorAttributes properties, params ReactElementOrText[] children);

        [Name("abbr")]
        public extern static ReactElement Abbr(Attributes properties, params ReactElementOrText[] children);

        [Name("address")]
        public extern static ReactElement Address(Attributes properties, params ReactElementOrText[] children);

        [Name("area")]
        public extern static ReactElement Area(AreaAttributes properties, params ReactElementOrText[] children);

        [Name("article")]
        public extern static ReactElement Article(Attributes properties, params ReactElementOrText[] children);

        [Name("aside")]
        public extern static ReactElement Aside(Attributes properties, params ReactElementOrText[] children);

        [Name("audio")]
        public extern static ReactElement Audio(Attributes properties, params ReactElementOrText[] children);

        [Name("b")]
        public extern static ReactElement B(Attributes properties, params ReactElementOrText[] children);

        [Name("base")]
        public extern static ReactElement Base(BaseAttributes properties, params ReactElementOrText[] children);

        [Name("bdi")]
        public extern static ReactElement BDI(Attributes properties, params ReactElementOrText[] children);

        [Name("bdo")]
        public extern static ReactElement BDO(Attributes properties, params ReactElementOrText[] children);

        [Name("big")]
        public extern static ReactElement Big(Attributes properties, params ReactElementOrText[] children);

        [Name("blockquote")]
        public extern static ReactElement BlockQuote(QuoteAttributes properties, params ReactElementOrText[] children);

        [Name("body")]
        public extern static ReactElement Body(BodyAttributes properties, params ReactElementOrText[] children);

        [Name("br")]
        public extern static ReactElement Br(BrAttributes properties, params ReactElementOrText[] children);

        [Name("button")]
        public extern static ReactElement Button(ButtonAttributes properties, params ReactElementOrText[] children);

        [Name("canvas")]
        public extern static ReactElement Canvas(CanvasAttributes properties, params ReactElementOrText[] children);

        [Name("caption")]
        public extern static ReactElement Caption(Attributes  properties, params ReactElementOrText[] children);

        [Name("cite")]
        public extern static ReactElement Cite(Attributes properties, params ReactElementOrText[] children);

        [Name("code")]
        public extern static ReactElement Code(Attributes properties, params ReactElementOrText[] children);

        [Name("col")]
        public extern static ReactElement Col(TableColAttributes properties, params ReactElementOrText[] children);

        [Name("colgroup")]
        public extern static ReactElement ColGroup(Attributes properties, params ReactElementOrText[] children);

        [Name("data")]
        public extern static ReactElement Data(Attributes properties, params ReactElementOrText[] children);

        [Name("datalist")]
        public extern static ReactElement DataList(Attributes properties, params ReactElementOrText[] children);

        [Name("dd")]
        public extern static ReactElement DD(Attributes properties, params ReactElementOrText[] children);

        [Name("del")]
        public extern static ReactElement Del(DelAttributes properties, params ReactElementOrText[] children);

        [Name("details")]
        public extern static ReactElement Details(Attributes properties, params ReactElementOrText[] children);

        [Name("dfn")]
        public extern static ReactElement Dfn(Attributes properties, params ReactElementOrText[] children);

        [Name("dialog")]
        public extern static ReactElement Dialog(Attributes properties, params ReactElementOrText[] children);

        [Name("div")]
        public extern static ReactElement Div(Attributes properties, params ReactElementOrText[] children);

        [Name("dl")]
        public extern static ReactElement DL(DListAttributes properties, params ReactElementOrText[] children);

        [Name("dt")]
        public extern static ReactElement DT(Attributes properties, params ReactElementOrText[] children);

        [Name("em")]
        public extern static ReactElement Em(Attributes properties, params ReactElementOrText[] children);

        [Name("embed")]
        public extern static ReactElement Embed(EmbedAttributes properties, params ReactElementOrText[] children);

        [Name("fieldset")]
        public extern static ReactElement FieldSet(FieldSetAttributes properties, params ReactElementOrText[] children);

        [Name("figcaption")]
        public extern static ReactElement FigCaption(Attributes properties, params ReactElementOrText[] children);

        [Name("figure")]
        public extern static ReactElement Figure(Attributes properties, params ReactElementOrText[] children);

        [Name("footer")]
        public extern static ReactElement Footer(Attributes properties, params ReactElementOrText[] children);

        [Name("form")]
        public extern static ReactElement Form(FormAttributes properties, params ReactElementOrText[] children);

        [Name("h1")]
        public extern static ReactElement H1(Attributes properties, params ReactElementOrText[] children);

        [Name("h2")]
        public extern static ReactElement H2(Attributes properties, params ReactElementOrText[] children);

        [Name("h3")]
        public extern static ReactElement H3(Attributes properties, params ReactElementOrText[] children);

        [Name("h4")]
        public extern static ReactElement H4(Attributes properties, params ReactElementOrText[] children);

        [Name("h5")]
        public extern static ReactElement H5(Attributes properties, params ReactElementOrText[] children);

        [Name("h6")]
        public extern static ReactElement H6(Attributes properties, params ReactElementOrText[] children);

        [Name("head")]
        public extern static ReactElement Head(Attributes properties, params ReactElementOrText[] children);

        [Name("header")]
        public extern static ReactElement Header(Attributes properties, params ReactElementOrText[] children);

        [Name("hgroup")]
        public extern static ReactElement HGroup(Attributes properties, params ReactElementOrText[] children);

        [Name("hr")]
        public extern static ReactElement Hr(HRAttributes properties, params ReactElementOrText[] children);

        [Name("html")]
        public extern static ReactElement Html(Attributes properties, params ReactElementOrText[] children);

        [Name("i")]
        public extern static ReactElement I(Attributes properties, params ReactElementOrText[] children);

        [Name("iframe")]
        public extern static ReactElement IFrame(IFrameAttributes properties, params ReactElementOrText[] children);

        [Name("img")]
        public extern static ReactElement Img(ImageAttributes properties, params ReactElementOrText[] children);

        [Name("input")]
        public extern static ReactElement Input(InputAttributes properties, params ReactElementOrText[] children);
        
        [Name("ins")]
        public extern static ReactElement Ins(InsAttributes properties, params ReactElementOrText[] children);

        [Name("kbd")]
        public extern static ReactElement Kbd(Attributes properties, params ReactElementOrText[] children);

        [Name("keygen")]
        public extern static ReactElement Keygen(KeygenAttributes properties, params ReactElementOrText[] children);

        [Name("label")]
        public extern static ReactElement Label(LabelAttributes properties, params ReactElementOrText[] children);

        [Name("legend")]
        public extern static ReactElement Legend(Attributes properties, params ReactElementOrText[] children);

        [Name("li")]
        public extern static ReactElement Li(LIAttributes properties, params ReactElementOrText[] children);

        [Name("link")]
        public extern static ReactElement Link(LinkAttributes properties, params ReactElementOrText[] children);

#pragma warning disable 28 // Disable warning CS0028: 'Bridge.React.DOM.Main(Bridge.React.Attributes, params Bridge.React.ReactElementOrText[])' has the wrong signature to be an entry point
		[Name("main")]
		public extern static ReactElement Main(Attributes properties, params ReactElementOrText[] children);
#pragma warning restore 28

		[Name("map")]
        public extern static ReactElement Map(MapAttributes properties, params ReactElementOrText[] children);

        [Name("mark")]
        public extern static ReactElement Mark(Attributes properties, params ReactElementOrText[] children);

        [Name("menu")]
        public extern static ReactElement Menu(Attributes properties, params ReactElementOrText[] children);

        [Name("menuitem")]
        public extern static ReactElement MenuItem(Attributes properties, params ReactElementOrText[] children);

        [Name("meta")]
        public extern static ReactElement Meta(MetaAttributes properties, params ReactElementOrText[] children);

        [Name("meter")]
        public extern static ReactElement Meter(MeterAttributes properties, params ReactElementOrText[] children);

        [Name("nav")]
        public extern static ReactElement Nav(Attributes properties, params ReactElementOrText[] children);

        [Name("noscript")]
        public extern static ReactElement NoScript(Attributes properties, params ReactElementOrText[] children);

        [Name("object")]
        public extern static ReactElement Object(ObjectAttributes properties, params ReactElementOrText[] children);

        [Name("ol")]
        public extern static ReactElement OL(OListAttributes properties, params ReactElementOrText[] children);

        [Name("optgroup")]
        public extern static ReactElement OptGroup(OptGroupAttributes properties, params ReactElementOrText[] children);

        [Name("option")]
        public extern static ReactElement Option(OptionAttributes properties, params ReactElementOrText[] children);

        [Name("output")]
        public extern static ReactElement Output(OutputAttributes properties, params ReactElementOrText[] children);

        [Name("p")]
        public extern static ReactElement P(Attributes properties, params ReactElementOrText[] children);

        [Name("param")]
        public extern static ReactElement Param(ParamAttributes properties, params ReactElementOrText[] children);

        [Name("picture")]
        public extern static ReactElement Picture(Attributes properties, params ReactElementOrText[] children);

        [Name("pre")]
        public extern static ReactElement Pre(Attributes properties, params ReactElementOrText[] children);

        [Name("progress")]
        public extern static ReactElement Progress(ProgressAttributes properties, params ReactElementOrText[] children);

        [Name("q")]
        public extern static ReactElement Q(QuoteAttributes properties, params ReactElementOrText[] children);

        [Name("rp")]
        public extern static ReactElement RP(Attributes properties, params ReactElementOrText[] children);

        [Name("rt")]
        public extern static ReactElement RT(Attributes properties, params ReactElementOrText[] children);

        [Name("ruby")]
        public extern static ReactElement Ruby(Attributes properties, params ReactElementOrText[] children);

        [Name("s")]
        public extern static ReactElement S(Attributes properties, params ReactElementOrText[] children);

        [Name("samp")]
        public extern static ReactElement Samp(Attributes properties, params ReactElementOrText[] children);

        [Name("script")]
        public extern static ReactElement Script(ScriptAttributes properties, params ReactElementOrText[] children);

        [Name("section")]
        public extern static ReactElement Section(Attributes properties, params ReactElementOrText[] children);

        [Name("select")]
        public extern static ReactElement Select(SelectAttributes properties, params ReactElementOrText[] children);

        [Name("small")]
        public extern static ReactElement Small(Attributes properties, params ReactElementOrText[] children);

        [Name("source")]
        public extern static ReactElement Source(SourceAttributes properties, params ReactElementOrText[] children);

        [Name("span")]
        public extern static ReactElement Span(Attributes properties, params ReactElementOrText[] children);

        [Name("strong")]
        public extern static ReactElement Strong(Attributes properties, params ReactElementOrText[] children);

        [Name("style")]
        public extern static ReactElement Style(StyleAttributes properties, params ReactElementOrText[] children);

        [Name("sub")]
        public extern static ReactElement Sub(Attributes properties, params ReactElementOrText[] children);

        [Name("summary")]
        public extern static ReactElement Summary(Attributes properties, params ReactElementOrText[] children);

        [Name("sup")]
        public extern static ReactElement Sup(Attributes properties, params ReactElementOrText[] children);

        [Name("table")]
        public extern static ReactElement Table(Attributes properties, params ReactElementOrText[] children);

        [Name("tbody")]
        public extern static ReactElement TBody(Attributes properties, params ReactElementOrText[] children);

        [Name("td")]
        public extern static ReactElement TD(TableCellAttributes properties, params ReactElementOrText[] children);

        [Name("textarea")]
        public extern static ReactElement TextArea(TextAreaAttributes properties, params ReactElementOrText[] children);

        [Name("tfoot")]
        public extern static ReactElement TFoot(Attributes properties, params ReactElementOrText[] children);

        [Name("th")]
        public extern static ReactElement TH(TableCellAttributes properties, params ReactElementOrText[] children);

        [Name("thead")]
        public extern static ReactElement THead(Attributes properties, params ReactElementOrText[] children);

        [Name("time")]
        public extern static ReactElement Time(Attributes properties, params ReactElementOrText[] children);

        [Name("title")]
        public extern static ReactElement Title(TitleAttributes properties, params ReactElementOrText[] children);

        [Name("tr")]
        public extern static ReactElement TR(TableCellAttributes properties, params ReactElementOrText[] children);

        [Name("track")]
        public extern static ReactElement Track(TrackAttributes properties, params ReactElementOrText[] children);

        [Name("u")]
        public extern static ReactElement U(Attributes properties, params ReactElementOrText[] children);

        [Name("ul")]
        public extern static ReactElement UL(Attributes properties, params ReactElementOrText[] children);

        [Name("Var")]
        public extern static ReactElement Var(Attributes properties, params ReactElementOrText[] children);

        [Name("video")]
        public extern static ReactElement Video(Attributes properties, params ReactElementOrText[] children);

        [Name("wbr")]
        public extern static ReactElement WBR(Attributes properties, params ReactElementOrText[] children);
    }
}
