using System;

namespace Bridge.React
{
	public interface IDispatcher
	{
		void HandleServerAction(IDispatcherAction action);
		void HandleViewAction(IDispatcherAction action);
		void Register(Action<DispatcherMessage> callback);
	}
}