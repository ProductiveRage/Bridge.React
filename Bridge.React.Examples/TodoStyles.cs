using Bridge.Html5;

namespace Bridge.React.Examples
{
    public static class TodoStyles
    {
        public static readonly ReactStyle Container = new ReactStyle
        {
            Border = "2px solid rgba(129, 115, 105, 0.46)",
            BorderRadius = 15,
            Padding = 10,
            Margin = 20,
            MaxWidth = 400,
            Float = Float.Left
        };

        public static readonly ReactStyle TextDone = new ReactStyle
        {
            Color = "#808080",
            TextDecoration = TextDecoration.LineThrough
        };

        public static readonly ReactStyle TextNotDone = new ReactStyle
        {
            Color = "#50a144",
        };


        private static readonly ReactStyle ButtonBase = new ReactStyle
        {
            FontWeight = "900",
            Margin = 10,
            MinHeight = 40,
            MinWidth = 40
        };

        public static readonly ReactStyle RemoveButton = ButtonBase.MergeWith(new ReactStyle
        {
            BackgroundColor = "#e03242",
            Color = "white",
            Border = "1px solid white",
            BorderRadius = 5
        });


        public static ReactStyle ToggleButtonDone = ButtonBase.MergeWith(new ReactStyle
        {
            BackgroundColor = "#808080",
            Color = "white",
            Border = "1px solid white",
            BorderRadius = 5
        });

        public static ReactStyle ToggleButtonNotDone = ButtonBase.MergeWith(new ReactStyle
        {
            BackgroundColor = "#50a144",
            Color = "white",
            Border = "1px solid white",
            BorderRadius = 5
        });
    }
}
