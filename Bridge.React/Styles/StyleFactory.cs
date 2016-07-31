using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.React
{
    public static class Style
    {
        [Template("Object.assign(JSON.parse(JSON.stringify({0})), JSON.parse(JSON.stringify({1})))")]
        public extern static ReactStyle MergeWith(this ReactStyle baseStyle, ReactStyle other);

        public static ReactStyle Height(Any<string, int> height)
        {
            return new ReactStyle { Height = height };
        }
        public static ReactStyle Height(this ReactStyle style, Any<string, int> height)
        {
            style.Height = height;
            return style;
        }

        public static ReactStyle Width(Any<string, int> width)
        {
            return new ReactStyle { Width = width };
        }
        public static ReactStyle Width(this ReactStyle style, Any<string, int> width)
        {
            style.Width = width;
            return style;
        } 


        public static ReactStyle FontSize(Any<string, int> fontSize)
        {
            return new ReactStyle
            {
                FontSize = fontSize
            };
        }
        public static ReactStyle FontSize(this ReactStyle style, Any<string, int> fontSize)
        {
            style.FontSize = fontSize;
            return style;
        }

        public static ReactStyle Margin(Any<string, int> margin)
        {
            return new ReactStyle { Margin = margin };
        }
        public static ReactStyle Margin(Any<string, int> top, Any<string, int> right, Any<string, int> bottom, Any<string, int> left)
        {
            return new ReactStyle
            {
                MarginTop = top,
                MarginLeft = left,
                MarginRight = right,
                MarginBottom = bottom
            };
        }

        public static ReactStyle Margin(this ReactStyle style, Any<string, int> margin)
        {
            style.Margin = margin;
            return style;
        }

        public static ReactStyle Margin(this ReactStyle style, Any<string, int> top, Any<string, int> right, Any<string, int> bottom, Any<string, int> left)
        {
            style.MarginTop = top;
            style.MarginLeft = left;
            style.MarginRight = right;
            style.MarginBottom = bottom;
            return style;
        }

        public static ReactStyle Padding(Any<string, int> padding)
        {
            return new ReactStyle { Padding = padding };
        }
        public static ReactStyle Padding(Any<string, int> top, Any<string, int> right, Any<string, int> bottom, Any<string, int> left)
        {
            return new ReactStyle
            {
                PaddingTop = top,
                PaddingLeft = left,
                PaddingRight = right,
                PaddingBottom = bottom
            };
        }

        public static ReactStyle Padding(this ReactStyle style, Any<string, int> padding)
        {
            style.Padding = padding;
            return style;
        }

        public static ReactStyle Padding(this ReactStyle style, Any<string, int> top, Any<string, int> right, Any<string, int> bottom, Any<string, int> left)
        {
            style.PaddingTop = top;
            style.PaddingLeft = left;
            style.PaddingRight = right;
            style.PaddingBottom = bottom;
            return style;
        }
    }
}
