using System;
using System.Linq;

namespace Bridge.React
{
	// Note: There is code duplication between here and the Component class. One way to remove the duplication would have been for the PureComponent to be derived from Component, but I
	// wanted to avoid doing that so that the implementations were not tied - in the future I might want to change how this works in such a way that it would no longer be derived from
	// Component but this could break calling code that presumes that any PureComponent instance is also a Component instance. On top of that, I only want the PureComponent to expose
	// the Render method - I don't want the other lifecycle methods to be overrideable (this potentially leaves things open for further optimisations in the future, by keeping derived
	// classes as simple as possible).

	/// <summary>
	/// This provides a class that is like a combination of the StatelessComponent and the React "PureRenderMixin" - it has no State and will not update if given a new Props reference
	/// whose individual properties are the same as the previous Props reference. Only a shallow equality check is performed, with simple referential equality tests performed - this
	/// will be most reliable if immutable, persistent types are used for any nested data structures (as is the case with the PureRenderMixin). Using this base class means that there
	/// is often less work for the Virtual DOM to do, meaning that UI updates require less work / are faster / are more efficient. Note that this class only supports the Render method,
	/// the other lifecycle methods (ComponentWillReceiveProps, ComponentWillUpdate, etc..) may not be overridden (ShouldComponentUpdate has an internal implementation here that may
	/// not be altered) - this is because it is possible that this class' internals may be changed for future versions of React, depending upon what optimisations become available for
	/// Stateless Components. As with the Component and StatelessComponent base classes (and due to the way that React initialises components), it is important that derived classes do
	/// not perform any logic or initialisation in their constructor, nor may they have any other configuration passed into their constructor but that which is described by the Props
	/// data. The constructors will not be executed and so any logic or member initialisation in there will be silenty ignored.
	/// </summary>
	public abstract class PureComponent<TProps>
	{
		private static object _reactComponentClass = null;
		private readonly ReactElement _reactElement;
		protected PureComponent(TProps props, params Any<ReactElement, string>[] children)
		{
			if (children != null)
			{
				if (children.Any(element => element == null))
					throw new ArgumentException("Null reference encountered in children set");
			}

			// To ensure that a single "template" (ie. React component) is created per unique class, a static "_reactComponentClass" reference is maintained. When this is
			// null, for the first instantiation of any particular component class, it will be populated and then re-used for any further component instances.
			var reactComponentClass = _reactComponentClass;
			if (reactComponentClass == null)
				_reactComponentClass = CreateReactComponentClass();

			// Now that the React component class is certain to have been defined (once per unique C# component class), this instance requires a React element to be created
			// for it. The internal React mechanism means that the component's constructor will not be executed, which is why ALL configuration options for a component must
			// be contained within the props. Note: In most cases where children are specified as a params array, we don't want the "children require unique keys" warning
			// from React (you don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here either - to achieve this, we prepare an
			// arguments array and pass that to React.createElement in an "apply" call.
			Array createElementArgs = new object[] { _reactComponentClass, ComponentPropsHelpers<TProps>.WrapProps(props) };
			if (children != null)
				createElementArgs = createElementArgs.Concat(children);
			_reactElement = Script.Write<ReactElement>("React.createElement.apply(null, createElementArgs)");
		}

		private object CreateReactComponentClass()
		{
			var className = ComponentNameHelpers.GetDisplayName(this);
			object reactComponentClass = null;
			/*@
			var bridgeComponentInstance = this;
			bridgeComponentInstance.displayName = className; // This is used by the React dev tools extension
				
			// Copy over all functions that may be needed first (ignoring the constructor since copying that causes a Reacts warning and because the constructor will not
			// be used when createElement initialises new element instances)..
			for (var i in bridgeComponentInstance) {
				if (i === 'constructor') {
					continue;
				}
				bridgeComponentInstance[i] = bridgeComponentInstance[i];
			}

			// .. then overwrite the ShouldComponentUpdate function, since that needs special treatment
			var shouldComponentUpdate = bridgeComponentInstance.shouldComponentUpdate;
			bridgeComponentInstance.shouldComponentUpdate = function (nextProps, nextState) {
				return shouldComponentUpdate.apply(this, [ nextProps ? nextProps.value : nextProps, nextState ? nextState.value : nextState ]);
			};
			reactComponentClass = React.createClass(bridgeComponentInstance);
			*/
			return reactComponentClass;
		}

		private bool ShouldComponentUpdate(TProps nextProps, object nextState)
		{
			return !DoPropsReferencesMatch(this.props, nextProps);
		}

		private static bool DoPropsReferencesMatch(object props1, object props2)
		{
			if ((props1 == null) && (props2 == null))
				return true;
			else if ((props1 == null) || (props2 == null))
				return false;

			if (props1.GetType() != props2.GetType())
				return false;

			/*@
			for (var propName in props1) {
				var propValue1 = props1[propName];
				var propValue2 = props2[propName];
				if ((propValue1 === propValue2) 
				|| ((propValue1 === null) && (propValue2 === null))
				|| ((typeof(propValue1) === "undefined") && (typeof(propValue2) === "undefined"))) {
					// Very simple cases where the properties match
					continue;
				}
				else if ((propValue1 === null) || (propValue2 === null) || (typeof(propValue1) === "undefined") || (typeof(propValue2) === "undefined")) {
					// Simple cases where one or both of the values are some sort of no-value (but either one of them has a value or they're inconsistent types of no-value,
					// since we'd have caught them above otherwise)
					return false;
				}
				else if ((typeof(propValue1) === "function") && (typeof(propValue2) === "function")) {
					// If they're Bridge-bound functions (which is what the presence of $scope and $method properties indicates), then check whether the underlying $method
					// and $scope references match (if they do then this means that it's the same method bound to the same "this" scope, but the actual function references
					// are not the same since they were the results from two different calls to Bridge.fn.bind)
					if (propValue1.$scope && propValue1.$method && propValue2.$scope && propValue2.$method && (propValue1.$scope === propValue2.$scope) && (propValue1.$method === propValue2.$method)) {
						continue;
					}
					// Due to the way that properties are currently initialised on types in Bridge, if a property's type is a struct then the getter and setter for it will
					// be created for each instance of the type, rather than being shared across all instances of the type (which is the case for reference type properties).
					// This means that when it comes to a "getName" property, for example, the "getName" function will not be the same value for two instances of the same
					// class, which is a problem for this function since it will mean that two props references that contain the same data are not identified as such as
					// the getter / setter functions are distinct across instances. A proper fix for this has been requested at:
					//   http://forums.bridge.net/forum/general/feature-requests/1737
					// A temporary workaround is for the getter and setter functions to be identified as such, and then ignored by this process. That would not be particularly
					// easy to do in general, but it IS something that's relatively easy to add to the ProductiveRage.Immutable library (every time that CtorSet is called, the
					// getter and setter methods for the property will have a $scaffolding value set to true). This can be unpicked if the Bridge translation process changes
					// but it means that types that have struct properties that are declared using the IAmImmutable helpers will work before that time.
					if ((propValue1.$scaffolding === true) && (propValue2.$scaffolding === true)) {
						continue;
					}
				}
				else if ((typeof(propValue1.equals) === "function") && (propValue1.equals(propValue2) === true)) {
					// If propValue1 has an "equals" implementation then give that a go
					continue;
				}
				return false;
			}
			*/
			return true;
		}

		/// <summary>
		/// Props is not used by all components and so this may be null
		/// </summary>
		protected TProps props
		{
			// If props is non-null then it needs to be "unwrapped" when the C# code requests it
			get { return Script.Write<TProps>("this.props ? this.props.value : null"); }
		}

		/// <summary>
		/// This will never be null nor contain any null references, though it may be empty if there are no children to render
		/// </summary>
		protected Any<ReactElement, string>[] Children
		{
			get { return Script.Write<Any<ReactElement, string>[]>("this.props && this.props.children ? this.props.children : []"); }
		}

		public static implicit operator ReactElement(PureComponent<TProps> component)
		{
			if (component == null)
				throw new ArgumentNullException("component");

			return component._reactElement;
		}

		public static implicit operator Any<ReactElement, string>(PureComponent<TProps> component)
		{
			if (component == null)
				throw new ArgumentNullException("component");

			return component._reactElement;
		}

		public abstract ReactElement Render();
	}
}
