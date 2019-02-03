namespace Bridge.React
{
	public static class Style
	{
		public static ReactStyle MergeWith(this ReactStyle source, ReactStyle other)
		{
			var merged = Script.Write<ReactStyle>("{ }");
			/*@
			if (source) {
				for (var i in source) {
					merged[i] = source[i];
				}
			}
			if (other) {
				for (var i in other) {
					merged[i] = other[i];
				}
			}
			*/
			return merged;
		}

		public static ReactStyle Height(Union<string, int> height)
		{
			return new ReactStyle { Height = height };
		}
		public static ReactStyle Height(this ReactStyle style, Union<string, int> height)
		{
			style.Height = height;
			return style;
		}

		public static ReactStyle Width(Union<string, int> width)
		{
			return new ReactStyle { Width = width };
		}
		public static ReactStyle Width(this ReactStyle style, Union<string, int> width)
		{
			style.Width = width;
			return style;
		} 


		public static ReactStyle FontSize(Union<string, int> fontSize)
		{
			return new ReactStyle
			{
				FontSize = fontSize
			};
		}
		public static ReactStyle FontSize(this ReactStyle style, Union<string, int> fontSize)
		{
			style.FontSize = fontSize;
			return style;
		}

		public static ReactStyle Margin(Union<string, int> margin)
		{
			return new ReactStyle { Margin = margin };
		}
		public static ReactStyle Margin(Union<string, int> top, Union<string, int> right, Union<string, int> bottom, Union<string, int> left)
		{
			return new ReactStyle
			{
				MarginTop = top,
				MarginLeft = left,
				MarginRight = right,
				MarginBottom = bottom
			};
		}

		public static ReactStyle Margin(this ReactStyle style, Union<string, int> margin)
		{
			style.Margin = margin;
			return style;
		}

		public static ReactStyle Margin(this ReactStyle style, Union<string, int> top, Union<string, int> right, Union<string, int> bottom, Union<string, int> left)
		{
			style.MarginTop = top;
			style.MarginLeft = left;
			style.MarginRight = right;
			style.MarginBottom = bottom;
			return style;
		}

		public static ReactStyle Padding(Union<string, int> padding)
		{
			return new ReactStyle { Padding = padding };
		}
		public static ReactStyle Padding(Union<string, int> top, Union<string, int> right, Union<string, int> bottom, Union<string, int> left)
		{
			return new ReactStyle
			{
				PaddingTop = top,
				PaddingLeft = left,
				PaddingRight = right,
				PaddingBottom = bottom
			};
		}

		public static ReactStyle Padding(this ReactStyle style, Union<string, int> padding)
		{
			style.Padding = padding;
			return style;
		}

		public static ReactStyle Padding(this ReactStyle style, Union<string, int> top, Union<string, int> right, Union<string, int> bottom, Union<string, int> left)
		{
			style.PaddingTop = top;
			style.PaddingLeft = left;
			style.PaddingRight = right;
			style.PaddingBottom = bottom;
			return style;
		}
	}
}
