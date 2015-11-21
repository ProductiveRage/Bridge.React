using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class ObjectAttributes : DomElementWithEventsAttributes<ObjectElement>
    {
        public string Data { private get; set; }
        public int Height { private get; set; }
        public string Name { private get; set; }
        public string Type { private get; set; }
        public bool TypeMustMatch { private get; set; }
        public string useMap { private get; set; }
        public int Width { private get; set; }
        public bool WillValidate { private get; set; }
    }
}
