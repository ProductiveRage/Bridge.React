using Bridge.Html5;

namespace Bridge.React.Examples
{
	public sealed class App
	{
		public static void Main()
		{
			React.Render(
				new TodoApp("C# React canonical todo app"),
				Document.GetElementById("main")
			);
		}
	}
}
