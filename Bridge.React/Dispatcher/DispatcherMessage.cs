using System;

namespace Bridge.React
{
	[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. Use IDispatcherAction directly instead of the DispatcherMessage wrapper class.")]
	public sealed class DispatcherMessage
	{
		public DispatcherMessage(MessageSourceOptions source, IDispatcherAction action)
		{
			if ((source != MessageSourceOptions.Server) && (source != MessageSourceOptions.View))
				throw new ArgumentOutOfRangeException("source");
			if (action == null)
				throw new ArgumentNullException("action");

			Source = source;
			Action = action;
		}

		public MessageSourceOptions Source { get; private set; }

		/// <summary>
		/// This will never be null
		/// </summary>
		public IDispatcherAction Action { get; private set; }
	}
}
