using System.Linq;
using Bridge.Html5;

namespace Bridge.React.Examples
{
	public class App
    {
        public static void Main()
        {
			var values = new[] { 1, 2, 3 };

			var test = ReactElementList.Empty
				.Add(DOM.Div(new Attributes { Key = "i1" }, "abc"))
				.Add(values.Select(value => DOM.Div(new Attributes { Key = "value-" + value }, value.ToString())))
				.Add(DOM.Div(new Attributes { Key = "i9" }, "xyz"));






			React.Render(
                //new TodoApp("C# React canonical todo app"),
				DOM.Div(test),
                Document.GetElementById("main")
            );
        }
    }
}
