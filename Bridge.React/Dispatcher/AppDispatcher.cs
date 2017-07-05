using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	// "Inspired by" (ie. largely stolen from) https://github.com/dionrhys/Bridge.Flux/blob/master/Bridge.Flux/Dispatcher.cs
	public sealed class AppDispatcher : IDispatcher
	{
		// TODO: Change this to an Action<IDispatcherAction> event handler later on when removing the DispatcherMessage support altogether.
		// It can't be changed now because consumers may be relying on the extra information given in the DispatcherMessage class.
#pragma warning disable CS0618 // Type or member is obsolete
		private readonly Dictionary<DispatchToken, Action<DispatcherMessage>> _callbacks;
		private readonly HashSet<DispatchToken> _executingCallbacks;
		private readonly HashSet<DispatchToken> _finishedCallbacks;
		private bool _isDispatching;
		private DispatcherMessage _currentMessage;
		public AppDispatcher()
		{
			_callbacks = new Dictionary<DispatchToken, Action<DispatcherMessage>>();
			_executingCallbacks = new HashSet<DispatchToken>();
			_finishedCallbacks = new HashSet<DispatchToken>();
			_isDispatching = false;
			_currentMessage = null;
		}
#pragma warning restore CS0618 // Type or member is obsolete

		/// <summary>
		/// Dispatches an action that will be sent to all callbacks registered with this dispatcher.
		/// </summary>
		/// <param name="action">The action to dispatch; may not be null.</param>
		public void Dispatch(IDispatcherAction action)
		{
			if (action == null)
				throw new ArgumentNullException(nameof(action));

			// The obsolete MessageSourceOptions handling needs to stay in the meantime, so just dispatch this as any arbitrary source.
			// Eventually this method should absorb the Dispatch(DispatcherMessage message) method's behaviour but dispatch the action
			// directly down to the event handler without wrapping it in a DispatcherMessage.
#pragma warning disable CS0618 // Type or member is obsolete
			Dispatch(new DispatcherMessage(MessageSourceOptions.View, action));
#pragma warning restore CS0618 // Type or member is obsolete
		}

		/// <summary>
		/// Registers a callback to receive actions dispatched through this dispatcher. For historical reasons, this is called Receive instead of Register - this interface originally only had a Register method
		/// that accepted a callback for DispatcherMessage instance, which were actions paired with a source of either View or Server and which were dispatched via methods HandleViewAction or HandleServerAction.
		/// These methods and the DispatcherMessage class are now considered obsolete, as is the Register method that receives DispatcherMessage instance. However, in order to avoid breaking existing code, the
		/// method that registers to receive unwrapped IDispatcherAction instances must be called a name other than Register (otherwise previously-compiling code could be afflicted by call-is-ambiguous errors).
		/// </summary>
		/// <param name="callback">The callback; may not be null.</param>
		/// <remarks>
		/// Actions will be sent to each receiver in the same order as which the receivers called Register.
		/// </remarks>
		public DispatchToken Receive(Action<IDispatcherAction> callback)
		{
			if (callback == null)
				throw new ArgumentNullException(nameof(callback));

			// We have to keep support for the DispatcherMessage class for now (until a breaking release is made), so the _dispatcher
			// event handler has to take DispatcherMessages for now, and we have to wrap the callback given here.
#pragma warning disable CS0618 // Type or member is obsolete
			return Register(message => callback(message.Action));
#pragma warning restore CS0618 // Type or member is obsolete
		}

		/// <summary>
		/// Actions will sent to each receiver in the same order as which the receivers called Register.
		/// </summary>
		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Receive(Action<IDispatcherAction>) method instead of Register(Action<DispatcherMessage>)")]
		public DispatchToken Register(Action<DispatcherMessage> callback)
		{
			if (callback == null)
				throw new ArgumentNullException(nameof(callback));

			if (_isDispatching)
				throw new InvalidOperationException("Cannot register a dispatch token while dispatching");

			var token = new DispatchToken();
			_callbacks.Add(token, callback);
			return token;
		}

		/// <summary>
		/// Unregisters the callback associated with the given token.
		/// </summary>
		/// <param name="token">The dispatch token to unregister; may not be null.</param>
		/// <remarks>
		/// This method cannot be called while a dispatch is in progress.
		/// </remarks>
		public void Unregister(DispatchToken token)
		{
			if (token == null)
				throw new ArgumentNullException(nameof(token));
			if (!_callbacks.ContainsKey(token))
				throw new ArgumentException("", nameof(token));

			if (_isDispatching)
				throw new InvalidOperationException("Cannot unregister a dispatch token while dispatching");

			if (!_callbacks.ContainsKey(token))
				throw new InvalidOperationException($"Invalid {nameof(token)} specified - not currently registered");

			_callbacks.Remove(token);
		}

		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Dispatch method instead of HandleViewAction or HandleServerAction")]
		public void HandleViewAction(IDispatcherAction action)
		{
			if (action == null)
				throw new ArgumentNullException("action");

			Dispatch(new DispatcherMessage(MessageSourceOptions.View, action));
		}

		[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use the Dispatch method instead of HandleViewAction or HandleServerAction")]
		public void HandleServerAction(IDispatcherAction action)
		{
			if (action == null)
				throw new ArgumentNullException("action");

			Dispatch(new DispatcherMessage(MessageSourceOptions.Server, action));
		}

#pragma warning disable CS0618 // Type or member is obsolete
		private void Dispatch(DispatcherMessage message)
#pragma warning restore CS0618 // Type or member is obsolete
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			if (_isDispatching)
				throw new InvalidOperationException("Cannot dispatch while already dispatching");

			_isDispatching = true;
			_currentMessage = message;
			_executingCallbacks.Clear();
			_finishedCallbacks.Clear();
			try
			{
				foreach (var callback in _callbacks)
				{
					// Skip over callbacks that have already been called (by an earlier callback that used WaitFor)
					if (_finishedCallbacks.Contains(callback.Key))
						continue;

					_executingCallbacks.Add(callback.Key);
					callback.Value(_currentMessage);
					_executingCallbacks.Remove(callback.Key);
					_finishedCallbacks.Add(callback.Key);
				}
			}
			finally
			{
				_isDispatching = false;
				_currentMessage = null;
				_executingCallbacks.Clear();
				_finishedCallbacks.Clear();
			}
		}

		/// <summary>
		/// Waits for the callbacks associated with the given tokens to be called first during a dispatch operation.
		/// </summary>
		/// <param name="tokens">The tokens to wait on; may not be null.</param>
		/// <remarks>
		/// This method can only be called while a dispatch is in progress.
		/// </remarks>
		public void WaitFor(IEnumerable<DispatchToken> tokens)
		{
			if (tokens == null)
				throw new ArgumentNullException(nameof(tokens));
			tokens = tokens.ToArray(); // Evaluate the set now, just to be 100% sure that its contents while mutate while we're validating and processing it
			if (!tokens.Any())
				throw new ArgumentException($"Empty {nameof(tokens)} set - invalid (must wait for at least one DispatchToken)");
			if (tokens.Any(token => token == null))
				throw new ArgumentException($"Null reference encountered in {nameof(tokens)} set");
			if (!tokens.All(token => _callbacks.ContainsKey(token)))
				throw new ArgumentException("All given tokens must be registered with this dispatcher", nameof(tokens));

			if (!_isDispatching)
				throw new InvalidOperationException("Can only call WaitFor while dispatching");

			// Ensure there isn't a circular dependency of tokens waiting on each other
			if (tokens.Any(token => _executingCallbacks.Contains(token)))
				throw new ArgumentException("None of the tokens can have its callback already executing", nameof(tokens));

			foreach (var token in tokens)
			{
				// Skip over callbacks that have already been called
				if (_finishedCallbacks.Contains(token))
					continue;

				_executingCallbacks.Add(token);
				_callbacks[token](_currentMessage);
				_executingCallbacks.Remove(token);
				_finishedCallbacks.Add(token);
			}
		}

		/// <summary>
		/// Waits for the callbacks associated with the given tokens to be called first during a dispatch operation.
		/// </summary>
		/// <param name="tokens">The tokens to wait on; may not be null.</param>
		/// <remarks>
		/// This method can only be called while a dispatch is in progress.
		/// </remarks>
		public void WaitFor(params DispatchToken[] tokens)
		{
			WaitFor((IEnumerable<DispatchToken>)tokens);
		}
	}
}