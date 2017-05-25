using System.Collections.Generic;

namespace Bridge.React
{
	[Name("React.DOM")]
	[External]
	public static class DOM
	{
		[Template("React.createElement('a', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement A(AnchorAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('a', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement A(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('a', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement A<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('a', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement A<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('a', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement A(IEnumerable<string> children);

		[Template("React.createElement('a', null, {0})")]
		public extern static ReactElement A(ReactElement child);

		[Template("React.createElement('a', null, {0})")]
		public extern static ReactElement A(string child);

		[Template("React.createElement('a', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement A(AnchorAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('a', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement A<TProps>(AnchorAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('a', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement A<TProps>(AnchorAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('a', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement A(AnchorAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('a', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement A(AnchorAttributes properties, ReactElement child);

		[Template("React.createElement('a', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement A(AnchorAttributes properties, string child);

		[Template("React.createElement('abbr', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Abbr(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('abbr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Abbr(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('abbr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Abbr<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('abbr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Abbr<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('abbr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Abbr(IEnumerable<string> children);

		[Template("React.createElement('abbr', null, {0})")]
		public extern static ReactElement Abbr(ReactElement child);

		[Template("React.createElement('abbr', null, {0})")]
		public extern static ReactElement Abbr(string child);

		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Abbr(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Abbr<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Abbr<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Abbr(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Abbr(Attributes properties, ReactElement child);

		[Template("React.createElement('abbr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Abbr(Attributes properties, string child);

		[Template("React.createElement('address', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Address(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('address', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Address(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('address', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Address<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('address', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Address<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('address', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Address(IEnumerable<string> children);

		[Template("React.createElement('address', null, {0})")]
		public extern static ReactElement Address(ReactElement child);

		[Template("React.createElement('address', null, {0})")]
		public extern static ReactElement Address(string child);

		[Template("React.createElement('address', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Address(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('address', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Address<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('address', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Address<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('address', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Address(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('address', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Address(Attributes properties, ReactElement child);

		[Template("React.createElement('address', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Address(Attributes properties, string child);

		[Template("React.createElement('area', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Area(AreaAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('area', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Area(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('area', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Area<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('area', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Area<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('area', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Area(IEnumerable<string> children);

		[Template("React.createElement('area', null, {0})")]
		public extern static ReactElement Area(ReactElement child);

		[Template("React.createElement('area', null, {0})")]
		public extern static ReactElement Area(string child);

		[Template("React.createElement('area', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Area(AreaAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('area', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Area<TProps>(AreaAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('area', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Area<TProps>(AreaAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('area', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Area(AreaAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('area', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Area(AreaAttributes properties, ReactElement child);

		[Template("React.createElement('area', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Area(AreaAttributes properties, string child);

		[Template("React.createElement('article', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Article(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('article', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Article(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('article', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Article<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('article', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Article<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('article', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Article(IEnumerable<string> children);

		[Template("React.createElement('article', null, {0})")]
		public extern static ReactElement Article(ReactElement child);

		[Template("React.createElement('article', null, {0})")]
		public extern static ReactElement Article(string child);

		[Template("React.createElement('article', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Article(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('article', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Article<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('article', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Article<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('article', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Article(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('article', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Article(Attributes properties, ReactElement child);

		[Template("React.createElement('article', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Article(Attributes properties, string child);

		[Template("React.createElement('aside', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Aside(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('aside', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Aside(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('aside', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Aside<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('aside', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Aside<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('aside', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Aside(IEnumerable<string> children);

		[Template("React.createElement('aside', null, {0})")]
		public extern static ReactElement Aside(ReactElement child);

		[Template("React.createElement('aside', null, {0})")]
		public extern static ReactElement Aside(string child);

		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Aside(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Aside<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Aside<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Aside(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Aside(Attributes properties, ReactElement child);

		[Template("React.createElement('aside', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Aside(Attributes properties, string child);

		[Template("React.createElement('audio', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Audio(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('audio', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Audio(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('audio', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Audio<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('audio', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Audio<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('audio', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Audio(IEnumerable<string> children);

		[Template("React.createElement('audio', null, {0})")]
		public extern static ReactElement Audio(ReactElement child);

		[Template("React.createElement('audio', null, {0})")]
		public extern static ReactElement Audio(string child);

		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Audio(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Audio<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Audio<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Audio(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Audio(Attributes properties, ReactElement child);

		[Template("React.createElement('audio', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Audio(Attributes properties, string child);

		[Template("React.createElement('b', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement B(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('b', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement B(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('b', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement B<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('b', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement B<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('b', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement B(IEnumerable<string> children);

		[Template("React.createElement('b', null, {0})")]
		public extern static ReactElement B(ReactElement child);

		[Template("React.createElement('b', null, {0})")]
		public extern static ReactElement B(string child);

		[Template("React.createElement('b', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement B(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('b', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement B<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('b', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement B<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('b', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement B(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('b', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement B(Attributes properties, ReactElement child);

		[Template("React.createElement('b', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement B(Attributes properties, string child);

		[Template("React.createElement('base', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Base(BaseAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('base', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Base(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('base', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Base<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('base', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Base<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('base', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Base(IEnumerable<string> children);

		[Template("React.createElement('base', null, {0})")]
		public extern static ReactElement Base(ReactElement child);

		[Template("React.createElement('base', null, {0})")]
		public extern static ReactElement Base(string child);

		[Template("React.createElement('base', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Base(BaseAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('base', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Base<TProps>(BaseAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('base', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Base<TProps>(BaseAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('base', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Base(BaseAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('base', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Base(BaseAttributes properties, ReactElement child);

		[Template("React.createElement('base', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Base(BaseAttributes properties, string child);

		[Template("React.createElement('bdi', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement BDI(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('bdi', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDI(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdi', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BDI<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdi', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BDI<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('bdi', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDI(IEnumerable<string> children);

		[Template("React.createElement('bdi', null, {0})")]
		public extern static ReactElement BDI(ReactElement child);

		[Template("React.createElement('bdi', null, {0})")]
		public extern static ReactElement BDI(string child);

		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BDI(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BDI<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BDI<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BDI(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BDI(Attributes properties, ReactElement child);

		[Template("React.createElement('bdi', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BDI(Attributes properties, string child);

		[Template("React.createElement('bdo', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement BDO(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('bdo', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDO(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdo', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BDO<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdo', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BDO<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('bdo', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BDO(IEnumerable<string> children);

		[Template("React.createElement('bdo', null, {0})")]
		public extern static ReactElement BDO(ReactElement child);

		[Template("React.createElement('bdo', null, {0})")]
		public extern static ReactElement BDO(string child);

		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BDO(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BDO<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BDO<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BDO(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BDO(Attributes properties, ReactElement child);

		[Template("React.createElement('bdo', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BDO(Attributes properties, string child);

		[Template("React.createElement('big', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Big(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('big', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Big(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('big', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Big<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('big', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Big<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('big', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Big(IEnumerable<string> children);

		[Template("React.createElement('big', null, {0})")]
		public extern static ReactElement Big(ReactElement child);

		[Template("React.createElement('big', null, {0})")]
		public extern static ReactElement Big(string child);

		[Template("React.createElement('big', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Big(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('big', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Big<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('big', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Big<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('big', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Big(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('big', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Big(Attributes properties, ReactElement child);

		[Template("React.createElement('big', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Big(Attributes properties, string child);

		[Template("React.createElement('blockquote', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('blockquote', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BlockQuote(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('blockquote', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BlockQuote<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('blockquote', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement BlockQuote<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('blockquote', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement BlockQuote(IEnumerable<string> children);

		[Template("React.createElement('blockquote', null, {0})")]
		public extern static ReactElement BlockQuote(ReactElement child);

		[Template("React.createElement('blockquote', null, {0})")]
		public extern static ReactElement BlockQuote(string child);

		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BlockQuote<TProps>(QuoteAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement BlockQuote<TProps>(QuoteAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, ReactElement child);

		[Template("React.createElement('blockquote', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement BlockQuote(QuoteAttributes properties, string child);

		[Template("React.createElement('body', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Body(BodyAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('body', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Body(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('body', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Body<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('body', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Body<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('body', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Body(IEnumerable<string> children);

		[Template("React.createElement('body', null, {0})")]
		public extern static ReactElement Body(ReactElement child);

		[Template("React.createElement('body', null, {0})")]
		public extern static ReactElement Body(string child);

		[Template("React.createElement('body', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Body(BodyAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('body', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Body<TProps>(BodyAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('body', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Body<TProps>(BodyAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('body', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Body(BodyAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('body', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Body(BodyAttributes properties, ReactElement child);

		[Template("React.createElement('body', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Body(BodyAttributes properties, string child);

		[Template("React.createElement('br', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Br(BrAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('br', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Br(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('br', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Br<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('br', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Br<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('br', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Br(IEnumerable<string> children);

		[Template("React.createElement('br', null, {0})")]
		public extern static ReactElement Br(ReactElement child);

		[Template("React.createElement('br', null, {0})")]
		public extern static ReactElement Br(string child);

		[Template("React.createElement('br', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Br(BrAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('br', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Br<TProps>(BrAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('br', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Br<TProps>(BrAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('br', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Br(BrAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('br', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Br(BrAttributes properties, ReactElement child);

		[Template("React.createElement('br', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Br(BrAttributes properties, string child);

		[Template("React.createElement('button', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Button(ButtonAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('button', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Button(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('button', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Button<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('button', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Button<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('button', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Button(IEnumerable<string> children);

		[Template("React.createElement('button', null, {0})")]
		public extern static ReactElement Button(ReactElement child);

		[Template("React.createElement('button', null, {0})")]
		public extern static ReactElement Button(string child);

		[Template("React.createElement('button', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Button(ButtonAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('button', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Button<TProps>(ButtonAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('button', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Button<TProps>(ButtonAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('button', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Button(ButtonAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('button', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, ReactElement child);

		[Template("React.createElement('button', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Button(ButtonAttributes properties, string child);

		[Template("React.createElement('canvas', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('canvas', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Canvas(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('canvas', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Canvas<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('canvas', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Canvas<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('canvas', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Canvas(IEnumerable<string> children);

		[Template("React.createElement('canvas', null, {0})")]
		public extern static ReactElement Canvas(ReactElement child);

		[Template("React.createElement('canvas', null, {0})")]
		public extern static ReactElement Canvas(string child);

		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Canvas(CanvasAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Canvas<TProps>(CanvasAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Canvas<TProps>(CanvasAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Canvas(CanvasAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, ReactElement child);

		[Template("React.createElement('canvas', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Canvas(CanvasAttributes properties, string child);

		[Template("React.createElement('caption', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Caption(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('caption', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Caption(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('caption', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Caption<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('caption', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Caption<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('caption', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Caption(IEnumerable<string> children);

		[Template("React.createElement('caption', null, {0})")]
		public extern static ReactElement Caption(ReactElement child);

		[Template("React.createElement('caption', null, {0})")]
		public extern static ReactElement Caption(string child);

		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Caption(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Caption<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Caption<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Caption(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Caption(Attributes properties, ReactElement child);

		[Template("React.createElement('caption', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Caption(Attributes properties, string child);

		[Template("React.createElement('cite', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Cite(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('cite', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Cite(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('cite', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Cite<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('cite', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Cite<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('cite', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Cite(IEnumerable<string> children);

		[Template("React.createElement('cite', null, {0})")]
		public extern static ReactElement Cite(ReactElement child);

		[Template("React.createElement('cite', null, {0})")]
		public extern static ReactElement Cite(string child);

		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Cite(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Cite<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Cite<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Cite(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Cite(Attributes properties, ReactElement child);

		[Template("React.createElement('cite', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Cite(Attributes properties, string child);

		[Template("React.createElement('code', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Code(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('code', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Code(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('code', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Code<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('code', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Code<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('code', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Code(IEnumerable<string> children);

		[Template("React.createElement('code', null, {0})")]
		public extern static ReactElement Code(ReactElement child);

		[Template("React.createElement('code', null, {0})")]
		public extern static ReactElement Code(string child);

		[Template("React.createElement('code', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Code(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('code', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Code<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('code', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Code<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('code', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Code(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('code', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Code(Attributes properties, ReactElement child);

		[Template("React.createElement('code', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Code(Attributes properties, string child);

		[Template("React.createElement('col', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Col(TableColAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('col', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Col(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('col', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Col<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('col', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Col<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('col', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Col(IEnumerable<string> children);

		[Template("React.createElement('col', null, {0})")]
		public extern static ReactElement Col(ReactElement child);

		[Template("React.createElement('col', null, {0})")]
		public extern static ReactElement Col(string child);

		[Template("React.createElement('col', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Col(TableColAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('col', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Col<TProps>(TableColAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('col', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Col<TProps>(TableColAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('col', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Col(TableColAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('col', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Col(TableColAttributes properties, ReactElement child);

		[Template("React.createElement('col', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Col(TableColAttributes properties, string child);

		[Template("React.createElement('colgroup', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement ColGroup(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('colgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement ColGroup(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('colgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement ColGroup<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('colgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement ColGroup<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('colgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement ColGroup(IEnumerable<string> children);

		[Template("React.createElement('colgroup', null, {0})")]
		public extern static ReactElement ColGroup(ReactElement child);

		[Template("React.createElement('colgroup', null, {0})")]
		public extern static ReactElement ColGroup(string child);

		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement ColGroup(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement ColGroup<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement ColGroup<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement ColGroup(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement ColGroup(Attributes properties, ReactElement child);

		[Template("React.createElement('colgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement ColGroup(Attributes properties, string child);

		[Template("React.createElement('data', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Data(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('data', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Data(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('data', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Data<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('data', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Data<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('data', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Data(IEnumerable<string> children);

		[Template("React.createElement('data', null, {0})")]
		public extern static ReactElement Data(ReactElement child);

		[Template("React.createElement('data', null, {0})")]
		public extern static ReactElement Data(string child);

		[Template("React.createElement('data', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Data(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('data', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Data<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('data', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Data<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('data', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Data(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('data', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Data(Attributes properties, ReactElement child);

		[Template("React.createElement('data', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Data(Attributes properties, string child);

		[Template("React.createElement('datalist', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement DataList(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('datalist', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DataList(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('datalist', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DataList<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('datalist', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DataList<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('datalist', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DataList(IEnumerable<string> children);

		[Template("React.createElement('datalist', null, {0})")]
		public extern static ReactElement DataList(ReactElement child);

		[Template("React.createElement('datalist', null, {0})")]
		public extern static ReactElement DataList(string child);

		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DataList(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DataList<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DataList<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DataList(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DataList(Attributes properties, ReactElement child);

		[Template("React.createElement('datalist', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DataList(Attributes properties, string child);

		[Template("React.createElement('dd', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement DD(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('dd', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DD(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dd', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DD<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dd', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DD<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dd', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DD(IEnumerable<string> children);

		[Template("React.createElement('dd', null, {0})")]
		public extern static ReactElement DD(ReactElement child);

		[Template("React.createElement('dd', null, {0})")]
		public extern static ReactElement DD(string child);

		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DD(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DD<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DD<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DD(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DD(Attributes properties, ReactElement child);

		[Template("React.createElement('dd', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DD(Attributes properties, string child);

		[Template("React.createElement('del', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Del(DelAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('del', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Del(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('del', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Del<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('del', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Del<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('del', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Del(IEnumerable<string> children);

		[Template("React.createElement('del', null, {0})")]
		public extern static ReactElement Del(ReactElement child);

		[Template("React.createElement('del', null, {0})")]
		public extern static ReactElement Del(string child);

		[Template("React.createElement('del', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Del(DelAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('del', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Del<TProps>(DelAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('del', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Del<TProps>(DelAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('del', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Del(DelAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('del', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Del(DelAttributes properties, ReactElement child);

		[Template("React.createElement('del', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Del(DelAttributes properties, string child);

		[Template("React.createElement('details', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Details(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('details', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Details(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('details', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Details<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('details', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Details<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('details', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Details(IEnumerable<string> children);

		[Template("React.createElement('details', null, {0})")]
		public extern static ReactElement Details(ReactElement child);

		[Template("React.createElement('details', null, {0})")]
		public extern static ReactElement Details(string child);

		[Template("React.createElement('details', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Details(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('details', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Details<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('details', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Details<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('details', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Details(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('details', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Details(Attributes properties, ReactElement child);

		[Template("React.createElement('details', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Details(Attributes properties, string child);

		[Template("React.createElement('dfn', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Dfn(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('dfn', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dfn(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dfn', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Dfn<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dfn', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Dfn<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dfn', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dfn(IEnumerable<string> children);

		[Template("React.createElement('dfn', null, {0})")]
		public extern static ReactElement Dfn(ReactElement child);

		[Template("React.createElement('dfn', null, {0})")]
		public extern static ReactElement Dfn(string child);

		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Dfn(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Dfn<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Dfn<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Dfn(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Dfn(Attributes properties, ReactElement child);

		[Template("React.createElement('dfn', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Dfn(Attributes properties, string child);

		[Template("React.createElement('dialog', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Dialog(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('dialog', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dialog(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dialog', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Dialog<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dialog', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Dialog<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dialog', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Dialog(IEnumerable<string> children);

		[Template("React.createElement('dialog', null, {0})")]
		public extern static ReactElement Dialog(ReactElement child);

		[Template("React.createElement('dialog', null, {0})")]
		public extern static ReactElement Dialog(string child);

		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Dialog(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Dialog<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Dialog<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Dialog(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Dialog(Attributes properties, ReactElement child);

		[Template("React.createElement('dialog', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Dialog(Attributes properties, string child);

		[Template("React.createElement('div', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Div(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('div', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Div(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('div', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Div<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('div', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Div<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('div', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Div(IEnumerable<string> children);

		[Template("React.createElement('div', null, {0})")]
		public extern static ReactElement Div(ReactElement child);

		[Template("React.createElement('div', null, {0})")]
		public extern static ReactElement Div(string child);

		[Template("React.createElement('div', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Div(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('div', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Div<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('div', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Div<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('div', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Div(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('div', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Div(Attributes properties, ReactElement child);

		[Template("React.createElement('div', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Div(Attributes properties, string child);

		[Template("React.createElement('dl', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement DL(DListAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('dl', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DL(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dl', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DL<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dl', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DL<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dl', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DL(IEnumerable<string> children);

		[Template("React.createElement('dl', null, {0})")]
		public extern static ReactElement DL(ReactElement child);

		[Template("React.createElement('dl', null, {0})")]
		public extern static ReactElement DL(string child);

		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DL(DListAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DL<TProps>(DListAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DL<TProps>(DListAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DL(DListAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DL(DListAttributes properties, ReactElement child);

		[Template("React.createElement('dl', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DL(DListAttributes properties, string child);

		[Template("React.createElement('dt', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement DT(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('dt', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DT(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dt', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DT<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dt', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement DT<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dt', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement DT(IEnumerable<string> children);

		[Template("React.createElement('dt', null, {0})")]
		public extern static ReactElement DT(ReactElement child);

		[Template("React.createElement('dt', null, {0})")]
		public extern static ReactElement DT(string child);

		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DT(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DT<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement DT<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement DT(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DT(Attributes properties, ReactElement child);

		[Template("React.createElement('dt', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement DT(Attributes properties, string child);

		[Template("React.createElement('em', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Em(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('em', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Em(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('em', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Em<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('em', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Em<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('em', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Em(IEnumerable<string> children);

		[Template("React.createElement('em', null, {0})")]
		public extern static ReactElement Em(ReactElement child);

		[Template("React.createElement('em', null, {0})")]
		public extern static ReactElement Em(string child);

		[Template("React.createElement('em', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Em(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('em', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Em<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('em', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Em<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('em', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Em(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('em', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Em(Attributes properties, ReactElement child);

		[Template("React.createElement('em', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Em(Attributes properties, string child);

		[Template("React.createElement('embed', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Embed(EmbedAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('embed', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Embed(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('embed', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Embed<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('embed', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Embed<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('embed', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Embed(IEnumerable<string> children);

		[Template("React.createElement('embed', null, {0})")]
		public extern static ReactElement Embed(ReactElement child);

		[Template("React.createElement('embed', null, {0})")]
		public extern static ReactElement Embed(string child);

		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Embed(EmbedAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Embed<TProps>(EmbedAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Embed<TProps>(EmbedAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Embed(EmbedAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, ReactElement child);

		[Template("React.createElement('embed', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Embed(EmbedAttributes properties, string child);

		[Template("React.createElement('fieldset', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('fieldset', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FieldSet(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('fieldset', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement FieldSet<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('fieldset', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement FieldSet<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('fieldset', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FieldSet(IEnumerable<string> children);

		[Template("React.createElement('fieldset', null, {0})")]
		public extern static ReactElement FieldSet(ReactElement child);

		[Template("React.createElement('fieldset', null, {0})")]
		public extern static ReactElement FieldSet(string child);

		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement FieldSet<TProps>(FieldSetAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement FieldSet<TProps>(FieldSetAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, ReactElement child);

		[Template("React.createElement('fieldset', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement FieldSet(FieldSetAttributes properties, string child);

		[Template("React.createElement('figcaption', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement FigCaption(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('figcaption', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FigCaption(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('figcaption', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement FigCaption<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('figcaption', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement FigCaption<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('figcaption', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement FigCaption(IEnumerable<string> children);

		[Template("React.createElement('figcaption', null, {0})")]
		public extern static ReactElement FigCaption(ReactElement child);

		[Template("React.createElement('figcaption', null, {0})")]
		public extern static ReactElement FigCaption(string child);

		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement FigCaption(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement FigCaption<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement FigCaption<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement FigCaption(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement FigCaption(Attributes properties, ReactElement child);

		[Template("React.createElement('figcaption', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement FigCaption(Attributes properties, string child);

		[Template("React.createElement('figure', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Figure(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('figure', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Figure(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('figure', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Figure<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('figure', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Figure<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('figure', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Figure(IEnumerable<string> children);

		[Template("React.createElement('figure', null, {0})")]
		public extern static ReactElement Figure(ReactElement child);

		[Template("React.createElement('figure', null, {0})")]
		public extern static ReactElement Figure(string child);

		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Figure(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Figure<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Figure<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Figure(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Figure(Attributes properties, ReactElement child);

		[Template("React.createElement('figure', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Figure(Attributes properties, string child);

		[Template("React.createElement('footer', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Footer(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('footer', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Footer(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('footer', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Footer<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('footer', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Footer<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('footer', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Footer(IEnumerable<string> children);

		[Template("React.createElement('footer', null, {0})")]
		public extern static ReactElement Footer(ReactElement child);

		[Template("React.createElement('footer', null, {0})")]
		public extern static ReactElement Footer(string child);

		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Footer(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Footer<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Footer<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Footer(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Footer(Attributes properties, ReactElement child);

		[Template("React.createElement('footer', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Footer(Attributes properties, string child);

		[Template("React.createElement('form', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Form(FormAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('form', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Form(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('form', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Form<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('form', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Form<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('form', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Form(IEnumerable<string> children);

		[Template("React.createElement('form', null, {0})")]
		public extern static ReactElement Form(ReactElement child);

		[Template("React.createElement('form', null, {0})")]
		public extern static ReactElement Form(string child);

		[Template("React.createElement('form', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Form(FormAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('form', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Form<TProps>(FormAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('form', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Form<TProps>(FormAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('form', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Form(FormAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('form', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Form(FormAttributes properties, ReactElement child);

		[Template("React.createElement('form', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Form(FormAttributes properties, string child);

		[Template("React.createElement('h1', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H1(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h1', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H1(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h1', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H1<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h1', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H1<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h1', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H1(IEnumerable<string> children);

		[Template("React.createElement('h1', null, {0})")]
		public extern static ReactElement H1(ReactElement child);

		[Template("React.createElement('h1', null, {0})")]
		public extern static ReactElement H1(string child);

		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H1(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H1<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H1<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H1(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H1(Attributes properties, ReactElement child);

		[Template("React.createElement('h1', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H1(Attributes properties, string child);

		[Template("React.createElement('h2', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H2(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h2', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H2(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h2', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H2<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h2', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H2<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h2', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H2(IEnumerable<string> children);

		[Template("React.createElement('h2', null, {0})")]
		public extern static ReactElement H2(ReactElement child);

		[Template("React.createElement('h2', null, {0})")]
		public extern static ReactElement H2(string child);

		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H2(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H2<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H2<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H2(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H2(Attributes properties, ReactElement child);

		[Template("React.createElement('h2', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H2(Attributes properties, string child);

		[Template("React.createElement('h3', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H3(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h3', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H3(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h3', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H3<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h3', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H3<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h3', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H3(IEnumerable<string> children);

		[Template("React.createElement('h3', null, {0})")]
		public extern static ReactElement H3(ReactElement child);

		[Template("React.createElement('h3', null, {0})")]
		public extern static ReactElement H3(string child);

		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H3(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H3<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H3<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H3(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H3(Attributes properties, ReactElement child);

		[Template("React.createElement('h3', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H3(Attributes properties, string child);

		[Template("React.createElement('h4', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H4(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h4', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H4(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h4', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H4<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h4', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H4<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h4', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H4(IEnumerable<string> children);

		[Template("React.createElement('h4', null, {0})")]
		public extern static ReactElement H4(ReactElement child);

		[Template("React.createElement('h4', null, {0})")]
		public extern static ReactElement H4(string child);

		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H4(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H4<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H4<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H4(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H4(Attributes properties, ReactElement child);

		[Template("React.createElement('h4', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H4(Attributes properties, string child);

		[Template("React.createElement('h5', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H5(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h5', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H5(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h5', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H5<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h5', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H5<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h5', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H5(IEnumerable<string> children);

		[Template("React.createElement('h5', null, {0})")]
		public extern static ReactElement H5(ReactElement child);

		[Template("React.createElement('h5', null, {0})")]
		public extern static ReactElement H5(string child);

		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H5(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H5<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H5<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H5(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H5(Attributes properties, ReactElement child);

		[Template("React.createElement('h5', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H5(Attributes properties, string child);

		[Template("React.createElement('h6', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement H6(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('h6', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H6(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h6', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H6<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h6', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement H6<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h6', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement H6(IEnumerable<string> children);

		[Template("React.createElement('h6', null, {0})")]
		public extern static ReactElement H6(ReactElement child);

		[Template("React.createElement('h6', null, {0})")]
		public extern static ReactElement H6(string child);

		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H6(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H6<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement H6<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement H6(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H6(Attributes properties, ReactElement child);

		[Template("React.createElement('h6', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement H6(Attributes properties, string child);

		[Template("React.createElement('head', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Head(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('head', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Head(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('head', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Head<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('head', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Head<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('head', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Head(IEnumerable<string> children);

		[Template("React.createElement('head', null, {0})")]
		public extern static ReactElement Head(ReactElement child);

		[Template("React.createElement('head', null, {0})")]
		public extern static ReactElement Head(string child);

		[Template("React.createElement('head', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Head(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('head', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Head<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('head', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Head<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('head', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Head(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('head', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Head(Attributes properties, ReactElement child);

		[Template("React.createElement('head', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Head(Attributes properties, string child);

		[Template("React.createElement('header', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Header(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('header', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Header(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('header', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Header<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('header', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Header<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('header', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Header(IEnumerable<string> children);

		[Template("React.createElement('header', null, {0})")]
		public extern static ReactElement Header(ReactElement child);

		[Template("React.createElement('header', null, {0})")]
		public extern static ReactElement Header(string child);

		[Template("React.createElement('header', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Header(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('header', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Header<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('header', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Header<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('header', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Header(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('header', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Header(Attributes properties, ReactElement child);

		[Template("React.createElement('header', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Header(Attributes properties, string child);

		[Template("React.createElement('hgroup', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement HGroup(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('hgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement HGroup(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('hgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement HGroup<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('hgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement HGroup<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('hgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement HGroup(IEnumerable<string> children);

		[Template("React.createElement('hgroup', null, {0})")]
		public extern static ReactElement HGroup(ReactElement child);

		[Template("React.createElement('hgroup', null, {0})")]
		public extern static ReactElement HGroup(string child);

		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement HGroup(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement HGroup<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement HGroup<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement HGroup(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement HGroup(Attributes properties, ReactElement child);

		[Template("React.createElement('hgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement HGroup(Attributes properties, string child);

		[Template("React.createElement('hr', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Hr(HRAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('hr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Hr(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('hr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Hr<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('hr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Hr<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('hr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Hr(IEnumerable<string> children);

		[Template("React.createElement('hr', null, {0})")]
		public extern static ReactElement Hr(ReactElement child);

		[Template("React.createElement('hr', null, {0})")]
		public extern static ReactElement Hr(string child);

		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Hr(HRAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Hr<TProps>(HRAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Hr<TProps>(HRAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Hr(HRAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Hr(HRAttributes properties, ReactElement child);

		[Template("React.createElement('hr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Hr(HRAttributes properties, string child);

		[Template("React.createElement('html', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Html(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('html', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Html(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('html', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Html<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('html', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Html<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('html', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Html(IEnumerable<string> children);

		[Template("React.createElement('html', null, {0})")]
		public extern static ReactElement Html(ReactElement child);

		[Template("React.createElement('html', null, {0})")]
		public extern static ReactElement Html(string child);

		[Template("React.createElement('html', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Html(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('html', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Html<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('html', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Html<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('html', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Html(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('html', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Html(Attributes properties, ReactElement child);

		[Template("React.createElement('html', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Html(Attributes properties, string child);

		[Template("React.createElement('i', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement I(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('i', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement I(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('i', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement I<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('i', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement I<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('i', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement I(IEnumerable<string> children);

		[Template("React.createElement('i', null, {0})")]
		public extern static ReactElement I(ReactElement child);

		[Template("React.createElement('i', null, {0})")]
		public extern static ReactElement I(string child);

		[Template("React.createElement('i', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement I(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('i', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement I<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('i', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement I<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('i', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement I(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('i', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement I(Attributes properties, ReactElement child);

		[Template("React.createElement('i', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement I(Attributes properties, string child);

		[Template("React.createElement('iframe', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('iframe', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement IFrame(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('iframe', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement IFrame<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('iframe', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement IFrame<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('iframe', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement IFrame(IEnumerable<string> children);

		[Template("React.createElement('iframe', null, {0})")]
		public extern static ReactElement IFrame(ReactElement child);

		[Template("React.createElement('iframe', null, {0})")]
		public extern static ReactElement IFrame(string child);

		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement IFrame(IFrameAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement IFrame<TProps>(IFrameAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement IFrame<TProps>(IFrameAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement IFrame(IFrameAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, ReactElement child);

		[Template("React.createElement('iframe', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement IFrame(IFrameAttributes properties, string child);

		[Template("React.createElement('img', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Img(ImageAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('img', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Img(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('img', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Img<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('img', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Img<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('img', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Img(IEnumerable<string> children);

		[Template("React.createElement('img', null, {0})")]
		public extern static ReactElement Img(ReactElement child);

		[Template("React.createElement('img', null, {0})")]
		public extern static ReactElement Img(string child);

		[Template("React.createElement('img', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Img(ImageAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('img', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Img<TProps>(ImageAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('img', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Img<TProps>(ImageAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('img', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Img(ImageAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('img', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Img(ImageAttributes properties, ReactElement child);

		[Template("React.createElement('img', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Img(ImageAttributes properties, string child);

		[Template("React.createElement('input', Bridge.React.fixAttr({properties}))")]
		public extern static ReactElement Input(InputAttributes properties);

		[Template("React.createElement('ins', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Ins(InsAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('ins', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ins(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ins', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Ins<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ins', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Ins<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ins', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ins(IEnumerable<string> children);

		[Template("React.createElement('ins', null, {0})")]
		public extern static ReactElement Ins(ReactElement child);

		[Template("React.createElement('ins', null, {0})")]
		public extern static ReactElement Ins(string child);

		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Ins(InsAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Ins<TProps>(InsAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Ins<TProps>(InsAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Ins(InsAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Ins(InsAttributes properties, ReactElement child);

		[Template("React.createElement('ins', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Ins(InsAttributes properties, string child);

		[Template("React.createElement('kbd', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Kbd(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('kbd', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Kbd(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('kbd', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Kbd<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('kbd', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Kbd<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('kbd', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Kbd(IEnumerable<string> children);

		[Template("React.createElement('kbd', null, {0})")]
		public extern static ReactElement Kbd(ReactElement child);

		[Template("React.createElement('kbd', null, {0})")]
		public extern static ReactElement Kbd(string child);

		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Kbd(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Kbd<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Kbd<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Kbd(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Kbd(Attributes properties, ReactElement child);

		[Template("React.createElement('kbd', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Kbd(Attributes properties, string child);

		[Template("React.createElement('keygen', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('keygen', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Keygen(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('keygen', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Keygen<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('keygen', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Keygen<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('keygen', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Keygen(IEnumerable<string> children);

		[Template("React.createElement('keygen', null, {0})")]
		public extern static ReactElement Keygen(ReactElement child);

		[Template("React.createElement('keygen', null, {0})")]
		public extern static ReactElement Keygen(string child);

		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Keygen(KeygenAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Keygen<TProps>(KeygenAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Keygen<TProps>(KeygenAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Keygen(KeygenAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, ReactElement child);

		[Template("React.createElement('keygen', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Keygen(KeygenAttributes properties, string child);

		[Template("React.createElement('label', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Label(LabelAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('label', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Label(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('label', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Label<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('label', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Label<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('label', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Label(IEnumerable<string> children);

		[Template("React.createElement('label', null, {0})")]
		public extern static ReactElement Label(ReactElement child);

		[Template("React.createElement('label', null, {0})")]
		public extern static ReactElement Label(string child);

		[Template("React.createElement('label', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Label(LabelAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('label', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Label<TProps>(LabelAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('label', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Label<TProps>(LabelAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('label', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Label(LabelAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('label', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Label(LabelAttributes properties, ReactElement child);

		[Template("React.createElement('label', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Label(LabelAttributes properties, string child);

		[Template("React.createElement('legend', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Legend(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('legend', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Legend(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('legend', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Legend<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('legend', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Legend<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('legend', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Legend(IEnumerable<string> children);

		[Template("React.createElement('legend', null, {0})")]
		public extern static ReactElement Legend(ReactElement child);

		[Template("React.createElement('legend', null, {0})")]
		public extern static ReactElement Legend(string child);

		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Legend(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Legend<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Legend<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Legend(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Legend(Attributes properties, ReactElement child);

		[Template("React.createElement('legend', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Legend(Attributes properties, string child);

		[Template("React.createElement('li', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Li(LIAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('li', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Li(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('li', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Li<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('li', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Li<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('li', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Li(IEnumerable<string> children);

		[Template("React.createElement('li', null, {0})")]
		public extern static ReactElement Li(ReactElement child);

		[Template("React.createElement('li', null, {0})")]
		public extern static ReactElement Li(string child);

		[Template("React.createElement('li', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Li(LIAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('li', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Li<TProps>(LIAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('li', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Li<TProps>(LIAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('li', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Li(LIAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('li', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Li(LIAttributes properties, ReactElement child);

		[Template("React.createElement('li', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Li(LIAttributes properties, string child);

		[Template("React.createElement('link', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Link(LinkAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('link', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Link(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('link', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Link<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('link', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Link<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('link', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Link(IEnumerable<string> children);

		[Template("React.createElement('link', null, {0})")]
		public extern static ReactElement Link(ReactElement child);

		[Template("React.createElement('link', null, {0})")]
		public extern static ReactElement Link(string child);

		[Template("React.createElement('link', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Link(LinkAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('link', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Link<TProps>(LinkAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('link', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Link<TProps>(LinkAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('link', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Link(LinkAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('link', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Link(LinkAttributes properties, ReactElement child);

		[Template("React.createElement('link', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Link(LinkAttributes properties, string child);

#pragma warning disable 28 // Disable warning CS0028: 'Bridge.React.DOM.Main(Bridge.React.Attributes, params Bridge.React.Union<ReactElement, string>[])' has the wrong signature to be an entry point
		[Template("React.createElement('main', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Main(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('main', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Main(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('main', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Main<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('main', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Main<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('main', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Main(IEnumerable<string> children);

		[Template("React.createElement('main', null, {0})")]
		public extern static ReactElement Main(ReactElement child);

		[Template("React.createElement('main', null, {0})")]
		public extern static ReactElement Main(string child);

		[Template("React.createElement('main', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Main(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('main', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Main<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('main', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Main<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('main', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Main(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('main', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Main(Attributes properties, ReactElement child);

		[Template("React.createElement('main', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Main(Attributes properties, string child);
#pragma warning restore 28

		[Template("React.createElement('map', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Map(MapAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('map', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Map(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('map', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Map<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('map', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Map<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('map', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Map(IEnumerable<string> children);

		[Template("React.createElement('map', null, {0})")]
		public extern static ReactElement Map(ReactElement child);

		[Template("React.createElement('map', null, {0})")]
		public extern static ReactElement Map(string child);

		[Template("React.createElement('map', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Map(MapAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('map', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Map<TProps>(MapAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('map', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Map<TProps>(MapAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('map', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Map(MapAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('map', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Map(MapAttributes properties, ReactElement child);

		[Template("React.createElement('map', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Map(MapAttributes properties, string child);

		[Template("React.createElement('mark', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Mark(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('mark', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Mark(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('mark', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Mark<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('mark', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Mark<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('mark', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Mark(IEnumerable<string> children);

		[Template("React.createElement('mark', null, {0})")]
		public extern static ReactElement Mark(ReactElement child);

		[Template("React.createElement('mark', null, {0})")]
		public extern static ReactElement Mark(string child);

		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Mark(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Mark<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Mark<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Mark(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Mark(Attributes properties, ReactElement child);

		[Template("React.createElement('mark', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Mark(Attributes properties, string child);

		[Template("React.createElement('menu', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Menu(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('menu', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Menu(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('menu', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Menu<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('menu', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Menu<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('menu', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Menu(IEnumerable<string> children);

		[Template("React.createElement('menu', null, {0})")]
		public extern static ReactElement Menu(ReactElement child);

		[Template("React.createElement('menu', null, {0})")]
		public extern static ReactElement Menu(string child);

		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Menu(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Menu<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Menu<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Menu(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Menu(Attributes properties, ReactElement child);

		[Template("React.createElement('menu', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Menu(Attributes properties, string child);

		[Template("React.createElement('menuitem', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement MenuItem(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('menuitem', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement MenuItem(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('menuitem', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement MenuItem<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('menuitem', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement MenuItem<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('menuitem', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement MenuItem(IEnumerable<string> children);

		[Template("React.createElement('menuitem', null, {0})")]
		public extern static ReactElement MenuItem(ReactElement child);

		[Template("React.createElement('menuitem', null, {0})")]
		public extern static ReactElement MenuItem(string child);

		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement MenuItem(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement MenuItem<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement MenuItem<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement MenuItem(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement MenuItem(Attributes properties, ReactElement child);

		[Template("React.createElement('menuitem', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement MenuItem(Attributes properties, string child);

		[Template("React.createElement('meta', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Meta(MetaAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('meta', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meta(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('meta', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Meta<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('meta', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Meta<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('meta', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meta(IEnumerable<string> children);

		[Template("React.createElement('meta', null, {0})")]
		public extern static ReactElement Meta(ReactElement child);

		[Template("React.createElement('meta', null, {0})")]
		public extern static ReactElement Meta(string child);

		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Meta(MetaAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Meta<TProps>(MetaAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Meta<TProps>(MetaAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Meta(MetaAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, ReactElement child);

		[Template("React.createElement('meta', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Meta(MetaAttributes properties, string child);

		[Template("React.createElement('meter', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Meter(MeterAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('meter', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meter(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('meter', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Meter<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('meter', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Meter<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('meter', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Meter(IEnumerable<string> children);

		[Template("React.createElement('meter', null, {0})")]
		public extern static ReactElement Meter(ReactElement child);

		[Template("React.createElement('meter', null, {0})")]
		public extern static ReactElement Meter(string child);

		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Meter(MeterAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Meter<TProps>(MeterAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Meter<TProps>(MeterAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Meter(MeterAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, ReactElement child);

		[Template("React.createElement('meter', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Meter(MeterAttributes properties, string child);

		[Template("React.createElement('nav', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Nav(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('nav', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Nav(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('nav', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Nav<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('nav', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Nav<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('nav', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Nav(IEnumerable<string> children);

		[Template("React.createElement('nav', null, {0})")]
		public extern static ReactElement Nav(ReactElement child);

		[Template("React.createElement('nav', null, {0})")]
		public extern static ReactElement Nav(string child);

		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Nav(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Nav<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Nav<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Nav(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Nav(Attributes properties, ReactElement child);

		[Template("React.createElement('nav', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Nav(Attributes properties, string child);

		[Template("React.createElement('noscript', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement NoScript(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('noscript', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement NoScript(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('noscript', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement NoScript<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('noscript', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement NoScript<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('noscript', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement NoScript(IEnumerable<string> children);

		[Template("React.createElement('noscript', null, {0})")]
		public extern static ReactElement NoScript(ReactElement child);

		[Template("React.createElement('noscript', null, {0})")]
		public extern static ReactElement NoScript(string child);

		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement NoScript(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement NoScript<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement NoScript<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement NoScript(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement NoScript(Attributes properties, ReactElement child);

		[Template("React.createElement('noscript', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement NoScript(Attributes properties, string child);

		[Template("React.createElement('object', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Object(ObjectAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('object', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Object(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('object', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Object<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('object', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Object<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('object', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Object(IEnumerable<string> children);

		[Template("React.createElement('object', null, {0})")]
		public extern static ReactElement Object(ReactElement child);

		[Template("React.createElement('object', null, {0})")]
		public extern static ReactElement Object(string child);

		[Template("React.createElement('object', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Object(ObjectAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('object', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Object<TProps>(ObjectAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('object', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Object<TProps>(ObjectAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('object', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Object(ObjectAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('object', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, ReactElement child);

		[Template("React.createElement('object', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Object(ObjectAttributes properties, string child);

		[Template("React.createElement('ol', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement OL(OListAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('ol', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OL(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ol', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement OL<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ol', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement OL<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ol', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OL(IEnumerable<string> children);

		[Template("React.createElement('ol', null, {0})")]
		public extern static ReactElement OL(ReactElement child);

		[Template("React.createElement('ol', null, {0})")]
		public extern static ReactElement OL(string child);

		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement OL(OListAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement OL<TProps>(OListAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement OL<TProps>(OListAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement OL(OListAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement OL(OListAttributes properties, ReactElement child);

		[Template("React.createElement('ol', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement OL(OListAttributes properties, string child);

		[Template("React.createElement('optgroup', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('optgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OptGroup(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('optgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement OptGroup<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('optgroup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement OptGroup<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('optgroup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement OptGroup(IEnumerable<string> children);

		[Template("React.createElement('optgroup', null, {0})")]
		public extern static ReactElement OptGroup(ReactElement child);

		[Template("React.createElement('optgroup', null, {0})")]
		public extern static ReactElement OptGroup(string child);

		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement OptGroup<TProps>(OptGroupAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement OptGroup<TProps>(OptGroupAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, ReactElement child);

		[Template("React.createElement('optgroup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement OptGroup(OptGroupAttributes properties, string child);

		[Template("React.createElement('option', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Option(OptionAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('option', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Option(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('option', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Option<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('option', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Option<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('option', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Option(IEnumerable<string> children);

		[Template("React.createElement('option', null, {0})")]
		public extern static ReactElement Option(ReactElement child);

		[Template("React.createElement('option', null, {0})")]
		public extern static ReactElement Option(string child);

		[Template("React.createElement('option', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Option(OptionAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('option', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Option<TProps>(OptionAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('option', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Option<TProps>(OptionAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('option', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Option(OptionAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('option', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Option(OptionAttributes properties, ReactElement child);

		[Template("React.createElement('option', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Option(OptionAttributes properties, string child);

		[Template("React.createElement('output', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Output(OutputAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('output', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Output(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('output', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Output<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('output', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Output<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('output', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Output(IEnumerable<string> children);

		[Template("React.createElement('output', null, {0})")]
		public extern static ReactElement Output(ReactElement child);

		[Template("React.createElement('output', null, {0})")]
		public extern static ReactElement Output(string child);

		[Template("React.createElement('output', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Output(OutputAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('output', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Output<TProps>(OutputAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('output', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Output<TProps>(OutputAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('output', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Output(OutputAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('output', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Output(OutputAttributes properties, ReactElement child);

		[Template("React.createElement('output', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Output(OutputAttributes properties, string child);

		[Template("React.createElement('p', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement P(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('p', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement P(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('p', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement P<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('p', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement P<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('p', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement P(IEnumerable<string> children);

		[Template("React.createElement('p', null, {0})")]
		public extern static ReactElement P(ReactElement child);

		[Template("React.createElement('p', null, {0})")]
		public extern static ReactElement P(string child);

		[Template("React.createElement('p', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement P(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('p', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement P<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('p', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement P<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('p', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement P(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('p', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement P(Attributes properties, ReactElement child);

		[Template("React.createElement('p', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement P(Attributes properties, string child);

		[Template("React.createElement('param', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Param(ParamAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('param', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Param(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('param', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Param<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('param', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Param<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('param', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Param(IEnumerable<string> children);

		[Template("React.createElement('param', null, {0})")]
		public extern static ReactElement Param(ReactElement child);

		[Template("React.createElement('param', null, {0})")]
		public extern static ReactElement Param(string child);

		[Template("React.createElement('param', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Param(ParamAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('param', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Param<TProps>(ParamAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('param', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Param<TProps>(ParamAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('param', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Param(ParamAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('param', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Param(ParamAttributes properties, ReactElement child);

		[Template("React.createElement('param', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Param(ParamAttributes properties, string child);

		[Template("React.createElement('picture', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Picture(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('picture', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Picture(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('picture', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Picture<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('picture', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Picture<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('picture', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Picture(IEnumerable<string> children);

		[Template("React.createElement('picture', null, {0})")]
		public extern static ReactElement Picture(ReactElement child);

		[Template("React.createElement('picture', null, {0})")]
		public extern static ReactElement Picture(string child);

		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Picture(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Picture<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Picture<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Picture(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Picture(Attributes properties, ReactElement child);

		[Template("React.createElement('picture', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Picture(Attributes properties, string child);

		[Template("React.createElement('pre', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Pre(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('pre', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Pre(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('pre', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Pre<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('pre', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Pre<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('pre', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Pre(IEnumerable<string> children);

		[Template("React.createElement('pre', null, {0})")]
		public extern static ReactElement Pre(ReactElement child);

		[Template("React.createElement('pre', null, {0})")]
		public extern static ReactElement Pre(string child);

		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Pre(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Pre<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Pre<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Pre(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Pre(Attributes properties, ReactElement child);

		[Template("React.createElement('pre', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Pre(Attributes properties, string child);

		[Template("React.createElement('progress', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Progress(ProgressAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('progress', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Progress(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('progress', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Progress<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('progress', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Progress<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('progress', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Progress(IEnumerable<string> children);

		[Template("React.createElement('progress', null, {0})")]
		public extern static ReactElement Progress(ReactElement child);

		[Template("React.createElement('progress', null, {0})")]
		public extern static ReactElement Progress(string child);

		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Progress(ProgressAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Progress<TProps>(ProgressAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Progress<TProps>(ProgressAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Progress(ProgressAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, ReactElement child);

		[Template("React.createElement('progress', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Progress(ProgressAttributes properties, string child);

		[Template("React.createElement('q', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Q(QuoteAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('q', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Q(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('q', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Q<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('q', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Q<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('q', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Q(IEnumerable<string> children);

		[Template("React.createElement('q', null, {0})")]
		public extern static ReactElement Q(ReactElement child);

		[Template("React.createElement('q', null, {0})")]
		public extern static ReactElement Q(string child);

		[Template("React.createElement('q', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Q(QuoteAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('q', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Q<TProps>(QuoteAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('q', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Q<TProps>(QuoteAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('q', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Q(QuoteAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('q', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, ReactElement child);

		[Template("React.createElement('q', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Q(QuoteAttributes properties, string child);

		[Template("React.createElement('rp', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement RP(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('rp', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RP(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('rp', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement RP<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('rp', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement RP<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('rp', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RP(IEnumerable<string> children);

		[Template("React.createElement('rp', null, {0})")]
		public extern static ReactElement RP(ReactElement child);

		[Template("React.createElement('rp', null, {0})")]
		public extern static ReactElement RP(string child);

		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement RP(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement RP<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement RP<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement RP(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement RP(Attributes properties, ReactElement child);

		[Template("React.createElement('rp', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement RP(Attributes properties, string child);

		[Template("React.createElement('rt', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement RT(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('rt', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RT(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('rt', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement RT<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('rt', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement RT<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('rt', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement RT(IEnumerable<string> children);

		[Template("React.createElement('rt', null, {0})")]
		public extern static ReactElement RT(ReactElement child);

		[Template("React.createElement('rt', null, {0})")]
		public extern static ReactElement RT(string child);

		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement RT(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement RT<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement RT<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement RT(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement RT(Attributes properties, ReactElement child);

		[Template("React.createElement('rt', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement RT(Attributes properties, string child);

		[Template("React.createElement('ruby', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Ruby(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('ruby', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ruby(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ruby', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Ruby<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ruby', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Ruby<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ruby', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Ruby(IEnumerable<string> children);

		[Template("React.createElement('ruby', null, {0})")]
		public extern static ReactElement Ruby(ReactElement child);

		[Template("React.createElement('ruby', null, {0})")]
		public extern static ReactElement Ruby(string child);

		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Ruby(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Ruby<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Ruby<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Ruby(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Ruby(Attributes properties, ReactElement child);

		[Template("React.createElement('ruby', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Ruby(Attributes properties, string child);

		[Template("React.createElement('s', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement S(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('s', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement S(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('s', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement S<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('s', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement S<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('s', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement S(IEnumerable<string> children);

		[Template("React.createElement('s', null, {0})")]
		public extern static ReactElement S(ReactElement child);

		[Template("React.createElement('s', null, {0})")]
		public extern static ReactElement S(string child);

		[Template("React.createElement('s', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement S(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('s', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement S<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('s', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement S<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('s', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement S(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('s', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement S(Attributes properties, ReactElement child);

		[Template("React.createElement('s', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement S(Attributes properties, string child);

		[Template("React.createElement('samp', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Samp(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('samp', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Samp(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('samp', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Samp<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('samp', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Samp<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('samp', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Samp(IEnumerable<string> children);

		[Template("React.createElement('samp', null, {0})")]
		public extern static ReactElement Samp(ReactElement child);

		[Template("React.createElement('samp', null, {0})")]
		public extern static ReactElement Samp(string child);

		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Samp(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Samp<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Samp<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Samp(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Samp(Attributes properties, ReactElement child);

		[Template("React.createElement('samp', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Samp(Attributes properties, string child);

		[Template("React.createElement('script', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Script(ScriptAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('script', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Script(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('script', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Script<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('script', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Script<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('script', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Script(IEnumerable<string> children);

		[Template("React.createElement('script', null, {0})")]
		public extern static ReactElement Script(ReactElement child);

		[Template("React.createElement('script', null, {0})")]
		public extern static ReactElement Script(string child);

		[Template("React.createElement('script', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Script(ScriptAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('script', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Script<TProps>(ScriptAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('script', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Script<TProps>(ScriptAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('script', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Script(ScriptAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('script', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, ReactElement child);

		[Template("React.createElement('script', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Script(ScriptAttributes properties, string child);

		[Template("React.createElement('section', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Section(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('section', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Section(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('section', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Section<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('section', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Section<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('section', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Section(IEnumerable<string> children);

		[Template("React.createElement('section', null, {0})")]
		public extern static ReactElement Section(ReactElement child);

		[Template("React.createElement('section', null, {0})")]
		public extern static ReactElement Section(string child);

		[Template("React.createElement('section', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Section(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('section', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Section<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('section', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Section<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('section', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Section(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('section', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Section(Attributes properties, ReactElement child);

		[Template("React.createElement('section', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Section(Attributes properties, string child);

		[Template("React.createElement('select', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Select(SelectAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('select', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Select(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('select', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Select<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('select', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Select<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('select', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Select(IEnumerable<string> children);

		[Template("React.createElement('select', null, {0})")]
		public extern static ReactElement Select(ReactElement child);

		[Template("React.createElement('select', null, {0})")]
		public extern static ReactElement Select(string child);

		[Template("React.createElement('select', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Select(SelectAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('select', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Select<TProps>(SelectAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('select', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Select<TProps>(SelectAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('select', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Select(SelectAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('select', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Select(SelectAttributes properties, ReactElement child);

		[Template("React.createElement('select', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Select(SelectAttributes properties, string child);

		[Template("React.createElement('small', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Small(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('small', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Small(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('small', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Small<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('small', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Small<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('small', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Small(IEnumerable<string> children);

		[Template("React.createElement('small', null, {0})")]
		public extern static ReactElement Small(ReactElement child);

		[Template("React.createElement('small', null, {0})")]
		public extern static ReactElement Small(string child);

		[Template("React.createElement('small', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Small(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('small', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Small<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('small', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Small<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('small', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Small(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('small', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Small(Attributes properties, ReactElement child);

		[Template("React.createElement('small', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Small(Attributes properties, string child);

		[Template("React.createElement('source', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Source(SourceAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('source', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Source(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('source', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Source<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('source', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Source<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('source', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Source(IEnumerable<string> children);

		[Template("React.createElement('source', null, {0})")]
		public extern static ReactElement Source(ReactElement child);

		[Template("React.createElement('source', null, {0})")]
		public extern static ReactElement Source(string child);

		[Template("React.createElement('source', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Source(SourceAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('source', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Source<TProps>(SourceAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('source', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Source<TProps>(SourceAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('source', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Source(SourceAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('source', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Source(SourceAttributes properties, ReactElement child);

		[Template("React.createElement('source', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Source(SourceAttributes properties, string child);

		[Template("React.createElement('span', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Span(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('span', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Span(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('span', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Span<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('span', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Span<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('span', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Span(IEnumerable<string> children);

		[Template("React.createElement('span', null, {0})")]
		public extern static ReactElement Span(ReactElement child);

		[Template("React.createElement('span', null, {0})")]
		public extern static ReactElement Span(string child);

		[Template("React.createElement('span', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Span(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('span', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Span<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('span', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Span<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('span', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Span(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('span', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Span(Attributes properties, ReactElement child);

		[Template("React.createElement('span', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Span(Attributes properties, string child);

		[Template("React.createElement('strong', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Strong(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('strong', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Strong(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('strong', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Strong<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('strong', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Strong<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('strong', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Strong(IEnumerable<string> children);

		[Template("React.createElement('strong', null, {0})")]
		public extern static ReactElement Strong(ReactElement child);

		[Template("React.createElement('strong', null, {0})")]
		public extern static ReactElement Strong(string child);

		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Strong(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Strong<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Strong<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Strong(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Strong(Attributes properties, ReactElement child);

		[Template("React.createElement('strong', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Strong(Attributes properties, string child);

		[Template("React.createElement('style', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Style(StyleAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('style', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Style(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('style', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Style<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('style', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Style<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('style', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Style(IEnumerable<string> children);

		[Template("React.createElement('style', null, {0})")]
		public extern static ReactElement Style(ReactElement child);

		[Template("React.createElement('style', null, {0})")]
		public extern static ReactElement Style(string child);

		[Template("React.createElement('style', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Style(StyleAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('style', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Style<TProps>(StyleAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('style', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Style<TProps>(StyleAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('style', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Style(StyleAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('style', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Style(StyleAttributes properties, ReactElement child);

		[Template("React.createElement('style', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Style(StyleAttributes properties, string child);

		[Template("React.createElement('sub', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Sub(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('sub', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sub(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('sub', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Sub<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('sub', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Sub<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('sub', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sub(IEnumerable<string> children);

		[Template("React.createElement('sub', null, {0})")]
		public extern static ReactElement Sub(ReactElement child);

		[Template("React.createElement('sub', null, {0})")]
		public extern static ReactElement Sub(string child);

		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Sub(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Sub<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Sub<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Sub(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Sub(Attributes properties, ReactElement child);

		[Template("React.createElement('sub', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Sub(Attributes properties, string child);

		[Template("React.createElement('summary', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Summary(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('summary', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Summary(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('summary', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Summary<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('summary', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Summary<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('summary', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Summary(IEnumerable<string> children);

		[Template("React.createElement('summary', null, {0})")]
		public extern static ReactElement Summary(ReactElement child);

		[Template("React.createElement('summary', null, {0})")]
		public extern static ReactElement Summary(string child);

		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Summary(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Summary<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Summary<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Summary(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Summary(Attributes properties, ReactElement child);

		[Template("React.createElement('summary', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Summary(Attributes properties, string child);

		[Template("React.createElement('sup', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Sup(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('sup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sup(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('sup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Sup<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('sup', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Sup<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('sup', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Sup(IEnumerable<string> children);

		[Template("React.createElement('sup', null, {0})")]
		public extern static ReactElement Sup(ReactElement child);

		[Template("React.createElement('sup', null, {0})")]
		public extern static ReactElement Sup(string child);

		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Sup(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Sup<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Sup<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Sup(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Sup(Attributes properties, ReactElement child);

		[Template("React.createElement('sup', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Sup(Attributes properties, string child);

		[Template("React.createElement('table', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Table(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('table', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Table(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('table', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Table<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('table', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Table<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('table', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Table(IEnumerable<string> children);

		[Template("React.createElement('table', null, {0})")]
		public extern static ReactElement Table(ReactElement child);

		[Template("React.createElement('table', null, {0})")]
		public extern static ReactElement Table(string child);

		[Template("React.createElement('table', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Table(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('table', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Table<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('table', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Table<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('table', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Table(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('table', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Table(Attributes properties, ReactElement child);

		[Template("React.createElement('table', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Table(Attributes properties, string child);

		[Template("React.createElement('tbody', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement TBody(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('tbody', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TBody(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tbody', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TBody<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tbody', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TBody<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tbody', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TBody(IEnumerable<string> children);

		[Template("React.createElement('tbody', null, {0})")]
		public extern static ReactElement TBody(ReactElement child);

		[Template("React.createElement('tbody', null, {0})")]
		public extern static ReactElement TBody(string child);

		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TBody(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TBody<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TBody<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TBody(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TBody(Attributes properties, ReactElement child);

		[Template("React.createElement('tbody', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TBody(Attributes properties, string child);

		[Template("React.createElement('td', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement TD(TableCellAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('td', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TD(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('td', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TD<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('td', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TD<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('td', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TD(IEnumerable<string> children);

		[Template("React.createElement('td', null, {0})")]
		public extern static ReactElement TD(ReactElement child);

		[Template("React.createElement('td', null, {0})")]
		public extern static ReactElement TD(string child);

		[Template("React.createElement('td', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TD(TableCellAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('td', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TD<TProps>(TableCellAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('td', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TD<TProps>(TableCellAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('td', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TD(TableCellAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('td', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, ReactElement child);

		[Template("React.createElement('td', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TD(TableCellAttributes properties, string child);

		/// <summary>
		/// A TextArea's contents should be set using the Value property, rather than children (React includes a warning if TextArea contents are set using children and so this is not allowed with these bindings)
		/// </summary>
		[Template("React.createElement('textarea', Bridge.React.fixAttr({properties}))")]
		public extern static ReactElement TextArea(TextAreaAttributes properties);

		/// <summary>
		/// A TextArea's contents should be set using the Value property on a TextAreaAttributes instance, rather than children (React includes a warning if TextArea contents are set using children and so this is
		/// not allowed with these bindings)
		/// </summary>
		[Template("React.createElement('textarea', null)")]
		public extern static ReactElement TextArea();

		[Template("React.createElement('tfoot', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement TFoot(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('tfoot', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TFoot(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tfoot', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TFoot<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tfoot', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TFoot<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tfoot', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TFoot(IEnumerable<string> children);

		[Template("React.createElement('tfoot', null, {0})")]
		public extern static ReactElement TFoot(ReactElement child);

		[Template("React.createElement('tfoot', null, {0})")]
		public extern static ReactElement TFoot(string child);

		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TFoot(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TFoot<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TFoot<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TFoot(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TFoot(Attributes properties, ReactElement child);

		[Template("React.createElement('tfoot', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TFoot(Attributes properties, string child);

		[Template("React.createElement('th', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement TH(TableCellAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('th', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TH(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('th', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TH<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('th', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TH<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('th', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TH(IEnumerable<string> children);

		[Template("React.createElement('th', null, {0})")]
		public extern static ReactElement TH(ReactElement child);

		[Template("React.createElement('th', null, {0})")]
		public extern static ReactElement TH(string child);

		[Template("React.createElement('th', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TH(TableCellAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('th', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TH<TProps>(TableCellAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('th', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TH<TProps>(TableCellAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('th', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TH(TableCellAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('th', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, ReactElement child);

		[Template("React.createElement('th', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TH(TableCellAttributes properties, string child);

		[Template("React.createElement('thead', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement THead(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('thead', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement THead(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('thead', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement THead<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('thead', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement THead<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('thead', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement THead(IEnumerable<string> children);

		[Template("React.createElement('thead', null, {0})")]
		public extern static ReactElement THead(ReactElement child);

		[Template("React.createElement('thead', null, {0})")]
		public extern static ReactElement THead(string child);

		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement THead(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement THead<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement THead<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement THead(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement THead(Attributes properties, ReactElement child);

		[Template("React.createElement('thead', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement THead(Attributes properties, string child);

		[Template("React.createElement('time', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Time(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('time', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Time(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('time', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Time<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('time', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Time<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('time', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Time(IEnumerable<string> children);

		[Template("React.createElement('time', null, {0})")]
		public extern static ReactElement Time(ReactElement child);

		[Template("React.createElement('time', null, {0})")]
		public extern static ReactElement Time(string child);

		[Template("React.createElement('time', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Time(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('time', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Time<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('time', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Time<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('time', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Time(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('time', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Time(Attributes properties, ReactElement child);

		[Template("React.createElement('time', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Time(Attributes properties, string child);

		[Template("React.createElement('title', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Title(TitleAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('title', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Title(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('title', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Title<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('title', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Title<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('title', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Title(IEnumerable<string> children);

		[Template("React.createElement('title', null, {0})")]
		public extern static ReactElement Title(ReactElement child);

		[Template("React.createElement('title', null, {0})")]
		public extern static ReactElement Title(string child);

		[Template("React.createElement('title', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Title(TitleAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('title', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Title<TProps>(TitleAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('title', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Title<TProps>(TitleAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('title', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Title(TitleAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('title', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Title(TitleAttributes properties, ReactElement child);

		[Template("React.createElement('title', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Title(TitleAttributes properties, string child);

		[Template("React.createElement('tr', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement TR(TableCellAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('tr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TR(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TR<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement TR<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement TR(IEnumerable<string> children);

		[Template("React.createElement('tr', null, {0})")]
		public extern static ReactElement TR(ReactElement child);

		[Template("React.createElement('tr', null, {0})")]
		public extern static ReactElement TR(string child);

		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TR(TableCellAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TR<TProps>(TableCellAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement TR<TProps>(TableCellAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement TR(TableCellAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, ReactElement child);

		[Template("React.createElement('tr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement TR(TableCellAttributes properties, string child);

		[Template("React.createElement('track', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Track(TrackAttributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('track', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Track(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('track', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Track<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('track', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Track<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('track', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Track(IEnumerable<string> children);

		[Template("React.createElement('track', null, {0})")]
		public extern static ReactElement Track(ReactElement child);

		[Template("React.createElement('track', null, {0})")]
		public extern static ReactElement Track(string child);

		[Template("React.createElement('track', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Track(TrackAttributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('track', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Track<TProps>(TrackAttributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('track', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Track<TProps>(TrackAttributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('track', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Track(TrackAttributes properties, IEnumerable<string> children);

		[Template("React.createElement('track', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Track(TrackAttributes properties, ReactElement child);

		[Template("React.createElement('track', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Track(TrackAttributes properties, string child);

		[Template("React.createElement('u', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement U(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('u', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement U(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('u', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement U<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('u', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement U<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('u', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement U(IEnumerable<string> children);

		[Template("React.createElement('u', null, {0})")]
		public extern static ReactElement U(ReactElement child);

		[Template("React.createElement('u', null, {0})")]
		public extern static ReactElement U(string child);

		[Template("React.createElement('u', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement U(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('u', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement U<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('u', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement U<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('u', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement U(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('u', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement U(Attributes properties, ReactElement child);

		[Template("React.createElement('u', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement U(Attributes properties, string child);

		[Template("React.createElement('ul', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement UL(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('ul', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement UL(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ul', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement UL<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ul', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement UL<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ul', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement UL(IEnumerable<string> children);

		[Template("React.createElement('ul', null, {0})")]
		public extern static ReactElement UL(ReactElement child);

		[Template("React.createElement('ul', null, {0})")]
		public extern static ReactElement UL(string child);

		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement UL(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement UL<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement UL<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement UL(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement UL(Attributes properties, ReactElement child);

		[Template("React.createElement('ul', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement UL(Attributes properties, string child);

		[Template("React.createElement('Var', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Var(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('Var', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Var(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('Var', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Var<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('Var', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Var<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('Var', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Var(IEnumerable<string> children);

		[Template("React.createElement('Var', null, {0})")]
		public extern static ReactElement Var(ReactElement child);

		[Template("React.createElement('Var', null, {0})")]
		public extern static ReactElement Var(string child);

		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Var(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Var<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Var<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Var(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Var(Attributes properties, ReactElement child);

		[Template("React.createElement('Var', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Var(Attributes properties, string child);

		[Template("React.createElement('video', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement Video(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('video', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Video(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('video', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Video<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('video', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement Video<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('video', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement Video(IEnumerable<string> children);

		[Template("React.createElement('video', null, {0})")]
		public extern static ReactElement Video(ReactElement child);

		[Template("React.createElement('video', null, {0})")]
		public extern static ReactElement Video(string child);

		[Template("React.createElement('video', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Video(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('video', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Video<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('video', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement Video<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('video', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement Video(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('video', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Video(Attributes properties, ReactElement child);

		[Template("React.createElement('video', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement Video(Attributes properties, string child);

		[Template("React.createElement('wbr', Bridge.React.fixAttr({properties}), {*children})")]
		public extern static ReactElement WBR(Attributes properties, params Union<ReactElement, string>[] children);

		[Template("React.createElement('wbr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement WBR(IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('wbr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement WBR<TProps>(IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('wbr', null, Bridge.React.toReactElementArray({0}))")]
		public extern static ReactElement WBR<TProps>(IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('wbr', null, System.Linq.Enumerable.from({0}).toArray())")]
		public extern static ReactElement WBR(IEnumerable<string> children);

		[Template("React.createElement('wbr', null, {0})")]
		public extern static ReactElement WBR(ReactElement child);

		[Template("React.createElement('wbr', null, {0})")]
		public extern static ReactElement WBR(string child);

		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement WBR(Attributes properties, IEnumerable<ReactElement> children);

		[IgnoreGeneric]
		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement WBR<TProps>(Attributes properties, IEnumerable<PureComponent<TProps>> children);

		[IgnoreGeneric]
		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), Bridge.React.toReactElementArray({1}))")]
		public extern static ReactElement WBR<TProps>(Attributes properties, IEnumerable<StatelessComponent<TProps>> children);

		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), System.Linq.Enumerable.from({1}).toArray())")]
		public extern static ReactElement WBR(Attributes properties, IEnumerable<string> children);

		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement WBR(Attributes properties, ReactElement child);

		[Template("React.createElement('wbr', Bridge.React.fixAttr({0}), {1})")]
		public extern static ReactElement WBR(Attributes properties, string child);
	}
}
