using Bridge.Html5;

namespace Bridge.React.Tests
{
	public static class Tests
	{
		[Ready]
		public static void Go()
		{
			StatefulComponentTests.RunTests();
		}
	}
}
