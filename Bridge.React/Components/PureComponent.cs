using System;
using System.Collections.Generic;
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
		private static Dictionary<Type, object> _reactComponentClasses = new Dictionary<Type, object>();
		private readonly ReactElement _reactElement;
		protected PureComponent(TProps props, params Union<ReactElement, string>[] children)
		{
			if (children != null)
			{
				if (children.Any(element => element == null))
					throw new ArgumentException("Null reference encountered in children set");
			}

			// To ensure that a single "template" (ie. React component) is created per unique class, a static "_reactComponentClasss" dictionary is maintained. If it has no entry
			// for the current type then this must be the first instantiation of that type and so a component class will be created and added to the dictionary, ready for re-use
			// by any subsequent component instances.
			var currentType = ((object)this).GetType(); // Cast to object first in case derived class uses [IgnoreGeneric] - see http://forums.bridge.net/forum/bridge-net-pro/bugs/3343
			object reactComponentClass;
			if (!_reactComponentClasses.TryGetValue(currentType, out reactComponentClass))
			{
				reactComponentClass = CreateReactComponentClass();
				_reactComponentClasses[currentType] = reactComponentClass;
			}

			// Now that the React component class is certain to have been defined (once per unique C# component class), this instance requires a React element to be created
			// for it. The internal React mechanism means that the component's constructor will not be executed, which is why ALL configuration options for a component must
			// be contained within the props. Note: In most cases where children are specified as a params array, we don't want the "children require unique keys" warning
			// from React (you don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here either - to achieve this, we prepare an
			// arguments array and pass that to React.createElement in an "apply" call.
			Array createElementArgs = new object[] { reactComponentClass, ComponentPropsHelpers<TProps>.WrapProps(props) };
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

			// .. then overwrite the supported life cycle functions (ComponentDidMount, ComponentDidUpdate, ShouldComponentUpdate), since they need special treatment
			var componentDidMount = bridgeComponentInstance.componentDidMount;
			bridgeComponentInstance.componentDidMount = function () {
				componentDidMount.apply(this, [ ]);
			};
			var componentDidUpdate = bridgeComponentInstance.componentDidUpdate;
			bridgeComponentInstance.componentDidUpdate = function (previousProps) {
				componentDidUpdate.apply(this, [ previousProps ? previousProps.value : previousProps ]);
			};
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
			return !ComponentPropsHelpers<TProps>.DoPropsReferencesMatch(this.props, nextProps);
		}

		/// <summary>
		/// This will be invoked once, immediately after the initial rendering occurs
		/// </summary>
		protected virtual void ComponentDidMount() { }

		/// <summary>
		/// This will be invoked immediately after the component's updates are flushed to the DOM (but not called for the initial render, ComponentDidMount is called then instead)
		/// </summary>
		protected virtual void ComponentDidUpdate(TProps previousProps) { }

		protected virtual void ComponentWillUnmount() { }

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
		protected Union<ReactElement, string>[] Children
		{
			get { return Script.Write<Union<ReactElement, string>[]>("this.props && this.props.children ? this.props.children : []"); }
		}

		public static implicit operator ReactElement(PureComponent<TProps> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null PureComponent reference will pass through this operator method and so null
			// needs to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}

		public static implicit operator Union<ReactElement, string>(PureComponent<TProps> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null PureComponent reference will pass through this operator method and so null
			// needs to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}

		public abstract ReactElement Render();
	}
}
