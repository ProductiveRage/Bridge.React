using System;

namespace Bridge.React
{
    public sealed class AppDispatcher
    {
        private event Action<DispatcherMessage> _dispatcher;

        public void Register(Action<DispatcherMessage> callback)
        {
            _dispatcher += callback;
        }

        public void HandleViewAction(IDispatcherAction action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            _dispatcher(new DispatcherMessage(MessageSourceOptions.View, action));
        }

        public void HandleServerAction(IDispatcherAction action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            _dispatcher(new DispatcherMessage(MessageSourceOptions.Server, action));
        }
    }
}