using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class SelectAttributes : ReactDomElementAttributes<SelectElement>
    {
        [Name("autofocus")]
        public bool AutoFocus { private get; set; }
        public bool Disabled { private get; set; }
        public int Length { private get; set; }
        public bool Multiple { private get; set; }
        public string Name { private get; set; }
        public bool Required { private get; set; }
        public int Size { private get; set; }
        public string Src { private get; set; }
        public string Type { private get; set; }
        public string Value { private get; set; }
    }
}
