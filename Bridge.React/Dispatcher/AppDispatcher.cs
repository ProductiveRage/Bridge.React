using System;

namespace Bridge.React
{
	public sealed class AppDispatcher
	{
		private event Action<DispatcherMessage> _dispatcher;

		private bool _currentDispatching;
		public AppDispatcher()
		{
			_currentDispatching = false;
		}


		public void Register(Action<DispatcherMessage> callback)
		{
			_dispatcher += callback;
		}

		public void HandleViewAction(IDispatcherAction action)
		{
			if (action == null)
				throw new ArgumentNullException("action");

			Dispatch(new DispatcherMessage(MessageSourceOptions.View, action));
		}

		public void HandleServerAction(IDispatcherAction action)
		{
			if (action == null)
				throw new ArgumentNullException("action");

			Dispatch(new DispatcherMessage(MessageSourceOptions.Server, action));
		}

		private void Dispatch(DispatcherMessage message)
		{
			if (message == null)
				throw new ArgumentNullException("message");

			// Dispatching a message during the handling of another is not allowed, in order to be consistent with the Facebook Dispatcher
			// (see https://github.com/facebook/flux/blob/master/src/Dispatcher.js#L183)
			if (_dispatcher != null)
			{
				if (_currentDispatching)
					throw new Exception("Cannot dispatch in the middle of a dispatch.");
				_currentDispatching = true;
				try
				{
					_dispatcher(message);
				}
				finally
				{
					_currentDispatching = false;
				}
			}
		}
	}
}