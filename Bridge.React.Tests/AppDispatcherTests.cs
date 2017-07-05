using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	// Note: The AppDispatcher processes everything synchronously and so there is no need for any async complications here
	public static class AppDispatcherTests
	{
		public static void RunTests()
		{
			Module("AppDispatcher");

			Test("Broadcast action to single receiver", assert =>
			{
				var dispatcher = new AppDispatcher();
				dispatcher.Receive(action =>
				{
					assert.Equal(action.GetType(), typeof(SomethingHappened));
				});
				dispatcher.Dispatch(new SomethingHappened());
			});

			Test("Broadcast action to two receivers, where the second to subscribe waits for the first to complete", assert =>
			{
				var dispatcher = new AppDispatcher();
				var firstReceiverProcessed = false;
				var token = dispatcher.Receive(action =>
				{
					firstReceiverProcessed = true;
				});
				dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token);
					assert.Equal(firstReceiverProcessed, true);
				});
				dispatcher.Dispatch(new SomethingHappened());
			});

			Test("Broadcast action to two receivers, where the first to subscribe waits for the second to complete", assert =>
			{
				var dispatcher = new AppDispatcher();
				DispatchToken token = null;
				var secondReceiverProcessed = false;
				dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token);
					assert.Equal(secondReceiverProcessed, true);
				});
				token = dispatcher.Receive(action =>
				{
					secondReceiverProcessed = true;
				});
				dispatcher.Dispatch(new SomethingHappened());
			});

			Test("Broadcast action to two receivers that WaitFor each other - expect circular dependency failure", assert =>
			{
				var dispatcher = new AppDispatcher();
				DispatchToken token2 = null;
				var token1 = dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token2);
				});
				token2 = dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token1);
				});
				assert.Throws(() => dispatcher.Dispatch(new SomethingHappened()), "Dispatch should throw in this case");
			});

			Test("Broadcast action to three receivers where the first waits on the third, the second waits on the first and the third waits on the second - expect circular dependency failure", assert =>
			{
				var dispatcher = new AppDispatcher();
				DispatchToken token3 = null;
				var token1 = dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token3);
				});
				var token2 = dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token1);
				});
				token3 = dispatcher.Receive(action =>
				{
					dispatcher.WaitFor(token2);
				});
				assert.Throws(() => dispatcher.Dispatch(new SomethingHappened()), "Dispatch should throw in this case");
			});
		}

		private sealed class SomethingHappened : IDispatcherAction { }
	}
}
