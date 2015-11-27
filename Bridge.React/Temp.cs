using System.Collections.Generic;
using Bridge.Html5;

namespace Bridge.React
{
    public static class Temp
    {
		[Ready]
		public static void Main()
		{
			var elements = new List<ReactElementOrText>
			{
				DOM.Div(null, "Item111"),
				"Item112",
				new MyLabel(new MyLabel.Props { Value = "Item112.1" }),
				DOM.Div(null, "Item113")
			};

			React.Render(
				DOM.Div(null, elements.ToArray()),
				Document.GetElementById("main")
			);
		}
    }

	public class MyLabel : StatelessComponent<MyLabel.Props>
	{
		public MyLabel(Props props) : base(props) { }

		public override ReactElement Render()
		{
			return DOM.Div(
			  new Attributes { ClassName = props.ClassName },
			  props.Value
			);
		}

		public class Props
		{
			public string Value;
			public string ClassName;
		}
	}
}