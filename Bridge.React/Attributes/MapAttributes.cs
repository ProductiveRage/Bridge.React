using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class MapAttributes : DomElementWithEventsAttributes<MapElement>
    {
        public string Name { private get; set; }
    }
}
