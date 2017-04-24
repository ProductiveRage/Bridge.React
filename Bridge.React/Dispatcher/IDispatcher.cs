using System;

namespace Bridge.React
{
	public interface IDispatcher
	{
		/// <summary>
		/// Dispatches an action that will be sent to all callbacks registered with this dispatcher.
		/// </summary>
		/// <param name="action">The action to dispatch; may not be null.</param>
		void Dispatch(IDispatcherAction action);

		/// <summary>
		/// Registers a callback to receive actions dispatched through this dispatcher.
		/// </summary>
		/// <param name="callback">The callback; may not be null.</param>
		/// <remarks>
		/// Actions will be sent to each receiver in the same order as which the receivers called Register.
		/// </remarks>
		void Register(Action<IDispatcherAction> callback);

		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Dispatch method instead of HandleViewAction or HandleServerAction.")]
		void HandleServerAction(IDispatcherAction action);

		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Dispatch method instead of HandleViewAction or HandleServerAction.")]
		void HandleViewAction(IDispatcherAction action);

		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Register(Action<IDispatcherAction>) method instead of Register(Action<DispatcherMessage>).")]
		void Register(Action<DispatcherMessage> callback);
	}
}