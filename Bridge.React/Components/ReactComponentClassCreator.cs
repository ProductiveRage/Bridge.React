using System;

namespace Bridge.React
{
	internal static class ReactComponentClassCreator
	{
		public static object CreateClass(object template)
		{
			if (template == null)
				throw new ArgumentNullException(nameof(template));

			var displayName = ComponentNameHelpers.GetDisplayName(template);
			object reactComponentClass = null;
			/*@
			// Use the displayName to name the component class function (React DevTools will use this)
			eval("reactComponentClass = function " + displayName + "(props) { Bridge.React.ReactComponentClassCreator.initialiseComponentState(this, props); }");

			// Set the React.Component base class
			reactComponentClass.prototype = Object.create(
				React.Component && React.Component.prototype,
				{ constructor: { value: reactComponentClass, enumerable: false, writable: true, configurable: true } }
			);
			if (Object.setPrototypeOf) {
				Object.setPrototypeOf(reactComponentClass, React.Component);
			}
			else {
				reactComponentClass.__proto__ = React.Component;
			}

			// Attach the members
			for (var name in template) {
				if (name === 'constructor') {
					continue;
				}
				var value = template[name];
				var descriptor = {
					value: value,
					enumerable: false,
					configurable: true,
					writable: true
				}
				Object.defineProperty(reactComponentClass.prototype, name, descriptor);
			}
			*/
			return reactComponentClass;
		}

		/// <summary>
		/// Class-based components don't support the "getInitialState" method as the state (if an initial value must be set) may be set in the constructor. These bindings don't
		/// support constructors (because there are too many complications with constructor overloading, which JavaScript doesn't have to deal with) and so we need a way to tie
		/// the two concepts together. To do this, if a stateful component has a getInitialState method (renamed in the JavaScript to "constructorStateInitialiser" in these
		/// bindings) then it will be called from the component constructor and used to set the initial state value.
		/// </summary>
		private static void InitialiseComponentState(object instance, object props)
		{
			// The props reference is passed to the constructor but won't yet have been applied to the instance - we'll need to do that in case the props need to be accessed
			// from the GetInitialState method (it shouldn't matter that we're doing this early, React will do it itself shortly)
			/*@
				var getInitialState = instance.constructorStateInitialiser;
				if ((typeof(getInitialState) !== "function") || (getInitialState.length !== 0)) {
					return;
				}
				instance.props = props;
				var state = getInitialState.call(instance);
				if (state) {
					instance.state = { value: state };
				}
			*/
		}
	}
}
