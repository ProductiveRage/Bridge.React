using System;

namespace Bridge.React
{
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
