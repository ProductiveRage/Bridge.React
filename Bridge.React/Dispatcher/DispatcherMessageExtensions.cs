using System;

namespace Bridge.React
{
	public static class DispatcherMessageExtensions
	{
		/// <summary>
		/// This will execute the specified callback with a non-null reference if the current DispatcherMessage action matches type T.
		/// It will never call the work action with a null reference and it will never return a null reference. It will throw an exception
		/// for a null DispatcherMessage or null work reference.
		/// </summary>
		public static IMatchDispatcherMessages If<T>(this DispatcherMessage message, Action<T> work) where T : class, IDispatcherAction
		{
			return new DispatcherMessageMatcher(message).Else(work);
		}

		/// <summary>
		/// This will execute the specified callback with a non-null reference if the current DispatcherMessage action matches type T and
		/// if that instance of T meets the specified conditions. It will never call the work action with a null reference and it will never
		/// return a null reference. It will throw an exception for a null DispatcherMessage, null condition or null work reference.
		/// </summary>
		public static IMatchDispatcherMessages If<T>(this DispatcherMessage message, Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
		{
			return new DispatcherMessageMatcher(message).Else(condition, work);
		}

		public interface IMatchDispatcherMessages
		{
			/// <summary>
			/// This will execute the specified callback with a non-null reference if the current DispatcherMessage action matches type T.
			/// It will never call the work action with a null reference and it will never return a null reference. It will throw an exception
			/// for a null work reference.
			/// </summary>
			IMatchDispatcherMessages Else<T>(Action<T> work) where T : class, IDispatcherAction;

			/// <summary>
			/// This will execute the specified callback with a non-null reference if the current DispatcherMessage action matches type T and
			/// if that instance of T meets the specified conditions. It will never call the work action with a null reference and it will never
			/// return a null reference. It will throw an exception for a null DispatcherMessage, null condition or null work reference.
			/// </summary>
			IMatchDispatcherMessages Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction;

			/// <summary>
			/// If any DispatcherMessage action has been matched then the specified callback will be executed, if not then it will not be.
			/// This will throw an exception for a null work reference.
			/// </summary>
			void IfAnyMatched(Action work);
		}

		private class DispatcherMessageMatcher : IMatchDispatcherMessages
		{
			private readonly DispatcherMessage _message;
			public DispatcherMessageMatcher(DispatcherMessage message)
			{
				if (message == null)
					throw new ArgumentNullException("message");
				_message = message;
			}

			public IMatchDispatcherMessages Else<T>(Action<T> work) where T : class, IDispatcherAction
			{
				return ElseWithOptionalCondition(null, work);
			}

			public IMatchDispatcherMessages Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
			{
				if (condition == null)
					throw new ArgumentNullException("condition");

				return ElseWithOptionalCondition(condition, work);
			}

			private IMatchDispatcherMessages ElseWithOptionalCondition<T>(Func<T, bool> optionalCondition, Action<T> work) where T : class, IDispatcherAction
			{
				if (work == null)
					throw new ArgumentNullException("work");

				var actionOfDesiredType = _message.Action as T;
				if ((actionOfDesiredType == null) || ((optionalCondition != null) && !optionalCondition(actionOfDesiredType)))
					return this;

				work(actionOfDesiredType);
				return MatchFoundSoMatchNoMoreDispatcherMessageMatcher.Instance;
			}

			public void IfAnyMatched(Action work)
			{
				if (work == null)
					throw new ArgumentNullException("work");

				// Do nothing here - there has been no DispatcherMessage action successfully matched by this point (if there had been then
				// we would have returned a MatchFoundSoMatchNoMoreDispatcherMessageMatcher)
			}
		}

		private class MatchFoundSoMatchNoMoreDispatcherMessageMatcher : IMatchDispatcherMessages
		{
			public static MatchFoundSoMatchNoMoreDispatcherMessageMatcher Instance = new MatchFoundSoMatchNoMoreDispatcherMessageMatcher();

			private MatchFoundSoMatchNoMoreDispatcherMessageMatcher() { }

			public IMatchDispatcherMessages Else<T>(Action<T> work) where T : class, IDispatcherAction
			{
				if (work == null)
					throw new ArgumentNullException("work");
				return this;
			}

			public IMatchDispatcherMessages Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
			{
				if (condition == null)
					throw new ArgumentNullException("condition");
				if (work == null)
					throw new ArgumentNullException("work");
				return this;
			}

			public void IfAnyMatched(Action work)
			{
				if (work == null)
					throw new ArgumentNullException("work");

				// This class is only used if a DispatcherMessage action has been succesfully matched, so any calls to IfMatched on this
				// class should result in the if-successful work being executed
				work();
			}
		}
	}
}