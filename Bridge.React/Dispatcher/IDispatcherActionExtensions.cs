using System;

namespace Bridge.React
{
	public static class IDispatcherActionExtensions
	{
		/// <summary>
		/// This will execute the specified callback with a non-null reference if the current IDispatcherAction matches type T.
		/// It will never call the work action with a null reference and it will never return a null reference. It will throw an exception
		/// for a null IDispatcherAction or null work reference.
		/// </summary>
		public static IMatchDispatcherActions If<T>(this IDispatcherAction action, Action<T> work) where T : class, IDispatcherAction
		{
			return new DispatcherActionMatcher(action).Else(work);
		}

		/// <summary>
		/// This will execute the specified callback with a non-null reference if the current IDispatcherAction matches type T and
		/// if that instance of T meets the specified conditions. It will never call the work action with a null reference and it will never
		/// return a null reference. It will throw an exception for a null IDispatcherAction, null condition or null work reference.
		/// </summary>
		public static IMatchDispatcherActions If<T>(this IDispatcherAction action, Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
		{
			return new DispatcherActionMatcher(action).Else(condition, work);
		}

		public interface IMatchDispatcherActions
		{
			/// <summary>
			/// This will execute the specified callback with a non-null reference if the current IDispatcherAction matches type T.
			/// It will never call the work action with a null reference and it will never return a null reference. It will throw an exception
			/// for a null work reference.
			/// </summary>
			IMatchDispatcherActions Else<T>(Action<T> work) where T : class, IDispatcherAction;

			/// <summary>
			/// This will execute the specified callback with a non-null reference if the current IDispatcherAction matches type T and
			/// if that instance of T meets the specified conditions. It will never call the work action with a null reference and it will never
			/// return a null reference. It will throw an exception for a null IDispatcherAction, null condition or null work reference.
			/// </summary>
			IMatchDispatcherActions Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction;

			/// <summary>
			/// If any IDispatcherAction has been matched then the specified callback will be executed, if not then it will not be.
			/// This will throw an exception for a null work reference.
			/// </summary>
			void IfAnyMatched(Action work);
		}

		private class DispatcherActionMatcher : IMatchDispatcherActions
		{
			private readonly IDispatcherAction _action;
			public DispatcherActionMatcher(IDispatcherAction action)
			{
				if (action == null)
					throw new ArgumentNullException(nameof(action));
				_action = action;
			}

			public IMatchDispatcherActions Else<T>(Action<T> work) where T : class, IDispatcherAction
			{
				return ElseWithOptionalCondition(null, work);
			}

			public IMatchDispatcherActions Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
			{
				if (condition == null)
					throw new ArgumentNullException(nameof(condition));

				return ElseWithOptionalCondition(condition, work);
			}

			private IMatchDispatcherActions ElseWithOptionalCondition<T>(Func<T, bool> optionalCondition, Action<T> work) where T : class, IDispatcherAction
			{
				if (work == null)
					throw new ArgumentNullException(nameof(work));

				var actionOfDesiredType = _action as T;
				if ((actionOfDesiredType == null) || ((optionalCondition != null) && !optionalCondition(actionOfDesiredType)))
					return this;

				work(actionOfDesiredType);
				return MatchFoundSoMatchNoMoreDispatcherActionMatcher.Instance;
			}

			public void IfAnyMatched(Action work)
			{
				if (work == null)
					throw new ArgumentNullException(nameof(work));

				// Do nothing here - there has been no IDispatcherAction successfully matched by this point (if there had been then
				// we would have returned a MatchFoundSoMatchNoMoreDispatcherActionMatcher)
			}
		}

		private class MatchFoundSoMatchNoMoreDispatcherActionMatcher : IMatchDispatcherActions
		{
			public static MatchFoundSoMatchNoMoreDispatcherActionMatcher Instance = new MatchFoundSoMatchNoMoreDispatcherActionMatcher();

			private MatchFoundSoMatchNoMoreDispatcherActionMatcher() { }

			public IMatchDispatcherActions Else<T>(Action<T> work) where T : class, IDispatcherAction
			{
				if (work == null)
					throw new ArgumentNullException(nameof(work));
				return this;
			}

			public IMatchDispatcherActions Else<T>(Func<T, bool> condition, Action<T> work) where T : class, IDispatcherAction
			{
				if (condition == null)
					throw new ArgumentNullException(nameof(condition));
				if (work == null)
					throw new ArgumentNullException(nameof(work));
				return this;
			}

			public void IfAnyMatched(Action work)
			{
				if (work == null)
					throw new ArgumentNullException(nameof(work));

				// This class is only used if an IDispatcherAction has been succesfully matched, so any calls to IfMatched on this
				// class should result in the if-successful work being executed
				work();
			}
		}
	}
}