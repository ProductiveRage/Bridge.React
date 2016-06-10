using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class MapAttributes : ReactDomElementAttributes<HTMLMapElement>
    {
        public string Name { private get; set; }
    }
}
