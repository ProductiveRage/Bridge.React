using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class FieldSetAttributes : ReactDomElementAttributes<HTMLFieldSetElement>
    {
        public bool Disabled { private get; set; }
        public string Name { private get; set; }
        public bool WillValidate { private get; set; }
    }
}
