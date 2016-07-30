using System.Collections.Generic;

namespace Bridge.React
{
	[Name("React.DOM")]
	[External]
	public static class DOM
	{
		[Name("a")]
		public extern static ReactElement A(AnchorAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.a(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement A(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.a(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement A(IEnumerable<string> children);
		
		[Template("React.DOM.a(null, {0})")]
		public extern static ReactElement A(ReactElement child);
		
		[Template("React.DOM.a(null, {0})")]
		public extern static ReactElement A(string child);
		
		[Template("React.DOM.a({0}, {1})")]
		public extern static ReactElement A(AnchorAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.a({0}, {1})")]
		public extern static ReactElement A(AnchorAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.a({0}, {1})")]
		public extern static ReactElement A(AnchorAttributes properties, ReactElement child);
		
		[Template("React.DOM.a({0}, {1})")]
		public extern static ReactElement A(AnchorAttributes properties, string child);

		[Name("abbr")]
		public extern static ReactElement Abbr(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.abbr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Abbr(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.abbr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Abbr(IEnumerable<string> children);
		
		[Template("React.DOM.abbr(null, {0})")]
		public extern static ReactElement Abbr(ReactElement child);
		
		[Template("React.DOM.abbr(null, {0})")]
		public extern static ReactElement Abbr(string child);
		
		[Template("React.DOM.abbr({0}, {1})")]
		public extern static ReactElement Abbr(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.abbr({0}, {1})")]
		public extern static ReactElement Abbr(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.abbr({0}, {1})")]
		public extern static ReactElement Abbr(Attributes properties, ReactElement child);
		
		[Template("React.DOM.abbr({0}, {1})")]
		public extern static ReactElement Abbr(Attributes properties, string child);

		[Name("address")]
		public extern static ReactElement Address(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.address(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Address(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.address(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Address(IEnumerable<string> children);
		
		[Template("React.DOM.address(null, {0})")]
		public extern static ReactElement Address(ReactElement child);
		
		[Template("React.DOM.address(null, {0})")]
		public extern static ReactElement Address(string child);
		
		[Template("React.DOM.address({0}, {1})")]
		public extern static ReactElement Address(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.address({0}, {1})")]
		public extern static ReactElement Address(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.address({0}, {1})")]
		public extern static ReactElement Address(Attributes properties, ReactElement child);
		
		[Template("React.DOM.address({0}, {1})")]
		public extern static ReactElement Address(Attributes properties, string child);

		[Name("area")]
		public extern static ReactElement Area(AreaAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.area(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Area(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.area(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Area(IEnumerable<string> children);
		
		[Template("React.DOM.area(null, {0})")]
		public extern static ReactElement Area(ReactElement child);
		
		[Template("React.DOM.area(null, {0})")]
		public extern static ReactElement Area(string child);
		
		[Template("React.DOM.area({0}, {1})")]
		public extern static ReactElement Area(AreaAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.area({0}, {1})")]
		public extern static ReactElement Area(AreaAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.area({0}, {1})")]
		public extern static ReactElement Area(AreaAttributes properties, ReactElement child);
		
		[Template("React.DOM.area({0}, {1})")]
		public extern static ReactElement Area(AreaAttributes properties, string child);

		[Name("article")]
		public extern static ReactElement Article(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.article(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Article(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.article(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Article(IEnumerable<string> children);
		
		[Template("React.DOM.article(null, {0})")]
		public extern static ReactElement Article(ReactElement child);
		
		[Template("React.DOM.article(null, {0})")]
		public extern static ReactElement Article(string child);
		
		[Template("React.DOM.article({0}, {1})")]
		public extern static ReactElement Article(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.article({0}, {1})")]
		public extern static ReactElement Article(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.article({0}, {1})")]
		public extern static ReactElement Article(Attributes properties, ReactElement child);
		
		[Template("React.DOM.article({0}, {1})")]
		public extern static ReactElement Article(Attributes properties, string child);

		[Name("aside")]
		public extern static ReactElement Aside(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.aside(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Aside(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.aside(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Aside(IEnumerable<string> children);
		
		[Template("React.DOM.aside(null, {0})")]
		public extern static ReactElement Aside(ReactElement child);
		
		[Template("React.DOM.aside(null, {0})")]
		public extern static ReactElement Aside(string child);
		
		[Template("React.DOM.aside({0}, {1})")]
		public extern static ReactElement Aside(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.aside({0}, {1})")]
		public extern static ReactElement Aside(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.aside({0}, {1})")]
		public extern static ReactElement Aside(Attributes properties, ReactElement child);
		
		[Template("React.DOM.aside({0}, {1})")]
		public extern static ReactElement Aside(Attributes properties, string child);

		[Name("audio")]
		public extern static ReactElement Audio(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.audio(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Audio(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.audio(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Audio(IEnumerable<string> children);
		
		[Template("React.DOM.audio(null, {0})")]
		public extern static ReactElement Audio(ReactElement child);
		
		[Template("React.DOM.audio(null, {0})")]
		public extern static ReactElement Audio(string child);
		
		[Template("React.DOM.audio({0}, {1})")]
		public extern static ReactElement Audio(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.audio({0}, {1})")]
		public extern static ReactElement Audio(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.audio({0}, {1})")]
		public extern static ReactElement Audio(Attributes properties, ReactElement child);
		
		[Template("React.DOM.audio({0}, {1})")]
		public extern static ReactElement Audio(Attributes properties, string child);

		[Name("b")]
		public extern static ReactElement B(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.b(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement B(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.b(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement B(IEnumerable<string> children);
		
		[Template("React.DOM.b(null, {0})")]
		public extern static ReactElement B(ReactElement child);
		
		[Template("React.DOM.b(null, {0})")]
		public extern static ReactElement B(string child);
		
		[Template("React.DOM.b({0}, {1})")]
		public extern static ReactElement B(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.b({0}, {1})")]
		public extern static ReactElement B(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.b({0}, {1})")]
		public extern static ReactElement B(Attributes properties, ReactElement child);
		
		[Template("React.DOM.b({0}, {1})")]
		public extern static ReactElement B(Attributes properties, string child);

		[Name("base")]
		public extern static ReactElement Base(BaseAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.base(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Base(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.base(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Base(IEnumerable<string> children);
		
		[Template("React.DOM.base(null, {0})")]
		public extern static ReactElement Base(ReactElement child);
		
		[Template("React.DOM.base(null, {0})")]
		public extern static ReactElement Base(string child);
		
		[Template("React.DOM.base({0}, {1})")]
		public extern static ReactElement Base(BaseAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.base({0}, {1})")]
		public extern static ReactElement Base(BaseAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.base({0}, {1})")]
		public extern static ReactElement Base(BaseAttributes properties, ReactElement child);
		
		[Template("React.DOM.base({0}, {1})")]
		public extern static ReactElement Base(BaseAttributes properties, string child);

		[Name("bdi")]
		public extern static ReactElement BDI(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.bdi(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDI(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.bdi(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDI(IEnumerable<string> children);
		
		[Template("React.DOM.bdi(null, {0})")]
		public extern static ReactElement BDI(ReactElement child);
		
		[Template("React.DOM.bdi(null, {0})")]
		public extern static ReactElement BDI(string child);
		
		[Template("React.DOM.bdi({0}, {1})")]
		public extern static ReactElement BDI(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.bdi({0}, {1})")]
		public extern static ReactElement BDI(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.bdi({0}, {1})")]
		public extern static ReactElement BDI(Attributes properties, ReactElement child);
		
		[Template("React.DOM.bdi({0}, {1})")]
		public extern static ReactElement BDI(Attributes properties, string child);

		[Name("bdo")]
		public extern static ReactElement BDO(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.bdo(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDO(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.bdo(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDO(IEnumerable<string> children);
		
		[Template("React.DOM.bdo(null, {0})")]
		public extern static ReactElement BDO(ReactElement child);
		
		[Template("React.DOM.bdo(null, {0})")]
		public extern static ReactElement BDO(string child);
		
		[Template("React.DOM.bdo({0}, {1})")]
		public extern static ReactElement BDO(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.bdo({0}, {1})")]
		public extern static ReactElement BDO(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.bdo({0}, {1})")]
		public extern static ReactElement BDO(Attributes properties, ReactElement child);
		
		[Template("React.DOM.bdo({0}, {1})")]
		public extern static ReactElement BDO(Attributes properties, string child);

		[Name("big")]
		public extern static ReactElement Big(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.big(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Big(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.big(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Big(IEnumerable<string> children);
		
		[Template("React.DOM.big(null, {0})")]
		public extern static ReactElement Big(ReactElement child);
		
		[Template("React.DOM.big(null, {0})")]
		public extern static ReactElement Big(string child);
		
		[Template("React.DOM.big({0}, {1})")]
		public extern static ReactElement Big(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.big({0}, {1})")]
		public extern static ReactElement Big(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.big({0}, {1})")]
		public extern static ReactElement Big(Attributes properties, ReactElement child);
		
		[Template("React.DOM.big({0}, {1})")]
		public extern static ReactElement Big(Attributes properties, string child);

		[Name("blockquote")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.blockquote(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BlockQuote(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.blockquote(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BlockQuote(IEnumerable<string> children);
		
		[Template("React.DOM.blockquote(null, {0})")]
		public extern static ReactElement BlockQuote(ReactElement child);
		
		[Template("React.DOM.blockquote(null, {0})")]
		public extern static ReactElement BlockQuote(string child);
		
		[Template("React.DOM.blockquote({0}, {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.blockquote({0}, {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.blockquote({0}, {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, ReactElement child);
		
		[Template("React.DOM.blockquote({0}, {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, string child);

		[Name("body")]
		public extern static ReactElement Body(BodyAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.body(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Body(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.body(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Body(IEnumerable<string> children);
		
		[Template("React.DOM.body(null, {0})")]
		public extern static ReactElement Body(ReactElement child);
		
		[Template("React.DOM.body(null, {0})")]
		public extern static ReactElement Body(string child);
		
		[Template("React.DOM.body({0}, {1})")]
		public extern static ReactElement Body(BodyAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.body({0}, {1})")]
		public extern static ReactElement Body(BodyAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.body({0}, {1})")]
		public extern static ReactElement Body(BodyAttributes properties, ReactElement child);
		
		[Template("React.DOM.body({0}, {1})")]
		public extern static ReactElement Body(BodyAttributes properties, string child);

		[Name("br")]
		public extern static ReactElement Br(BrAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.br(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Br(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.br(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Br(IEnumerable<string> children);
		
		[Template("React.DOM.br(null, {0})")]
		public extern static ReactElement Br(ReactElement child);
		
		[Template("React.DOM.br(null, {0})")]
		public extern static ReactElement Br(string child);
		
		[Template("React.DOM.br({0}, {1})")]
		public extern static ReactElement Br(BrAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.br({0}, {1})")]
		public extern static ReactElement Br(BrAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.br({0}, {1})")]
		public extern static ReactElement Br(BrAttributes properties, ReactElement child);
		
		[Template("React.DOM.br({0}, {1})")]
		public extern static ReactElement Br(BrAttributes properties, string child);

		[Name("button")]
		public extern static ReactElement Button(ButtonAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.button(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Button(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.button(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Button(IEnumerable<string> children);
		
		[Template("React.DOM.button(null, {0})")]
		public extern static ReactElement Button(ReactElement child);
		
		[Template("React.DOM.button(null, {0})")]
		public extern static ReactElement Button(string child);
		
		[Template("React.DOM.button({0}, {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.button({0}, {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.button({0}, {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, ReactElement child);
		
		[Template("React.DOM.button({0}, {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, string child);

		[Name("canvas")]
		public extern static ReactElement Canvas(CanvasAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.canvas(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Canvas(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.canvas(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Canvas(IEnumerable<string> children);
		
		[Template("React.DOM.canvas(null, {0})")]
		public extern static ReactElement Canvas(ReactElement child);
		
		[Template("React.DOM.canvas(null, {0})")]
		public extern static ReactElement Canvas(string child);
		
		[Template("React.DOM.canvas({0}, {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.canvas({0}, {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.canvas({0}, {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, ReactElement child);
		
		[Template("React.DOM.canvas({0}, {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, string child);

		[Name("caption")]
		public extern static ReactElement Caption(Attributes  properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.caption(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Caption(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.caption(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Caption(IEnumerable<string> children);
		
		[Template("React.DOM.caption(null, {0})")]
		public extern static ReactElement Caption(ReactElement child);
		
		[Template("React.DOM.caption(null, {0})")]
		public extern static ReactElement Caption(string child);
		
		[Template("React.DOM.caption({0}, {1})")]
		public extern static ReactElement Caption(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.caption({0}, {1})")]
		public extern static ReactElement Caption(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.caption({0}, {1})")]
		public extern static ReactElement Caption(Attributes properties, ReactElement child);
		
		[Template("React.DOM.caption({0}, {1})")]
		public extern static ReactElement Caption(Attributes properties, string child);

		[Name("cite")]
		public extern static ReactElement Cite(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.cite(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Cite(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.cite(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Cite(IEnumerable<string> children);
		
		[Template("React.DOM.cite(null, {0})")]
		public extern static ReactElement Cite(ReactElement child);
		
		[Template("React.DOM.cite(null, {0})")]
		public extern static ReactElement Cite(string child);
		
		[Template("React.DOM.cite({0}, {1})")]
		public extern static ReactElement Cite(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.cite({0}, {1})")]
		public extern static ReactElement Cite(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.cite({0}, {1})")]
		public extern static ReactElement Cite(Attributes properties, ReactElement child);
		
		[Template("React.DOM.cite({0}, {1})")]
		public extern static ReactElement Cite(Attributes properties, string child);

		[Name("code")]
		public extern static ReactElement Code(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.code(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Code(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.code(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Code(IEnumerable<string> children);
		
		[Template("React.DOM.code(null, {0})")]
		public extern static ReactElement Code(ReactElement child);
		
		[Template("React.DOM.code(null, {0})")]
		public extern static ReactElement Code(string child);
		
		[Template("React.DOM.code({0}, {1})")]
		public extern static ReactElement Code(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.code({0}, {1})")]
		public extern static ReactElement Code(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.code({0}, {1})")]
		public extern static ReactElement Code(Attributes properties, ReactElement child);
		
		[Template("React.DOM.code({0}, {1})")]
		public extern static ReactElement Code(Attributes properties, string child);

		[Name("col")]
		public extern static ReactElement Col(TableColAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.col(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Col(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.col(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Col(IEnumerable<string> children);
		
		[Template("React.DOM.col(null, {0})")]
		public extern static ReactElement Col(ReactElement child);
		
		[Template("React.DOM.col(null, {0})")]
		public extern static ReactElement Col(string child);
		
		[Template("React.DOM.col({0}, {1})")]
		public extern static ReactElement Col(TableColAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.col({0}, {1})")]
		public extern static ReactElement Col(TableColAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.col({0}, {1})")]
		public extern static ReactElement Col(TableColAttributes properties, ReactElement child);
		
		[Template("React.DOM.col({0}, {1})")]
		public extern static ReactElement Col(TableColAttributes properties, string child);

		[Name("colgroup")]
		public extern static ReactElement ColGroup(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.colgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement ColGroup(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.colgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement ColGroup(IEnumerable<string> children);
		
		[Template("React.DOM.colgroup(null, {0})")]
		public extern static ReactElement ColGroup(ReactElement child);
		
		[Template("React.DOM.colgroup(null, {0})")]
		public extern static ReactElement ColGroup(string child);
		
		[Template("React.DOM.colgroup({0}, {1})")]
		public extern static ReactElement ColGroup(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.colgroup({0}, {1})")]
		public extern static ReactElement ColGroup(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.colgroup({0}, {1})")]
		public extern static ReactElement ColGroup(Attributes properties, ReactElement child);
		
		[Template("React.DOM.colgroup({0}, {1})")]
		public extern static ReactElement ColGroup(Attributes properties, string child);

		[Name("data")]
		public extern static ReactElement Data(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.data(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Data(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.data(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Data(IEnumerable<string> children);
		
		[Template("React.DOM.data(null, {0})")]
		public extern static ReactElement Data(ReactElement child);
		
		[Template("React.DOM.data(null, {0})")]
		public extern static ReactElement Data(string child);
		
		[Template("React.DOM.data({0}, {1})")]
		public extern static ReactElement Data(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.data({0}, {1})")]
		public extern static ReactElement Data(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.data({0}, {1})")]
		public extern static ReactElement Data(Attributes properties, ReactElement child);
		
		[Template("React.DOM.data({0}, {1})")]
		public extern static ReactElement Data(Attributes properties, string child);

		[Name("datalist")]
		public extern static ReactElement DataList(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.datalist(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DataList(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.datalist(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DataList(IEnumerable<string> children);
		
		[Template("React.DOM.datalist(null, {0})")]
		public extern static ReactElement DataList(ReactElement child);
		
		[Template("React.DOM.datalist(null, {0})")]
		public extern static ReactElement DataList(string child);
		
		[Template("React.DOM.datalist({0}, {1})")]
		public extern static ReactElement DataList(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.datalist({0}, {1})")]
		public extern static ReactElement DataList(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.datalist({0}, {1})")]
		public extern static ReactElement DataList(Attributes properties, ReactElement child);
		
		[Template("React.DOM.datalist({0}, {1})")]
		public extern static ReactElement DataList(Attributes properties, string child);

		[Name("dd")]
		public extern static ReactElement DD(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.dd(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DD(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dd(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DD(IEnumerable<string> children);
		
		[Template("React.DOM.dd(null, {0})")]
		public extern static ReactElement DD(ReactElement child);
		
		[Template("React.DOM.dd(null, {0})")]
		public extern static ReactElement DD(string child);
		
		[Template("React.DOM.dd({0}, {1})")]
		public extern static ReactElement DD(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dd({0}, {1})")]
		public extern static ReactElement DD(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.dd({0}, {1})")]
		public extern static ReactElement DD(Attributes properties, ReactElement child);
		
		[Template("React.DOM.dd({0}, {1})")]
		public extern static ReactElement DD(Attributes properties, string child);

		[Name("del")]
		public extern static ReactElement Del(DelAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.del(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Del(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.del(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Del(IEnumerable<string> children);
		
		[Template("React.DOM.del(null, {0})")]
		public extern static ReactElement Del(ReactElement child);
		
		[Template("React.DOM.del(null, {0})")]
		public extern static ReactElement Del(string child);
		
		[Template("React.DOM.del({0}, {1})")]
		public extern static ReactElement Del(DelAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.del({0}, {1})")]
		public extern static ReactElement Del(DelAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.del({0}, {1})")]
		public extern static ReactElement Del(DelAttributes properties, ReactElement child);
		
		[Template("React.DOM.del({0}, {1})")]
		public extern static ReactElement Del(DelAttributes properties, string child);

		[Name("details")]
		public extern static ReactElement Details(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.details(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Details(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.details(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Details(IEnumerable<string> children);
		
		[Template("React.DOM.details(null, {0})")]
		public extern static ReactElement Details(ReactElement child);
		
		[Template("React.DOM.details(null, {0})")]
		public extern static ReactElement Details(string child);
		
		[Template("React.DOM.details({0}, {1})")]
		public extern static ReactElement Details(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.details({0}, {1})")]
		public extern static ReactElement Details(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.details({0}, {1})")]
		public extern static ReactElement Details(Attributes properties, ReactElement child);
		
		[Template("React.DOM.details({0}, {1})")]
		public extern static ReactElement Details(Attributes properties, string child);

		[Name("dfn")]
		public extern static ReactElement Dfn(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.dfn(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dfn(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dfn(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dfn(IEnumerable<string> children);
		
		[Template("React.DOM.dfn(null, {0})")]
		public extern static ReactElement Dfn(ReactElement child);
		
		[Template("React.DOM.dfn(null, {0})")]
		public extern static ReactElement Dfn(string child);
		
		[Template("React.DOM.dfn({0}, {1})")]
		public extern static ReactElement Dfn(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dfn({0}, {1})")]
		public extern static ReactElement Dfn(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.dfn({0}, {1})")]
		public extern static ReactElement Dfn(Attributes properties, ReactElement child);
		
		[Template("React.DOM.dfn({0}, {1})")]
		public extern static ReactElement Dfn(Attributes properties, string child);

		[Name("dialog")]
		public extern static ReactElement Dialog(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.dialog(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dialog(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dialog(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dialog(IEnumerable<string> children);
		
		[Template("React.DOM.dialog(null, {0})")]
		public extern static ReactElement Dialog(ReactElement child);
		
		[Template("React.DOM.dialog(null, {0})")]
		public extern static ReactElement Dialog(string child);
		
		[Template("React.DOM.dialog({0}, {1})")]
		public extern static ReactElement Dialog(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dialog({0}, {1})")]
		public extern static ReactElement Dialog(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.dialog({0}, {1})")]
		public extern static ReactElement Dialog(Attributes properties, ReactElement child);
		
		[Template("React.DOM.dialog({0}, {1})")]
		public extern static ReactElement Dialog(Attributes properties, string child);

		[Name("div")]
		public extern static ReactElement Div(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.div(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Div(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.div(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Div(IEnumerable<string> children);
		
		[Template("React.DOM.div(null, {0})")]
		public extern static ReactElement Div(ReactElement child);
		
		[Template("React.DOM.div(null, {0})")]
		public extern static ReactElement Div(string child);
		
		[Template("React.DOM.div({0}, {1})")]
		public extern static ReactElement Div(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.div({0}, {1})")]
		public extern static ReactElement Div(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.div({0}, {1})")]
		public extern static ReactElement Div(Attributes properties, ReactElement child);
		
		[Template("React.DOM.div({0}, {1})")]
		public extern static ReactElement Div(Attributes properties, string child);

		[Name("dl")]
		public extern static ReactElement DL(DListAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.dl(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DL(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dl(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DL(IEnumerable<string> children);
		
		[Template("React.DOM.dl(null, {0})")]
		public extern static ReactElement DL(ReactElement child);
		
		[Template("React.DOM.dl(null, {0})")]
		public extern static ReactElement DL(string child);
		
		[Template("React.DOM.dl({0}, {1})")]
		public extern static ReactElement DL(DListAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dl({0}, {1})")]
		public extern static ReactElement DL(DListAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.dl({0}, {1})")]
		public extern static ReactElement DL(DListAttributes properties, ReactElement child);
		
		[Template("React.DOM.dl({0}, {1})")]
		public extern static ReactElement DL(DListAttributes properties, string child);

		[Name("dt")]
		public extern static ReactElement DT(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.dt(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DT(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dt(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DT(IEnumerable<string> children);
		
		[Template("React.DOM.dt(null, {0})")]
		public extern static ReactElement DT(ReactElement child);
		
		[Template("React.DOM.dt(null, {0})")]
		public extern static ReactElement DT(string child);
		
		[Template("React.DOM.dt({0}, {1})")]
		public extern static ReactElement DT(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.dt({0}, {1})")]
		public extern static ReactElement DT(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.dt({0}, {1})")]
		public extern static ReactElement DT(Attributes properties, ReactElement child);
		
		[Template("React.DOM.dt({0}, {1})")]
		public extern static ReactElement DT(Attributes properties, string child);

		[Name("em")]
		public extern static ReactElement Em(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.em(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Em(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.em(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Em(IEnumerable<string> children);
		
		[Template("React.DOM.em(null, {0})")]
		public extern static ReactElement Em(ReactElement child);
		
		[Template("React.DOM.em(null, {0})")]
		public extern static ReactElement Em(string child);
		
		[Template("React.DOM.em({0}, {1})")]
		public extern static ReactElement Em(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.em({0}, {1})")]
		public extern static ReactElement Em(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.em({0}, {1})")]
		public extern static ReactElement Em(Attributes properties, ReactElement child);
		
		[Template("React.DOM.em({0}, {1})")]
		public extern static ReactElement Em(Attributes properties, string child);

		[Name("embed")]
		public extern static ReactElement Embed(EmbedAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.embed(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Embed(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.embed(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Embed(IEnumerable<string> children);
		
		[Template("React.DOM.embed(null, {0})")]
		public extern static ReactElement Embed(ReactElement child);
		
		[Template("React.DOM.embed(null, {0})")]
		public extern static ReactElement Embed(string child);
		
		[Template("React.DOM.embed({0}, {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.embed({0}, {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.embed({0}, {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, ReactElement child);
		
		[Template("React.DOM.embed({0}, {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, string child);

		[Name("fieldset")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.fieldset(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FieldSet(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.fieldset(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FieldSet(IEnumerable<string> children);
		
		[Template("React.DOM.fieldset(null, {0})")]
		public extern static ReactElement FieldSet(ReactElement child);
		
		[Template("React.DOM.fieldset(null, {0})")]
		public extern static ReactElement FieldSet(string child);
		
		[Template("React.DOM.fieldset({0}, {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.fieldset({0}, {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.fieldset({0}, {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, ReactElement child);
		
		[Template("React.DOM.fieldset({0}, {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, string child);

		[Name("figcaption")]
		public extern static ReactElement FigCaption(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.figcaption(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FigCaption(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.figcaption(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FigCaption(IEnumerable<string> children);
		
		[Template("React.DOM.figcaption(null, {0})")]
		public extern static ReactElement FigCaption(ReactElement child);
		
		[Template("React.DOM.figcaption(null, {0})")]
		public extern static ReactElement FigCaption(string child);
		
		[Template("React.DOM.figcaption({0}, {1})")]
		public extern static ReactElement FigCaption(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.figcaption({0}, {1})")]
		public extern static ReactElement FigCaption(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.figcaption({0}, {1})")]
		public extern static ReactElement FigCaption(Attributes properties, ReactElement child);
		
		[Template("React.DOM.figcaption({0}, {1})")]
		public extern static ReactElement FigCaption(Attributes properties, string child);

		[Name("figure")]
		public extern static ReactElement Figure(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.figure(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Figure(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.figure(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Figure(IEnumerable<string> children);
		
		[Template("React.DOM.figure(null, {0})")]
		public extern static ReactElement Figure(ReactElement child);
		
		[Template("React.DOM.figure(null, {0})")]
		public extern static ReactElement Figure(string child);
		
		[Template("React.DOM.figure({0}, {1})")]
		public extern static ReactElement Figure(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.figure({0}, {1})")]
		public extern static ReactElement Figure(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.figure({0}, {1})")]
		public extern static ReactElement Figure(Attributes properties, ReactElement child);
		
		[Template("React.DOM.figure({0}, {1})")]
		public extern static ReactElement Figure(Attributes properties, string child);

		[Name("footer")]
		public extern static ReactElement Footer(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.footer(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Footer(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.footer(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Footer(IEnumerable<string> children);
		
		[Template("React.DOM.footer(null, {0})")]
		public extern static ReactElement Footer(ReactElement child);
		
		[Template("React.DOM.footer(null, {0})")]
		public extern static ReactElement Footer(string child);
		
		[Template("React.DOM.footer({0}, {1})")]
		public extern static ReactElement Footer(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.footer({0}, {1})")]
		public extern static ReactElement Footer(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.footer({0}, {1})")]
		public extern static ReactElement Footer(Attributes properties, ReactElement child);
		
		[Template("React.DOM.footer({0}, {1})")]
		public extern static ReactElement Footer(Attributes properties, string child);

		[Name("form")]
		public extern static ReactElement Form(FormAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.form(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Form(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.form(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Form(IEnumerable<string> children);
		
		[Template("React.DOM.form(null, {0})")]
		public extern static ReactElement Form(ReactElement child);
		
		[Template("React.DOM.form(null, {0})")]
		public extern static ReactElement Form(string child);
		
		[Template("React.DOM.form({0}, {1})")]
		public extern static ReactElement Form(FormAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.form({0}, {1})")]
		public extern static ReactElement Form(FormAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.form({0}, {1})")]
		public extern static ReactElement Form(FormAttributes properties, ReactElement child);
		
		[Template("React.DOM.form({0}, {1})")]
		public extern static ReactElement Form(FormAttributes properties, string child);

		[Name("h1")]
		public extern static ReactElement H1(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h1(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H1(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h1(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H1(IEnumerable<string> children);
		
		[Template("React.DOM.h1(null, {0})")]
		public extern static ReactElement H1(ReactElement child);
		
		[Template("React.DOM.h1(null, {0})")]
		public extern static ReactElement H1(string child);
		
		[Template("React.DOM.h1({0}, {1})")]
		public extern static ReactElement H1(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h1({0}, {1})")]
		public extern static ReactElement H1(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h1({0}, {1})")]
		public extern static ReactElement H1(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h1({0}, {1})")]
		public extern static ReactElement H1(Attributes properties, string child);

		[Name("h2")]
		public extern static ReactElement H2(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h2(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H2(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h2(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H2(IEnumerable<string> children);
		
		[Template("React.DOM.h2(null, {0})")]
		public extern static ReactElement H2(ReactElement child);
		
		[Template("React.DOM.h2(null, {0})")]
		public extern static ReactElement H2(string child);
		
		[Template("React.DOM.h2({0}, {1})")]
		public extern static ReactElement H2(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h2({0}, {1})")]
		public extern static ReactElement H2(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h2({0}, {1})")]
		public extern static ReactElement H2(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h2({0}, {1})")]
		public extern static ReactElement H2(Attributes properties, string child);

		[Name("h3")]
		public extern static ReactElement H3(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h3(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H3(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h3(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H3(IEnumerable<string> children);
		
		[Template("React.DOM.h3(null, {0})")]
		public extern static ReactElement H3(ReactElement child);
		
		[Template("React.DOM.h3(null, {0})")]
		public extern static ReactElement H3(string child);
		
		[Template("React.DOM.h3({0}, {1})")]
		public extern static ReactElement H3(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h3({0}, {1})")]
		public extern static ReactElement H3(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h3({0}, {1})")]
		public extern static ReactElement H3(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h3({0}, {1})")]
		public extern static ReactElement H3(Attributes properties, string child);

		[Name("h4")]
		public extern static ReactElement H4(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h4(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H4(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h4(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H4(IEnumerable<string> children);
		
		[Template("React.DOM.h4(null, {0})")]
		public extern static ReactElement H4(ReactElement child);
		
		[Template("React.DOM.h4(null, {0})")]
		public extern static ReactElement H4(string child);
		
		[Template("React.DOM.h4({0}, {1})")]
		public extern static ReactElement H4(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h4({0}, {1})")]
		public extern static ReactElement H4(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h4({0}, {1})")]
		public extern static ReactElement H4(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h4({0}, {1})")]
		public extern static ReactElement H4(Attributes properties, string child);

		[Name("h5")]
		public extern static ReactElement H5(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h5(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H5(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h5(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H5(IEnumerable<string> children);
		
		[Template("React.DOM.h5(null, {0})")]
		public extern static ReactElement H5(ReactElement child);
		
		[Template("React.DOM.h5(null, {0})")]
		public extern static ReactElement H5(string child);
		
		[Template("React.DOM.h5({0}, {1})")]
		public extern static ReactElement H5(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h5({0}, {1})")]
		public extern static ReactElement H5(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h5({0}, {1})")]
		public extern static ReactElement H5(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h5({0}, {1})")]
		public extern static ReactElement H5(Attributes properties, string child);

		[Name("h6")]
		public extern static ReactElement H6(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.h6(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H6(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h6(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H6(IEnumerable<string> children);
		
		[Template("React.DOM.h6(null, {0})")]
		public extern static ReactElement H6(ReactElement child);
		
		[Template("React.DOM.h6(null, {0})")]
		public extern static ReactElement H6(string child);
		
		[Template("React.DOM.h6({0}, {1})")]
		public extern static ReactElement H6(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.h6({0}, {1})")]
		public extern static ReactElement H6(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.h6({0}, {1})")]
		public extern static ReactElement H6(Attributes properties, ReactElement child);
		
		[Template("React.DOM.h6({0}, {1})")]
		public extern static ReactElement H6(Attributes properties, string child);

		[Name("head")]
		public extern static ReactElement Head(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.head(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Head(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.head(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Head(IEnumerable<string> children);
		
		[Template("React.DOM.head(null, {0})")]
		public extern static ReactElement Head(ReactElement child);
		
		[Template("React.DOM.head(null, {0})")]
		public extern static ReactElement Head(string child);
		
		[Template("React.DOM.head({0}, {1})")]
		public extern static ReactElement Head(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.head({0}, {1})")]
		public extern static ReactElement Head(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.head({0}, {1})")]
		public extern static ReactElement Head(Attributes properties, ReactElement child);
		
		[Template("React.DOM.head({0}, {1})")]
		public extern static ReactElement Head(Attributes properties, string child);

		[Name("header")]
		public extern static ReactElement Header(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.header(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Header(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.header(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Header(IEnumerable<string> children);
		
		[Template("React.DOM.header(null, {0})")]
		public extern static ReactElement Header(ReactElement child);
		
		[Template("React.DOM.header(null, {0})")]
		public extern static ReactElement Header(string child);
		
		[Template("React.DOM.header({0}, {1})")]
		public extern static ReactElement Header(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.header({0}, {1})")]
		public extern static ReactElement Header(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.header({0}, {1})")]
		public extern static ReactElement Header(Attributes properties, ReactElement child);
		
		[Template("React.DOM.header({0}, {1})")]
		public extern static ReactElement Header(Attributes properties, string child);

		[Name("hgroup")]
		public extern static ReactElement HGroup(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.hgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement HGroup(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.hgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement HGroup(IEnumerable<string> children);
		
		[Template("React.DOM.hgroup(null, {0})")]
		public extern static ReactElement HGroup(ReactElement child);
		
		[Template("React.DOM.hgroup(null, {0})")]
		public extern static ReactElement HGroup(string child);
		
		[Template("React.DOM.hgroup({0}, {1})")]
		public extern static ReactElement HGroup(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.hgroup({0}, {1})")]
		public extern static ReactElement HGroup(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.hgroup({0}, {1})")]
		public extern static ReactElement HGroup(Attributes properties, ReactElement child);
		
		[Template("React.DOM.hgroup({0}, {1})")]
		public extern static ReactElement HGroup(Attributes properties, string child);

		[Name("hr")]
		public extern static ReactElement Hr(HRAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.hr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Hr(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.hr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Hr(IEnumerable<string> children);
		
		[Template("React.DOM.hr(null, {0})")]
		public extern static ReactElement Hr(ReactElement child);
		
		[Template("React.DOM.hr(null, {0})")]
		public extern static ReactElement Hr(string child);
		
		[Template("React.DOM.hr({0}, {1})")]
		public extern static ReactElement Hr(HRAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.hr({0}, {1})")]
		public extern static ReactElement Hr(HRAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.hr({0}, {1})")]
		public extern static ReactElement Hr(HRAttributes properties, ReactElement child);
		
		[Template("React.DOM.hr({0}, {1})")]
		public extern static ReactElement Hr(HRAttributes properties, string child);

		[Name("html")]
		public extern static ReactElement Html(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.html(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Html(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.html(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Html(IEnumerable<string> children);
		
		[Template("React.DOM.html(null, {0})")]
		public extern static ReactElement Html(ReactElement child);
		
		[Template("React.DOM.html(null, {0})")]
		public extern static ReactElement Html(string child);
		
		[Template("React.DOM.html({0}, {1})")]
		public extern static ReactElement Html(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.html({0}, {1})")]
		public extern static ReactElement Html(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.html({0}, {1})")]
		public extern static ReactElement Html(Attributes properties, ReactElement child);
		
		[Template("React.DOM.html({0}, {1})")]
		public extern static ReactElement Html(Attributes properties, string child);

		[Name("i")]
		public extern static ReactElement I(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.i(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement I(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.i(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement I(IEnumerable<string> children);
		
		[Template("React.DOM.i(null, {0})")]
		public extern static ReactElement I(ReactElement child);
		
		[Template("React.DOM.i(null, {0})")]
		public extern static ReactElement I(string child);
		
		[Template("React.DOM.i({0}, {1})")]
		public extern static ReactElement I(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.i({0}, {1})")]
		public extern static ReactElement I(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.i({0}, {1})")]
		public extern static ReactElement I(Attributes properties, ReactElement child);
		
		[Template("React.DOM.i({0}, {1})")]
		public extern static ReactElement I(Attributes properties, string child);

		[Name("iframe")]
		public extern static ReactElement IFrame(IFrameAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.iframe(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement IFrame(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.iframe(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement IFrame(IEnumerable<string> children);
		
		[Template("React.DOM.iframe(null, {0})")]
		public extern static ReactElement IFrame(ReactElement child);
		
		[Template("React.DOM.iframe(null, {0})")]
		public extern static ReactElement IFrame(string child);
		
		[Template("React.DOM.iframe({0}, {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.iframe({0}, {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.iframe({0}, {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, ReactElement child);
		
		[Template("React.DOM.iframe({0}, {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, string child);

		[Name("img")]
		public extern static ReactElement Img(ImageAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.img(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Img(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.img(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Img(IEnumerable<string> children);
		
		[Template("React.DOM.img(null, {0})")]
		public extern static ReactElement Img(ReactElement child);
		
		[Template("React.DOM.img(null, {0})")]
		public extern static ReactElement Img(string child);
		
		[Template("React.DOM.img({0}, {1})")]
		public extern static ReactElement Img(ImageAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.img({0}, {1})")]
		public extern static ReactElement Img(ImageAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.img({0}, {1})")]
		public extern static ReactElement Img(ImageAttributes properties, ReactElement child);
		
		[Template("React.DOM.img({0}, {1})")]
		public extern static ReactElement Img(ImageAttributes properties, string child);

		[Name("input")]
		public extern static ReactElement Input(InputAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.input(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Input(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.input(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Input(IEnumerable<string> children);
		
		[Template("React.DOM.input(null, {0})")]
		public extern static ReactElement Input(ReactElement child);
		
		[Template("React.DOM.input(null, {0})")]
		public extern static ReactElement Input(string child);
		
		[Template("React.DOM.input({0}, {1})")]
		public extern static ReactElement Input(InputAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.input({0}, {1})")]
		public extern static ReactElement Input(InputAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.input({0}, {1})")]
		public extern static ReactElement Input(InputAttributes properties, ReactElement child);
		
		[Template("React.DOM.input({0}, {1})")]
		public extern static ReactElement Input(InputAttributes properties, string child);
		
		[Name("ins")]
		public extern static ReactElement Ins(InsAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.ins(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ins(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ins(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ins(IEnumerable<string> children);
		
		[Template("React.DOM.ins(null, {0})")]
		public extern static ReactElement Ins(ReactElement child);
		
		[Template("React.DOM.ins(null, {0})")]
		public extern static ReactElement Ins(string child);
		
		[Template("React.DOM.ins({0}, {1})")]
		public extern static ReactElement Ins(InsAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ins({0}, {1})")]
		public extern static ReactElement Ins(InsAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.ins({0}, {1})")]
		public extern static ReactElement Ins(InsAttributes properties, ReactElement child);
		
		[Template("React.DOM.ins({0}, {1})")]
		public extern static ReactElement Ins(InsAttributes properties, string child);

		[Name("kbd")]
		public extern static ReactElement Kbd(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.kbd(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Kbd(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.kbd(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Kbd(IEnumerable<string> children);
		
		[Template("React.DOM.kbd(null, {0})")]
		public extern static ReactElement Kbd(ReactElement child);
		
		[Template("React.DOM.kbd(null, {0})")]
		public extern static ReactElement Kbd(string child);
		
		[Template("React.DOM.kbd({0}, {1})")]
		public extern static ReactElement Kbd(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.kbd({0}, {1})")]
		public extern static ReactElement Kbd(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.kbd({0}, {1})")]
		public extern static ReactElement Kbd(Attributes properties, ReactElement child);
		
		[Template("React.DOM.kbd({0}, {1})")]
		public extern static ReactElement Kbd(Attributes properties, string child);

		[Name("keygen")]
		public extern static ReactElement Keygen(KeygenAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.keygen(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Keygen(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.keygen(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Keygen(IEnumerable<string> children);
		
		[Template("React.DOM.keygen(null, {0})")]
		public extern static ReactElement Keygen(ReactElement child);
		
		[Template("React.DOM.keygen(null, {0})")]
		public extern static ReactElement Keygen(string child);
		
		[Template("React.DOM.keygen({0}, {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.keygen({0}, {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.keygen({0}, {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, ReactElement child);
		
		[Template("React.DOM.keygen({0}, {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, string child);

		[Name("label")]
		public extern static ReactElement Label(LabelAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.label(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Label(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.label(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Label(IEnumerable<string> children);
		
		[Template("React.DOM.label(null, {0})")]
		public extern static ReactElement Label(ReactElement child);
		
		[Template("React.DOM.label(null, {0})")]
		public extern static ReactElement Label(string child);
		
		[Template("React.DOM.label({0}, {1})")]
		public extern static ReactElement Label(LabelAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.label({0}, {1})")]
		public extern static ReactElement Label(LabelAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.label({0}, {1})")]
		public extern static ReactElement Label(LabelAttributes properties, ReactElement child);
		
		[Template("React.DOM.label({0}, {1})")]
		public extern static ReactElement Label(LabelAttributes properties, string child);

		[Name("legend")]
		public extern static ReactElement Legend(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.legend(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Legend(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.legend(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Legend(IEnumerable<string> children);
		
		[Template("React.DOM.legend(null, {0})")]
		public extern static ReactElement Legend(ReactElement child);
		
		[Template("React.DOM.legend(null, {0})")]
		public extern static ReactElement Legend(string child);
		
		[Template("React.DOM.legend({0}, {1})")]
		public extern static ReactElement Legend(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.legend({0}, {1})")]
		public extern static ReactElement Legend(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.legend({0}, {1})")]
		public extern static ReactElement Legend(Attributes properties, ReactElement child);
		
		[Template("React.DOM.legend({0}, {1})")]
		public extern static ReactElement Legend(Attributes properties, string child);

		[Name("li")]
		public extern static ReactElement Li(LIAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.li(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Li(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.li(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Li(IEnumerable<string> children);
		
		[Template("React.DOM.li(null, {0})")]
		public extern static ReactElement Li(ReactElement child);
		
		[Template("React.DOM.li(null, {0})")]
		public extern static ReactElement Li(string child);
		
		[Template("React.DOM.li({0}, {1})")]
		public extern static ReactElement Li(LIAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.li({0}, {1})")]
		public extern static ReactElement Li(LIAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.li({0}, {1})")]
		public extern static ReactElement Li(LIAttributes properties, ReactElement child);
		
		[Template("React.DOM.li({0}, {1})")]
		public extern static ReactElement Li(LIAttributes properties, string child);

		[Name("link")] 
		public extern static ReactElement Link(LinkAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.link(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Link(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.link(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Link(IEnumerable<string> children);
		
		[Template("React.DOM.link(null, {0})")]
		public extern static ReactElement Link(ReactElement child);
		
		[Template("React.DOM.link(null, {0})")]
		public extern static ReactElement Link(string child);
		
		[Template("React.DOM.link({0}, {1})")]
		public extern static ReactElement Link(LinkAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.link({0}, {1})")]
		public extern static ReactElement Link(LinkAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.link({0}, {1})")]
		public extern static ReactElement Link(LinkAttributes properties, ReactElement child);
		
		[Template("React.DOM.link({0}, {1})")]
		public extern static ReactElement Link(LinkAttributes properties, string child);

#pragma warning disable 28 // Disable warning CS0028: 'Bridge.React.DOM.Main(Bridge.React.Attributes, params Bridge.React.Any<ReactElement, string>[])' has the wrong signature to be an entry point
		[Name("main")]
		public extern static ReactElement Main(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.main(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Main(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.main(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Main(IEnumerable<string> children);
		
		[Template("React.DOM.main(null, {0})")]
		public extern static ReactElement Main(ReactElement child);
		
		[Template("React.DOM.main(null, {0})")]
		public extern static ReactElement Main(string child);
		
		[Template("React.DOM.main({0}, {1})")]
		public extern static ReactElement Main(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.main({0}, {1})")]
		public extern static ReactElement Main(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.main({0}, {1})")]
		public extern static ReactElement Main(Attributes properties, ReactElement child);
		
		[Template("React.DOM.main({0}, {1})")]
		public extern static ReactElement Main(Attributes properties, string child);
#pragma warning restore 28

		[Name("map")]
		public extern static ReactElement Map(MapAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.map(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Map(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.map(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Map(IEnumerable<string> children);
		
		[Template("React.DOM.map(null, {0})")]
		public extern static ReactElement Map(ReactElement child);
		
		[Template("React.DOM.map(null, {0})")]
		public extern static ReactElement Map(string child);
		
		[Template("React.DOM.map({0}, {1})")]
		public extern static ReactElement Map(MapAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.map({0}, {1})")]
		public extern static ReactElement Map(MapAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.map({0}, {1})")]
		public extern static ReactElement Map(MapAttributes properties, ReactElement child);
		
		[Template("React.DOM.map({0}, {1})")]
		public extern static ReactElement Map(MapAttributes properties, string child);

		[Name("mark")]
		public extern static ReactElement Mark(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.mark(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Mark(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.mark(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Mark(IEnumerable<string> children);
		
		[Template("React.DOM.mark(null, {0})")]
		public extern static ReactElement Mark(ReactElement child);
		
		[Template("React.DOM.mark(null, {0})")]
		public extern static ReactElement Mark(string child);
		
		[Template("React.DOM.mark({0}, {1})")]
		public extern static ReactElement Mark(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.mark({0}, {1})")]
		public extern static ReactElement Mark(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.mark({0}, {1})")]
		public extern static ReactElement Mark(Attributes properties, ReactElement child);
		
		[Template("React.DOM.mark({0}, {1})")]
		public extern static ReactElement Mark(Attributes properties, string child);

		[Name("menu")]
		public extern static ReactElement Menu(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.menu(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Menu(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.menu(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Menu(IEnumerable<string> children);
		
		[Template("React.DOM.menu(null, {0})")]
		public extern static ReactElement Menu(ReactElement child);
		
		[Template("React.DOM.menu(null, {0})")]
		public extern static ReactElement Menu(string child);
		
		[Template("React.DOM.menu({0}, {1})")]
		public extern static ReactElement Menu(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.menu({0}, {1})")]
		public extern static ReactElement Menu(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.menu({0}, {1})")]
		public extern static ReactElement Menu(Attributes properties, ReactElement child);
		
		[Template("React.DOM.menu({0}, {1})")]
		public extern static ReactElement Menu(Attributes properties, string child);

		[Name("menuitem")]
		public extern static ReactElement MenuItem(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.menuitem(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement MenuItem(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.menuitem(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement MenuItem(IEnumerable<string> children);
		
		[Template("React.DOM.menuitem(null, {0})")]
		public extern static ReactElement MenuItem(ReactElement child);
		
		[Template("React.DOM.menuitem(null, {0})")]
		public extern static ReactElement MenuItem(string child);
		
		[Template("React.DOM.menuitem({0}, {1})")]
		public extern static ReactElement MenuItem(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.menuitem({0}, {1})")]
		public extern static ReactElement MenuItem(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.menuitem({0}, {1})")]
		public extern static ReactElement MenuItem(Attributes properties, ReactElement child);
		
		[Template("React.DOM.menuitem({0}, {1})")]
		public extern static ReactElement MenuItem(Attributes properties, string child);

		[Name("meta")]
		public extern static ReactElement Meta(MetaAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.meta(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meta(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.meta(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meta(IEnumerable<string> children);
		
		[Template("React.DOM.meta(null, {0})")]
		public extern static ReactElement Meta(ReactElement child);
		
		[Template("React.DOM.meta(null, {0})")]
		public extern static ReactElement Meta(string child);
		
		[Template("React.DOM.meta({0}, {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.meta({0}, {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.meta({0}, {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, ReactElement child);
		
		[Template("React.DOM.meta({0}, {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, string child);

		[Name("meter")]
		public extern static ReactElement Meter(MeterAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.meter(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meter(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.meter(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meter(IEnumerable<string> children);
		
		[Template("React.DOM.meter(null, {0})")]
		public extern static ReactElement Meter(ReactElement child);
		
		[Template("React.DOM.meter(null, {0})")]
		public extern static ReactElement Meter(string child);
		
		[Template("React.DOM.meter({0}, {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.meter({0}, {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.meter({0}, {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, ReactElement child);
		
		[Template("React.DOM.meter({0}, {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, string child);

		[Name("nav")]
		public extern static ReactElement Nav(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.nav(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Nav(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.nav(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Nav(IEnumerable<string> children);
		
		[Template("React.DOM.nav(null, {0})")]
		public extern static ReactElement Nav(ReactElement child);
		
		[Template("React.DOM.nav(null, {0})")]
		public extern static ReactElement Nav(string child);
		
		[Template("React.DOM.nav({0}, {1})")]
		public extern static ReactElement Nav(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.nav({0}, {1})")]
		public extern static ReactElement Nav(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.nav({0}, {1})")]
		public extern static ReactElement Nav(Attributes properties, ReactElement child);
		
		[Template("React.DOM.nav({0}, {1})")]
		public extern static ReactElement Nav(Attributes properties, string child);

		[Name("noscript")]
		public extern static ReactElement NoScript(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.noscript(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement NoScript(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.noscript(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement NoScript(IEnumerable<string> children);
		
		[Template("React.DOM.noscript(null, {0})")]
		public extern static ReactElement NoScript(ReactElement child);
		
		[Template("React.DOM.noscript(null, {0})")]
		public extern static ReactElement NoScript(string child);
		
		[Template("React.DOM.noscript({0}, {1})")]
		public extern static ReactElement NoScript(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.noscript({0}, {1})")]
		public extern static ReactElement NoScript(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.noscript({0}, {1})")]
		public extern static ReactElement NoScript(Attributes properties, ReactElement child);
		
		[Template("React.DOM.noscript({0}, {1})")]
		public extern static ReactElement NoScript(Attributes properties, string child);

		[Name("object")]
		public extern static ReactElement Object(ObjectAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.object(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Object(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.object(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Object(IEnumerable<string> children);
		
		[Template("React.DOM.object(null, {0})")]
		public extern static ReactElement Object(ReactElement child);
		
		[Template("React.DOM.object(null, {0})")]
		public extern static ReactElement Object(string child);
		
		[Template("React.DOM.object({0}, {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.object({0}, {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.object({0}, {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, ReactElement child);
		
		[Template("React.DOM.object({0}, {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, string child);

		[Name("ol")]
		public extern static ReactElement OL(OListAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.ol(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OL(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ol(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OL(IEnumerable<string> children);
		
		[Template("React.DOM.ol(null, {0})")]
		public extern static ReactElement OL(ReactElement child);
		
		[Template("React.DOM.ol(null, {0})")]
		public extern static ReactElement OL(string child);
		
		[Template("React.DOM.ol({0}, {1})")]
		public extern static ReactElement OL(OListAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ol({0}, {1})")]
		public extern static ReactElement OL(OListAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.ol({0}, {1})")]
		public extern static ReactElement OL(OListAttributes properties, ReactElement child);
		
		[Template("React.DOM.ol({0}, {1})")]
		public extern static ReactElement OL(OListAttributes properties, string child);

		[Name("optgroup")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.optgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OptGroup(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.optgroup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OptGroup(IEnumerable<string> children);
		
		[Template("React.DOM.optgroup(null, {0})")]
		public extern static ReactElement OptGroup(ReactElement child);
		
		[Template("React.DOM.optgroup(null, {0})")]
		public extern static ReactElement OptGroup(string child);
		
		[Template("React.DOM.optgroup({0}, {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.optgroup({0}, {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.optgroup({0}, {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, ReactElement child);
		
		[Template("React.DOM.optgroup({0}, {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, string child);

		[Name("option")]
		public extern static ReactElement Option(OptionAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.option(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Option(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.option(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Option(IEnumerable<string> children);
		
		[Template("React.DOM.option(null, {0})")]
		public extern static ReactElement Option(ReactElement child);
		
		[Template("React.DOM.option(null, {0})")]
		public extern static ReactElement Option(string child);
		
		[Template("React.DOM.option({0}, {1})")]
		public extern static ReactElement Option(OptionAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.option({0}, {1})")]
		public extern static ReactElement Option(OptionAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.option({0}, {1})")]
		public extern static ReactElement Option(OptionAttributes properties, ReactElement child);
		
		[Template("React.DOM.option({0}, {1})")]
		public extern static ReactElement Option(OptionAttributes properties, string child);

		[Name("output")]
		public extern static ReactElement Output(OutputAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.output(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Output(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.output(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Output(IEnumerable<string> children);
		
		[Template("React.DOM.output(null, {0})")]
		public extern static ReactElement Output(ReactElement child);
		
		[Template("React.DOM.output(null, {0})")]
		public extern static ReactElement Output(string child);
		
		[Template("React.DOM.output({0}, {1})")]
		public extern static ReactElement Output(OutputAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.output({0}, {1})")]
		public extern static ReactElement Output(OutputAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.output({0}, {1})")]
		public extern static ReactElement Output(OutputAttributes properties, ReactElement child);
		
		[Template("React.DOM.output({0}, {1})")]
		public extern static ReactElement Output(OutputAttributes properties, string child);

		[Name("p")]
		public extern static ReactElement P(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.p(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement P(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.p(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement P(IEnumerable<string> children);
		
		[Template("React.DOM.p(null, {0})")]
		public extern static ReactElement P(ReactElement child);
		
		[Template("React.DOM.p(null, {0})")]
		public extern static ReactElement P(string child);
		
		[Template("React.DOM.p({0}, {1})")]
		public extern static ReactElement P(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.p({0}, {1})")]
		public extern static ReactElement P(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.p({0}, {1})")]
		public extern static ReactElement P(Attributes properties, ReactElement child);
		
		[Template("React.DOM.p({0}, {1})")]
		public extern static ReactElement P(Attributes properties, string child);

		[Name("param")]
		public extern static ReactElement Param(ParamAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.param(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Param(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.param(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Param(IEnumerable<string> children);
		
		[Template("React.DOM.param(null, {0})")]
		public extern static ReactElement Param(ReactElement child);
		
		[Template("React.DOM.param(null, {0})")]
		public extern static ReactElement Param(string child);
		
		[Template("React.DOM.param({0}, {1})")]
		public extern static ReactElement Param(ParamAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.param({0}, {1})")]
		public extern static ReactElement Param(ParamAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.param({0}, {1})")]
		public extern static ReactElement Param(ParamAttributes properties, ReactElement child);
		
		[Template("React.DOM.param({0}, {1})")]
		public extern static ReactElement Param(ParamAttributes properties, string child);

		[Name("picture")]
		public extern static ReactElement Picture(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.picture(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Picture(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.picture(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Picture(IEnumerable<string> children);
		
		[Template("React.DOM.picture(null, {0})")]
		public extern static ReactElement Picture(ReactElement child);
		
		[Template("React.DOM.picture(null, {0})")]
		public extern static ReactElement Picture(string child);
		
		[Template("React.DOM.picture({0}, {1})")]
		public extern static ReactElement Picture(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.picture({0}, {1})")]
		public extern static ReactElement Picture(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.picture({0}, {1})")]
		public extern static ReactElement Picture(Attributes properties, ReactElement child);
		
		[Template("React.DOM.picture({0}, {1})")]
		public extern static ReactElement Picture(Attributes properties, string child);

		[Name("pre")]
		public extern static ReactElement Pre(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.pre(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Pre(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.pre(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Pre(IEnumerable<string> children);
		
		[Template("React.DOM.pre(null, {0})")]
		public extern static ReactElement Pre(ReactElement child);
		
		[Template("React.DOM.pre(null, {0})")]
		public extern static ReactElement Pre(string child);
		
		[Template("React.DOM.pre({0}, {1})")]
		public extern static ReactElement Pre(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.pre({0}, {1})")]
		public extern static ReactElement Pre(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.pre({0}, {1})")]
		public extern static ReactElement Pre(Attributes properties, ReactElement child);
		
		[Template("React.DOM.pre({0}, {1})")]
		public extern static ReactElement Pre(Attributes properties, string child);

		[Name("progress")]
		public extern static ReactElement Progress(ProgressAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.progress(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Progress(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.progress(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Progress(IEnumerable<string> children);
		
		[Template("React.DOM.progress(null, {0})")]
		public extern static ReactElement Progress(ReactElement child);
		
		[Template("React.DOM.progress(null, {0})")]
		public extern static ReactElement Progress(string child);
		
		[Template("React.DOM.progress({0}, {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.progress({0}, {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.progress({0}, {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, ReactElement child);
		
		[Template("React.DOM.progress({0}, {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, string child);

		[Name("q")]
		public extern static ReactElement Q(QuoteAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.q(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Q(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.q(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Q(IEnumerable<string> children);
		
		[Template("React.DOM.q(null, {0})")]
		public extern static ReactElement Q(ReactElement child);
		
		[Template("React.DOM.q(null, {0})")]
		public extern static ReactElement Q(string child);
		
		[Template("React.DOM.q({0}, {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.q({0}, {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.q({0}, {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, ReactElement child);
		
		[Template("React.DOM.q({0}, {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, string child);

		[Name("rp")]
		public extern static ReactElement RP(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.rp(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RP(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.rp(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RP(IEnumerable<string> children);
		
		[Template("React.DOM.rp(null, {0})")]
		public extern static ReactElement RP(ReactElement child);
		
		[Template("React.DOM.rp(null, {0})")]
		public extern static ReactElement RP(string child);
		
		[Template("React.DOM.rp({0}, {1})")]
		public extern static ReactElement RP(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.rp({0}, {1})")]
		public extern static ReactElement RP(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.rp({0}, {1})")]
		public extern static ReactElement RP(Attributes properties, ReactElement child);
		
		[Template("React.DOM.rp({0}, {1})")]
		public extern static ReactElement RP(Attributes properties, string child);

		[Name("rt")]
		public extern static ReactElement RT(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.rt(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RT(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.rt(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RT(IEnumerable<string> children);
		
		[Template("React.DOM.rt(null, {0})")]
		public extern static ReactElement RT(ReactElement child);
		
		[Template("React.DOM.rt(null, {0})")]
		public extern static ReactElement RT(string child);
		
		[Template("React.DOM.rt({0}, {1})")]
		public extern static ReactElement RT(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.rt({0}, {1})")]
		public extern static ReactElement RT(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.rt({0}, {1})")]
		public extern static ReactElement RT(Attributes properties, ReactElement child);
		
		[Template("React.DOM.rt({0}, {1})")]
		public extern static ReactElement RT(Attributes properties, string child);

		[Name("ruby")]
		public extern static ReactElement Ruby(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.ruby(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ruby(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ruby(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ruby(IEnumerable<string> children);
		
		[Template("React.DOM.ruby(null, {0})")]
		public extern static ReactElement Ruby(ReactElement child);
		
		[Template("React.DOM.ruby(null, {0})")]
		public extern static ReactElement Ruby(string child);
		
		[Template("React.DOM.ruby({0}, {1})")]
		public extern static ReactElement Ruby(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ruby({0}, {1})")]
		public extern static ReactElement Ruby(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.ruby({0}, {1})")]
		public extern static ReactElement Ruby(Attributes properties, ReactElement child);
		
		[Template("React.DOM.ruby({0}, {1})")]
		public extern static ReactElement Ruby(Attributes properties, string child);

		[Name("s")]
		public extern static ReactElement S(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.s(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement S(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.s(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement S(IEnumerable<string> children);
		
		[Template("React.DOM.s(null, {0})")]
		public extern static ReactElement S(ReactElement child);
		
		[Template("React.DOM.s(null, {0})")]
		public extern static ReactElement S(string child);
		
		[Template("React.DOM.s({0}, {1})")]
		public extern static ReactElement S(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.s({0}, {1})")]
		public extern static ReactElement S(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.s({0}, {1})")]
		public extern static ReactElement S(Attributes properties, ReactElement child);
		
		[Template("React.DOM.s({0}, {1})")]
		public extern static ReactElement S(Attributes properties, string child);

		[Name("samp")]
		public extern static ReactElement Samp(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.samp(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Samp(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.samp(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Samp(IEnumerable<string> children);
		
		[Template("React.DOM.samp(null, {0})")]
		public extern static ReactElement Samp(ReactElement child);
		
		[Template("React.DOM.samp(null, {0})")]
		public extern static ReactElement Samp(string child);
		
		[Template("React.DOM.samp({0}, {1})")]
		public extern static ReactElement Samp(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.samp({0}, {1})")]
		public extern static ReactElement Samp(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.samp({0}, {1})")]
		public extern static ReactElement Samp(Attributes properties, ReactElement child);
		
		[Template("React.DOM.samp({0}, {1})")]
		public extern static ReactElement Samp(Attributes properties, string child);

		[Name("script")]
		public extern static ReactElement Script(ScriptAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.script(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Script(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.script(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Script(IEnumerable<string> children);
		
		[Template("React.DOM.script(null, {0})")]
		public extern static ReactElement Script(ReactElement child);
		
		[Template("React.DOM.script(null, {0})")]
		public extern static ReactElement Script(string child);
		
		[Template("React.DOM.script({0}, {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.script({0}, {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.script({0}, {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, ReactElement child);
		
		[Template("React.DOM.script({0}, {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, string child);

		[Name("section")]
		public extern static ReactElement Section(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.section(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Section(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.section(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Section(IEnumerable<string> children);
		
		[Template("React.DOM.section(null, {0})")]
		public extern static ReactElement Section(ReactElement child);
		
		[Template("React.DOM.section(null, {0})")]
		public extern static ReactElement Section(string child);
		
		[Template("React.DOM.section({0}, {1})")]
		public extern static ReactElement Section(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.section({0}, {1})")]
		public extern static ReactElement Section(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.section({0}, {1})")]
		public extern static ReactElement Section(Attributes properties, ReactElement child);
		
		[Template("React.DOM.section({0}, {1})")]
		public extern static ReactElement Section(Attributes properties, string child);

		[Name("select")]
		public extern static ReactElement Select(SelectAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.select(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Select(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.select(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Select(IEnumerable<string> children);
		
		[Template("React.DOM.select(null, {0})")]
		public extern static ReactElement Select(ReactElement child);
		
		[Template("React.DOM.select(null, {0})")]
		public extern static ReactElement Select(string child);
		
		[Template("React.DOM.select({0}, {1})")]
		public extern static ReactElement Select(SelectAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.select({0}, {1})")]
		public extern static ReactElement Select(SelectAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.select({0}, {1})")]
		public extern static ReactElement Select(SelectAttributes properties, ReactElement child);
		
		[Template("React.DOM.select({0}, {1})")]
		public extern static ReactElement Select(SelectAttributes properties, string child);

		[Name("small")]
		public extern static ReactElement Small(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.small(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Small(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.small(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Small(IEnumerable<string> children);
		
		[Template("React.DOM.small(null, {0})")]
		public extern static ReactElement Small(ReactElement child);
		
		[Template("React.DOM.small(null, {0})")]
		public extern static ReactElement Small(string child);
		
		[Template("React.DOM.small({0}, {1})")]
		public extern static ReactElement Small(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.small({0}, {1})")]
		public extern static ReactElement Small(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.small({0}, {1})")]
		public extern static ReactElement Small(Attributes properties, ReactElement child);
		
		[Template("React.DOM.small({0}, {1})")]
		public extern static ReactElement Small(Attributes properties, string child);

		[Name("source")]
		public extern static ReactElement Source(SourceAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.source(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Source(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.source(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Source(IEnumerable<string> children);
		
		[Template("React.DOM.source(null, {0})")]
		public extern static ReactElement Source(ReactElement child);
		
		[Template("React.DOM.source(null, {0})")]
		public extern static ReactElement Source(string child);
		
		[Template("React.DOM.source({0}, {1})")]
		public extern static ReactElement Source(SourceAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.source({0}, {1})")]
		public extern static ReactElement Source(SourceAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.source({0}, {1})")]
		public extern static ReactElement Source(SourceAttributes properties, ReactElement child);
		
		[Template("React.DOM.source({0}, {1})")]
		public extern static ReactElement Source(SourceAttributes properties, string child);

		[Name("span")]
		public extern static ReactElement Span(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.span(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Span(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.span(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Span(IEnumerable<string> children);
		
		[Template("React.DOM.span(null, {0})")]
		public extern static ReactElement Span(ReactElement child);
		
		[Template("React.DOM.span(null, {0})")]
		public extern static ReactElement Span(string child);
		
		[Template("React.DOM.span({0}, {1})")]
		public extern static ReactElement Span(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.span({0}, {1})")]
		public extern static ReactElement Span(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.span({0}, {1})")]
		public extern static ReactElement Span(Attributes properties, ReactElement child);
		
		[Template("React.DOM.span({0}, {1})")]
		public extern static ReactElement Span(Attributes properties, string child);

		[Name("strong")]
		public extern static ReactElement Strong(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.strong(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Strong(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.strong(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Strong(IEnumerable<string> children);
		
		[Template("React.DOM.strong(null, {0})")]
		public extern static ReactElement Strong(ReactElement child);
		
		[Template("React.DOM.strong(null, {0})")]
		public extern static ReactElement Strong(string child);
		
		[Template("React.DOM.strong({0}, {1})")]
		public extern static ReactElement Strong(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.strong({0}, {1})")]
		public extern static ReactElement Strong(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.strong({0}, {1})")]
		public extern static ReactElement Strong(Attributes properties, ReactElement child);
		
		[Template("React.DOM.strong({0}, {1})")]
		public extern static ReactElement Strong(Attributes properties, string child);

		[Name("style")]
		public extern static ReactElement Style(StyleAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.style(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Style(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.style(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Style(IEnumerable<string> children);
		
		[Template("React.DOM.style(null, {0})")]
		public extern static ReactElement Style(ReactElement child);
		
		[Template("React.DOM.style(null, {0})")]
		public extern static ReactElement Style(string child);
		
		[Template("React.DOM.style({0}, {1})")]
		public extern static ReactElement Style(StyleAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.style({0}, {1})")]
		public extern static ReactElement Style(StyleAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.style({0}, {1})")]
		public extern static ReactElement Style(StyleAttributes properties, ReactElement child);
		
		[Template("React.DOM.style({0}, {1})")]
		public extern static ReactElement Style(StyleAttributes properties, string child);

		[Name("sub")]
		public extern static ReactElement Sub(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.sub(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sub(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.sub(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sub(IEnumerable<string> children);
		
		[Template("React.DOM.sub(null, {0})")]
		public extern static ReactElement Sub(ReactElement child);
		
		[Template("React.DOM.sub(null, {0})")]
		public extern static ReactElement Sub(string child);
		
		[Template("React.DOM.sub({0}, {1})")]
		public extern static ReactElement Sub(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.sub({0}, {1})")]
		public extern static ReactElement Sub(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.sub({0}, {1})")]
		public extern static ReactElement Sub(Attributes properties, ReactElement child);
		
		[Template("React.DOM.sub({0}, {1})")]
		public extern static ReactElement Sub(Attributes properties, string child);

		[Name("summary")]
		public extern static ReactElement Summary(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.summary(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Summary(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.summary(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Summary(IEnumerable<string> children);
		
		[Template("React.DOM.summary(null, {0})")]
		public extern static ReactElement Summary(ReactElement child);
		
		[Template("React.DOM.summary(null, {0})")]
		public extern static ReactElement Summary(string child);
		
		[Template("React.DOM.summary({0}, {1})")]
		public extern static ReactElement Summary(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.summary({0}, {1})")]
		public extern static ReactElement Summary(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.summary({0}, {1})")]
		public extern static ReactElement Summary(Attributes properties, ReactElement child);
		
		[Template("React.DOM.summary({0}, {1})")]
		public extern static ReactElement Summary(Attributes properties, string child);

		[Name("sup")]
		public extern static ReactElement Sup(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.sup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sup(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.sup(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sup(IEnumerable<string> children);
		
		[Template("React.DOM.sup(null, {0})")]
		public extern static ReactElement Sup(ReactElement child);
		
		[Template("React.DOM.sup(null, {0})")]
		public extern static ReactElement Sup(string child);
		
		[Template("React.DOM.sup({0}, {1})")]
		public extern static ReactElement Sup(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.sup({0}, {1})")]
		public extern static ReactElement Sup(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.sup({0}, {1})")]
		public extern static ReactElement Sup(Attributes properties, ReactElement child);
		
		[Template("React.DOM.sup({0}, {1})")]
		public extern static ReactElement Sup(Attributes properties, string child);

		[Name("table")]
		public extern static ReactElement Table(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.table(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Table(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.table(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Table(IEnumerable<string> children);
		
		[Template("React.DOM.table(null, {0})")]
		public extern static ReactElement Table(ReactElement child);
		
		[Template("React.DOM.table(null, {0})")]
		public extern static ReactElement Table(string child);
		
		[Template("React.DOM.table({0}, {1})")]
		public extern static ReactElement Table(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.table({0}, {1})")]
		public extern static ReactElement Table(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.table({0}, {1})")]
		public extern static ReactElement Table(Attributes properties, ReactElement child);
		
		[Template("React.DOM.table({0}, {1})")]
		public extern static ReactElement Table(Attributes properties, string child);

		[Name("tbody")]
		public extern static ReactElement TBody(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.tbody(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TBody(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tbody(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TBody(IEnumerable<string> children);
		
		[Template("React.DOM.tbody(null, {0})")]
		public extern static ReactElement TBody(ReactElement child);
		
		[Template("React.DOM.tbody(null, {0})")]
		public extern static ReactElement TBody(string child);
		
		[Template("React.DOM.tbody({0}, {1})")]
		public extern static ReactElement TBody(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tbody({0}, {1})")]
		public extern static ReactElement TBody(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.tbody({0}, {1})")]
		public extern static ReactElement TBody(Attributes properties, ReactElement child);
		
		[Template("React.DOM.tbody({0}, {1})")]
		public extern static ReactElement TBody(Attributes properties, string child);

		[Name("td")]
		public extern static ReactElement TD(TableCellAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.td(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TD(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.td(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TD(IEnumerable<string> children);
		
		[Template("React.DOM.td(null, {0})")]
		public extern static ReactElement TD(ReactElement child);
		
		[Template("React.DOM.td(null, {0})")]
		public extern static ReactElement TD(string child);
		
		[Template("React.DOM.td({0}, {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.td({0}, {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.td({0}, {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, ReactElement child);
		
		[Template("React.DOM.td({0}, {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, string child);

		/// <summary>
		/// A TextArea's contents should be set using the Value property, rather than children (React includes a warning if TextArea contents are set using children and so this is not allowed with these bindings)
		/// </summary>
		[Name("textarea")]
		public extern static ReactElement TextArea(TextAreaAttributes properties);

		/// <summary>
		/// A TextArea's contents should be set using the Value property on a TextAreaAttributes instance, rather than children (React includes a warning if TextArea contents are set using children and so this is
		/// not allowed with these bindings)
		/// </summary>
		[Name("textarea")]
		public extern static ReactElement TextArea();

		[Name("tfoot")]
		public extern static ReactElement TFoot(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.tfoot(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TFoot(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tfoot(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TFoot(IEnumerable<string> children);
		
		[Template("React.DOM.tfoot(null, {0})")]
		public extern static ReactElement TFoot(ReactElement child);
		
		[Template("React.DOM.tfoot(null, {0})")]
		public extern static ReactElement TFoot(string child);
		
		[Template("React.DOM.tfoot({0}, {1})")]
		public extern static ReactElement TFoot(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tfoot({0}, {1})")]
		public extern static ReactElement TFoot(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.tfoot({0}, {1})")]
		public extern static ReactElement TFoot(Attributes properties, ReactElement child);
		
		[Template("React.DOM.tfoot({0}, {1})")]
		public extern static ReactElement TFoot(Attributes properties, string child);

		[Name("th")]
		public extern static ReactElement TH(TableCellAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.th(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TH(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.th(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TH(IEnumerable<string> children);
		
		[Template("React.DOM.th(null, {0})")]
		public extern static ReactElement TH(ReactElement child);
		
		[Template("React.DOM.th(null, {0})")]
		public extern static ReactElement TH(string child);
		
		[Template("React.DOM.th({0}, {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.th({0}, {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.th({0}, {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, ReactElement child);
		
		[Template("React.DOM.th({0}, {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, string child);

		[Name("thead")]
		public extern static ReactElement THead(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.thead(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement THead(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.thead(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement THead(IEnumerable<string> children);
		
		[Template("React.DOM.thead(null, {0})")]
		public extern static ReactElement THead(ReactElement child);
		
		[Template("React.DOM.thead(null, {0})")]
		public extern static ReactElement THead(string child);
		
		[Template("React.DOM.thead({0}, {1})")]
		public extern static ReactElement THead(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.thead({0}, {1})")]
		public extern static ReactElement THead(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.thead({0}, {1})")]
		public extern static ReactElement THead(Attributes properties, ReactElement child);
		
		[Template("React.DOM.thead({0}, {1})")]
		public extern static ReactElement THead(Attributes properties, string child);

		[Name("time")]
		public extern static ReactElement Time(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.time(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Time(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.time(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Time(IEnumerable<string> children);
		
		[Template("React.DOM.time(null, {0})")]
		public extern static ReactElement Time(ReactElement child);
		
		[Template("React.DOM.time(null, {0})")]
		public extern static ReactElement Time(string child);
		
		[Template("React.DOM.time({0}, {1})")]
		public extern static ReactElement Time(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.time({0}, {1})")]
		public extern static ReactElement Time(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.time({0}, {1})")]
		public extern static ReactElement Time(Attributes properties, ReactElement child);
		
		[Template("React.DOM.time({0}, {1})")]
		public extern static ReactElement Time(Attributes properties, string child);

		[Name("title")]
		public extern static ReactElement Title(TitleAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.title(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Title(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.title(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Title(IEnumerable<string> children);
		
		[Template("React.DOM.title(null, {0})")]
		public extern static ReactElement Title(ReactElement child);
		
		[Template("React.DOM.title(null, {0})")]
		public extern static ReactElement Title(string child);
		
		[Template("React.DOM.title({0}, {1})")]
		public extern static ReactElement Title(TitleAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.title({0}, {1})")]
		public extern static ReactElement Title(TitleAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.title({0}, {1})")]
		public extern static ReactElement Title(TitleAttributes properties, ReactElement child);
		
		[Template("React.DOM.title({0}, {1})")]
		public extern static ReactElement Title(TitleAttributes properties, string child);

		[Name("tr")]
		public extern static ReactElement TR(TableCellAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.tr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TR(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TR(IEnumerable<string> children);
		
		[Template("React.DOM.tr(null, {0})")]
		public extern static ReactElement TR(ReactElement child);
		
		[Template("React.DOM.tr(null, {0})")]
		public extern static ReactElement TR(string child);
		
		[Template("React.DOM.tr({0}, {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.tr({0}, {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.tr({0}, {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, ReactElement child);
		
		[Template("React.DOM.tr({0}, {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, string child);

		[Name("track")]
		public extern static ReactElement Track(TrackAttributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.track(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Track(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.track(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Track(IEnumerable<string> children);
		
		[Template("React.DOM.track(null, {0})")]
		public extern static ReactElement Track(ReactElement child);
		
		[Template("React.DOM.track(null, {0})")]
		public extern static ReactElement Track(string child);
		
		[Template("React.DOM.track({0}, {1})")]
		public extern static ReactElement Track(TrackAttributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.track({0}, {1})")]
		public extern static ReactElement Track(TrackAttributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.track({0}, {1})")]
		public extern static ReactElement Track(TrackAttributes properties, ReactElement child);
		
		[Template("React.DOM.track({0}, {1})")]
		public extern static ReactElement Track(TrackAttributes properties, string child);

		[Name("u")]
		public extern static ReactElement U(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.u(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement U(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.u(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement U(IEnumerable<string> children);
		
		[Template("React.DOM.u(null, {0})")]
		public extern static ReactElement U(ReactElement child);
		
		[Template("React.DOM.u(null, {0})")]
		public extern static ReactElement U(string child);
		
		[Template("React.DOM.u({0}, {1})")]
		public extern static ReactElement U(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.u({0}, {1})")]
		public extern static ReactElement U(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.u({0}, {1})")]
		public extern static ReactElement U(Attributes properties, ReactElement child);
		
		[Template("React.DOM.u({0}, {1})")]
		public extern static ReactElement U(Attributes properties, string child);

		[Name("ul")]
		public extern static ReactElement UL(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.ul(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement UL(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ul(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement UL(IEnumerable<string> children);
		
		[Template("React.DOM.ul(null, {0})")]
		public extern static ReactElement UL(ReactElement child);
		
		[Template("React.DOM.ul(null, {0})")]
		public extern static ReactElement UL(string child);
		
		[Template("React.DOM.ul({0}, {1})")]
		public extern static ReactElement UL(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.ul({0}, {1})")]
		public extern static ReactElement UL(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.ul({0}, {1})")]
		public extern static ReactElement UL(Attributes properties, ReactElement child);
		
		[Template("React.DOM.ul({0}, {1})")]
		public extern static ReactElement UL(Attributes properties, string child);

		[Name("Var")]
		public extern static ReactElement Var(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.Var(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Var(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.Var(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Var(IEnumerable<string> children);
		
		[Template("React.DOM.Var(null, {0})")]
		public extern static ReactElement Var(ReactElement child);
		
		[Template("React.DOM.Var(null, {0})")]
		public extern static ReactElement Var(string child);
		
		[Template("React.DOM.Var({0}, {1})")]
		public extern static ReactElement Var(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.Var({0}, {1})")]
		public extern static ReactElement Var(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.Var({0}, {1})")]
		public extern static ReactElement Var(Attributes properties, ReactElement child);
		
		[Template("React.DOM.Var({0}, {1})")]
		public extern static ReactElement Var(Attributes properties, string child);

		[Name("video")]
		public extern static ReactElement Video(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.video(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Video(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.video(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Video(IEnumerable<string> children);
		
		[Template("React.DOM.video(null, {0})")]
		public extern static ReactElement Video(ReactElement child);
		
		[Template("React.DOM.video(null, {0})")]
		public extern static ReactElement Video(string child);
		
		[Template("React.DOM.video({0}, {1})")]
		public extern static ReactElement Video(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.video({0}, {1})")]
		public extern static ReactElement Video(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.video({0}, {1})")]
		public extern static ReactElement Video(Attributes properties, ReactElement child);
		
		[Template("React.DOM.video({0}, {1})")]
		public extern static ReactElement Video(Attributes properties, string child);

		[Name("wbr")]
		public extern static ReactElement WBR(Attributes properties, params Any<ReactElement, string>[] children);
		
		[Template("React.DOM.wbr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement WBR(IEnumerable<ReactElement> children);
		
		[Template("React.DOM.wbr(null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement WBR(IEnumerable<string> children);
		
		[Template("React.DOM.wbr(null, {0})")]
		public extern static ReactElement WBR(ReactElement child);
		
		[Template("React.DOM.wbr(null, {0})")]
		public extern static ReactElement WBR(string child);
		
		[Template("React.DOM.wbr({0}, {1})")]
		public extern static ReactElement WBR(Attributes properties, IEnumerable<ReactElement> children);
		
		[Template("React.DOM.wbr({0}, {1})")]
		public extern static ReactElement WBR(Attributes properties, IEnumerable<string> children);
		
		[Template("React.DOM.wbr({0}, {1})")]
		public extern static ReactElement WBR(Attributes properties, ReactElement child);
		
		[Template("React.DOM.wbr({0}, {1})")]
		public extern static ReactElement WBR(Attributes properties, string child);
	}
}
