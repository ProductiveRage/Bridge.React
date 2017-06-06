using System;

namespace Bridge.React
{
	internal static class ReactComponentClassCreator
	{
		public static object CreateClass(object template, Type baseComponent)
		{
			if (template == null)
				throw new ArgumentNullException(nameof(template));
			if (baseComponent == null)
				throw new ArgumentNullException(nameof(baseComponent));

			var displayName = ComponentNameHelpers.GetDisplayName(template);
			object reactComponentClass = null;
			/*@
			function getOwnPropertyDescriptors(obj) { // IE11 doesn't support Object.getOwnPropertyDescriptors so use this
				var result = { };
				var arrPropertyNames = Object.getOwnPropertyNames(obj); // IE11 doesn't support "var key of Reflect.ownKeys(obj)" but this approach should suffice for Bridge classes
				for (var i = 0; i < arrPropertyNames.length; i++) {
					var key = arrPropertyNames[i];
					result[key] = Object.getOwnPropertyDescriptor(obj, key);
				}
				return result;
			}
			
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
			// - Get all class prototypes until hit the component base class (there's no need to go down to System.Object)
			// - Apply the members in reverse order (in case any members are named on a derived class and a base class, the derived class should "win" - this won't break calling
			//   methods on the base due to the way that Bridge generates that code)
			var protoStack = [];
			var o = template.__proto__;
			while (o) {
				protoStack.push(o);
				if ((o.$$fullname || "") === baseComponent.$$fullname) {
					break;
				}
				o = o.__proto__;
			}
			for (var i = protoStack.length - 1; i >= 0; i--) {
				o = protoStack[i];
				var descriptors = getOwnPropertyDescriptors(o);
				for (var name in descriptors) {
					var descriptor = descriptors[name];
					Object.defineProperty(reactComponentClass.prototype, name, descriptor);
				}
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
			// from the GetInitialState method (it shouldn't matter that we're doing this early, React will do it itself shortly). Bridge classes require an $init property when
			// the class has properties and/or fields, so we need to create one (any property that doesn't have a value in $init will have the default value for the property type).
			/*@
				instance.$init = {};
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
