using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class EmbedAttributes : ReactDomElementAttributes<HTMLEmbedElement>
    {
        public int Height { private get; set; }
        public string Name { private get; set; }
        public string Src { private get; set; }
        public string Type { private get; set; }
        public string Width { private get; set; }
    }
}
