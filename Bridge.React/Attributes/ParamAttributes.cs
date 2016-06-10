using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class ParamAttributes : ReactDomElementAttributes<HTMLParamElement>
    {
        public string Name { private get; set; }
    }
}
