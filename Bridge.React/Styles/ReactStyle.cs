using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace Bridge.React
{
    /// <summary>
    /// This class defines the properties of the inline styles you can add to react elements
    /// </summary>
    [ObjectLiteral]
    public class ReactStyle : CSSStyleDeclaration
    { 
        public new Any<string, int> Height { get; set; }
        public new Any<string, int> Width { get; set; }
        public new Any<string, int> FontSize { get; set; }
        public new Any<string, int> BorderRadius { get; set; }
        public new Any<string, int> MinWidth { get; set; }
        public new Any<string, int> MaxWidth { get; set; }
        public new Any<string, int> MinHeight { get; set; }
        public new Any<string, int> MaxHeight { get; set; }
        public new Any<string, int> Margin { get; set; }
        public new Any<string, int> MarginLeft { get; set; }
        public new Any<string, int> MarginRight { get; set; }
        public new Any<string, int> MarginTop { get; set; }
        public new Any<string, int> MarginBottom { get; set; }
        public new Any<string, int> Padding { get; set; }
        public new Any<string, int> PaddingLeft { get; set; }
        public new Any<string, int> PaddingRight { get; set; }
        public new Any<string, int> PaddingTop { get; set; }
        public new Any<string, int> PaddingBottom { get; set; }
        public new Any<string, int> Top { get; set; }
        public new Any<string, int> Bottom { get; set; }
        public new Any<string, int> Left { get; set; }
        public new Any<string, int> Right { get; set; }
        public new Any<string, double> Opacity { get; set; }
        public Float Float { get; set; }
    }
}