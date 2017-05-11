using System;
using System.Collections.Generic;

namespace Bridge.React
{
	/// <summary>
	/// This provides a class that is like a combination of the StatelessComponent and the React "PureRenderMixin" - it has no State and will not update if given a new Props reference
	/// whose individual properties are the same as the previous Props reference. Only a shallow equality check is performed, with simple referential equality tests performed - this
	/// will be most reliable if immutable, persistent types are used for any nested data structures (as is the case with the PureRenderMixin). Using this base class means that there
	/// is often less work for the Virtual DOM to do, meaning that UI updates require less work / are faster / are more efficient (it also means it is not possible to provide a custom
	/// ShouldComponentUpdate implementation, since there is already an internal one required to make this work). As with the Component and StatelessComponent base classes (and due to
	/// C# supporting multiple constructor signatures - unlike JavaScript), the constructors will not be executed and so any logic or member initialisation in there will be ignored.
	/// </summary>
	public abstract class PureComponent<TProps>
	{
		private static Dictionary<Type, object> _reactComponentClasses = new Dictionary<Type, object>();
		private readonly ReactElement _reactElement;
		protected PureComponent(TProps props, params Union<ReactElement, string>[] children)
		{
			// To ensure that a single "template" (ie. React component) is created per unique class, a static "_reactComponentClasss" dictionary is maintained. If it has no entry
			// for the current type then this must be the first instantiation of that type and so a component class will be created and added to the dictionary, ready for re-use
			// by any subsequent component instances.
			var currentType = ((object)this).GetType(); // Cast to object first in case derived class uses [IgnoreGeneric] - see http://forums.bridge.net/forum/bridge-net-pro/bugs/3343
			object reactComponentClass;
			if (!_reactComponentClasses.TryGetValue(currentType, out reactComponentClass))
			{
				reactComponentClass = ReactComponentClassCreator.CreateClass(this, baseComponent: typeof(PureComponent<TProps>));
				_reactComponentClasses[currentType] = reactComponentClass;
			}

			// Now that the React component class is certain to have been defined (once per unique C# component class), this instance requires a React element to be created
			// for it. The internal React mechanism means that the component's constructor will not be executed, which is why ALL configuration options for a component must
			// be contained within the props. Note: In most cases where children are specified as a params array, we don't want the "children require unique keys" warning
			// from React (you don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here either - to achieve this, we prepare an
			// arguments array and pass that to React.createElement in an "apply" call.
			Array createElementArgs = new object[] { reactComponentClass, ComponentPropsHelpers.WrapProps(props) };
			if (children != null)
				createElementArgs = createElementArgs.Concat(children);
			_reactElement = Script.Write<ReactElement>("React.createElement.apply(null, createElementArgs)");
		}

		protected virtual void ComponentWillMount() { }

		/// <summary>
		/// Props is not used by all components and so it is valid for the nextProps reference passed up here to be null
		/// </summary>
		[Name("componentWillReceivePropsWrapped")] // This will be called by the method that unwraps the props reference
		protected virtual void ComponentWillReceiveProps(TProps nextProps) { }

		private bool ShouldComponentUpdate(WrappedValue<TProps> nextPropsIfAny)
		{
			return !ComponentPropsHelpers.DoPropsReferencesMatch(this.props, ComponentPropsHelpers.UnWrapValueIfDefined(nextPropsIfAny));
		}

		/// <summary>
		/// Props are not used by all components and so it is valid for the nextProps reference passed up here to be null
		/// </summary>
		[Name("componentWillUpdateWrapped")] // This will be called by the method that unwraps the props reference
		protected virtual void ComponentWillUpdate(TProps nextProps) { }

		public abstract ReactElement Render();

		protected virtual void ComponentDidMount() { }

		/// <summary>
		/// This will be invoked immediately after the component's updates are flushed to the DOM (but not called for the initial render, ComponentDidMount is called then instead)
		/// </summary>
		[Name("componentDidUpdateWrapped")] // This will be called by the method that unwraps the props reference
		protected virtual void ComponentDidUpdate(TProps previousProps) { }

		protected virtual void ComponentWillUnmount() { }

		/// <summary>
		/// Props is not used by all components and so this may be null
		/// </summary>
		[Name("unwrappedProps")] // Can't be called "props" any more since Bridge 16 declares properties using defineProperty instead of using a custom getter/setter convention
		protected TProps props { get { return ComponentPropsHelpers.UnWrapValueIfDefined(Script.Write<WrappedValue<TProps>>("this.props")); } }

		/// <summary>
		/// This will never be null nor contain any null references, though it may be empty if there are no children to render
		/// </summary>
		protected Union<ReactElement, string>[] Children
		{
			get
			{
				// props and props.children are optional and so may not be defined - return an empty array in either case (so that the caller doesn't have to worry about
				// will-this-Children-reference-be-null-or-not). Also, React sets props.children to  object if there is only a single child and to an array if there are
				// multiple - this means that we need to check for the single-child case and wrap it in an array otherwise we'll be returning a non-array object from this
				// method when the property type is an array (this addresses github.com/ProductiveRage/Bridge.React/issues/20).
				return Script.Write<Union<ReactElement, string>[]>("this.props && this.props.children ? (Array.isArray(this.props.children) ? this.props.children : [this.props.children]) : []");
			}
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

		// These are the life cycle methods that React calls - they have to unwrap the props and state references (if provided) in order to pass them on to the methods above
		// (the life cycle methods that derived classes may make use of)
		private void ComponentWillReceiveProps(WrappedValue<TProps> nextPropsIfAny)
		{
			ComponentWillReceiveProps(ComponentPropsHelpers.UnWrapValueIfDefined(nextPropsIfAny));
		}
		private void ComponentWillUpdate(WrappedValue<TProps> nextProps)
		{
			ComponentWillUpdate(ComponentPropsHelpers.UnWrapValueIfDefined(nextProps));
		}
		private void ComponentDidUpdate(WrappedValue<TProps> previousProps)
		{
			ComponentDidUpdate(ComponentPropsHelpers.UnWrapValueIfDefined(previousProps));
		}
	}
}
