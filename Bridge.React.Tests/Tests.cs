namespace Bridge.React.Tests
{
	public static class Tests
	{
		[Ready]
		public static void Go()
		{
			StatefulComponentTests.RunTests();
			StatelessComponentTests.RunTests();
			PureComponentTests.RunTests();
			PropInstanceComparisonTests.Instance.RunTests();
			DataAttributeTests.RunTests();
			AriaAttributeTests.RunTests();
			AppDispatcherTests.RunTests();
		}
	}
}
