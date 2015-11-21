using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class ButtonAttributes : DomElementWithEventsAttributes<ButtonElement>
    {
        [Name("autofocus")]
        public bool AutoFocus { private get; set; }
        public bool Disabled { private get; set; }
        public string FormAction { private get; set; }
        public string FormEncType { private get; set; }
        public string FormMethod { private get; set; }
        public bool FormNoValidate { private get; set; }
        public string FormTarget { private get; set; }
        public string Name { private get; set; }
        public ButtonType Type { private get; set; }
        public string Value { private get; set; }
    }
}
