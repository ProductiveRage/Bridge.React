using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bridge.React
{
	/// <summary>
	/// This provides a class which may be derived from in order to declare React components. Due to the way that React initialises components, it is important that derived classes
	/// do not perform any logic or initialisation in their constructor, nor may they have any other configuration passed into their constructor but that which is described by the
	/// props (and state, where applicable) data. The constructors will not be executed and so any logic or member initialisation in there will be silenty ignored (this is due to
	/// the fact that C# has to be able to support multiple constructor overloads but JavaScript does not and React is built on this assumption).
	/// </summary>
	public abstract class Component<TProps, TState>
	{
		private static Dictionary<Type, object> _reactComponentClasses = new Dictionary<Type, object>();
		private readonly ReactElement _reactElement;
		protected Component(TProps props, params Union<ReactElement, string>[] children)
		{
			// To ensure that a single "template" (ie. React component) is created per unique class, a static "_reactComponentClasss" dictionary is maintained. If it has no entry
			// for the current type then this must be the first instantiation of that type and so a component class will be created and added to the dictionary, ready for re-use
			// by any subsequent component instances.
			var currentType = ((object)this).GetType(); // Cast to object first in case derived class uses [IgnoreGeneric] - see http://forums.bridge.net/forum/bridge-net-pro/bugs/3343
			object reactComponentClass;
			if (!_reactComponentClasses.TryGetValue(currentType, out reactComponentClass))
			{
				reactComponentClass = ReactComponentClassCreator.CreateClass(this, baseComponent: typeof(Component<TProps, TState>));
				_reactComponentClasses[currentType] = reactComponentClass;
			}

			// Now that the React component class is certain to have been defined (once per unique C# component class), this instance requires a React element to be created
			// for it. The internal React mechanism means that the component's constructor will not be executed, which is why ALL state and configuration options for a
			// component must be contained within the props (and state, where appropriate). Note: In most cases where children are specified as a params array, we don't want
			// the "children require unique keys" warning from React (you don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here
			// either - to achieve this, we prepare an arguments array and pass that to React.createElement in an "apply" call.
			Array createElementArgs = new object[] { reactComponentClass, ComponentPropsHelpers.WrapProps<Component<TProps, TState>, TProps>(props) };
			if (children != null)
				createElementArgs = createElementArgs.Concat(children);
			_reactElement = Script.Write<ReactElement>("React.createElement.apply(null, createElementArgs)");
		}

		/// <summary>
		/// Props is not used by all components and so this may be null
		/// </summary>
		[Name("unwrappedProps")] // Can't be called "props" any more since Bridge 16 declares properties using defineProperty instead of using a custom getter/setter convention
		protected TProps props { get { return ComponentPropsHelpers.UnWrapValueIfDefined(Script.Write<WrappedValue<TProps>>("this.props")); } }

		/// <summary>
		/// State is not used by all components and so this may be null
		/// </summary>
		[Name("unwrappedState")] // Can't be called "state" any more since Bridge 16 declares properties using defineProperty instead of using a custom getter/setter convention
		protected TState state { get { return ComponentPropsHelpers.UnWrapValueIfDefined(Script.Write<WrappedValue<TState>>("this.state")); } }

		/// <summary>
		/// This will never be null nor contain any null references, though it may be empty if there are no children to render
		/// </summary>
		protected Union<ReactElement, string>[] Children
		{
			get
			{
				// See notes in PureComponent's Children property for details about what's going on here
				return Script.Write<Union<ReactElement, string>[]>("this.props && this.props.children ? (Array.isArray(this.props.children) ? this.props.children : [this.props.children]) : []");
			}
		}

		public static implicit operator ReactElement(Component<TProps, TState> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null Component reference will pass through this operator method and so null needs
			// to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}

		public static implicit operator Union<ReactElement, string>(Component<TProps, TState> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null Component reference will pass through this operator method and so null needs
			// to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}

		/// <summary>
		/// When writing React components in JavaScript, it is recommended that they be constructed as classes that are derived from React.Component and that any initial-state setting be
		/// done in the constructor (for this reason, GetInitialState is not support for JavaScript class-based React components). However, JavaScript does not have to support multiple
		/// constructor signatures, unlike C#, which makes things easier for JavaScript React; with these bindings, multiple constructors signatures ARE supported but they will not be
		/// called during component initialisation and so must not contain any code (there is an analyser to identify any time that this rule has been forgotten). Since constructors
		/// are not executed, the GetInitialState is still the way to set initial state. Note: State is not used by all components and so it is valid to return null from any
		/// implementation of this function.
		/// </summary>
		[Name("constructorStateInitialiser")] // "getInitialState" is not supported for class-based components so rename this to something else and tie it in via ReactComponentClassCreator.InitialiseComponentState
		protected virtual TState GetInitialState() { return default(TState); }

		protected virtual void ComponentWillMount() { }

		/// <summary>
		/// Props is not used by all components and so it is valid for the nextProps reference passed up here to be null
		/// </summary>
		[Name("componentWillReceivePropsWrapped")] // This will be called by the method that unwraps the props reference
		protected virtual void ComponentWillReceiveProps(TProps nextProps) { }

		/// <summary>
		/// If this returns false then the proposed component update will be cancelled - this may be used as an optimisation to avoid unnecessary updates. Since deep equality
		/// checks can be expensive, taking advantage of this mechanism is easiest when the props and state types are immutable and so equality checks are as simple (and cheap)
		/// as a reference equality test. Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed
		/// up here to be null.
		/// </summary>
		[Name("shouldComponentUpdateWrapped")] // This will be called by the method that unwraps the props and state references
		protected virtual bool ShouldComponentUpdate(TProps nextProps, TState nextState) { return true; }

		/// <summary>
		/// Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed up here to be null
		/// </summary>
		[Name("componentWillUpdateWrapped")] // This will be called by the method that unwraps the props and state references
		protected virtual void ComponentWillUpdate(TProps nextProps, TState nextState) { }

		public abstract ReactElement Render();

		protected virtual void ComponentDidMount() { }

		/// <summary>
		/// Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed up here to be null
		/// </summary>
		[Name("componentDidUpdateWrapped")] // This will be called by the method that unwraps the props and state references
		protected virtual void ComponentDidUpdate(TProps previousProps, TState previousState) { }

		protected virtual void ComponentWillUnmount() { }

		// Note: This is not a direct call to setState - it wraps the provided value up so that React does not meddle with it (this is why the function has the Name attribute,
		// to ensure that the JavaScript function does NOT result in it being applied to the component "template" as a function named setState)
		/// <summary>
		/// This replaces the entire state for the component instance - it does not merge any state data with any state data already present on the instance. As such, it might
		/// be best to consider this implementation to be more like ReplaceState.
		/// </summary>
		[Name("setWrappedState")]
		protected void SetState(TState state)
		{
			Script.Write("this.setState({ value: state })");
		}
		
		/// <summary>
		/// This replaces the entire state for the component instance, and executes the callback delegate when the state has been
		/// successfully mutated. See http://stackoverflow.com/questions/30782948/why-calling-react-setstate-method-doesnt-mutate-the-state-immediately
		/// </summary>
		[Name("setWrappedStateCallback")]
		protected void SetState(TState state, Action callback)
		{
			Script.Write("this.setState({ value: state }, callback)");
		}
		
		/// <summary>
		/// This replaces the entire state for the component instance asynchronously. Execution will continue when the state has been successfully mutated.
		/// </summary>
		[Name("setWrappedStateAsync")]
		protected Task SetStateAsync(TState state)
		{
			var tcs = new TaskCompletionSource<object>();
			SetState(state, () => tcs.SetResult(null));
			return tcs.Task;
		}

		/// <summary>
		/// This replaces the entire state for the component instance. The updater function will be called with the previous state including any changes
		/// already queued up by previous calls to SetState, and the current up-to-date props.
		/// </summary>
		[Name("setWrappedStateUsingUpdater")]
		protected void SetState(Func<TState, TProps, TState> updater)
		{
			Func<WrappedValue<TState>, WrappedValue<TProps>, WrappedValue<TState>> wrappedUpdater = (prevState, props) =>
			{
				var unwrappedPrevState = ComponentPropsHelpers.UnWrapValueIfDefined(prevState);
				var unwrappedProps = ComponentPropsHelpers.UnWrapValueIfDefined(props);

				return new WrappedValue<TState> { Value = updater(unwrappedPrevState, unwrappedProps) };
			};
			Script.Write("this.setState(wrappedUpdater)");
		}

		/// <summary>
		/// This replaces the entire state for the component instance, and executes the callback delegate when the state has been successfully mutated.
		/// The updater function will be called with the previous state including any changes already queued up by previous calls to SetState, and the
		/// current up-to-date props.
		/// </summary>
		[Name("setWrappedStateCallbackUsingUpdater")]
		protected void SetState(Func<TState, TProps, TState> updater, Action callback)
		{
			Func<WrappedValue<TState>, WrappedValue<TProps>, WrappedValue<TState>> wrappedUpdater = (prevState, props) =>
			{
				var unwrappedPrevState = ComponentPropsHelpers.UnWrapValueIfDefined(prevState);
				var unwrappedProps = ComponentPropsHelpers.UnWrapValueIfDefined(props);

				return new WrappedValue<TState> { Value = updater(unwrappedPrevState, unwrappedProps) };
			};
			Script.Write("this.setState(wrappedUpdater, callback)");
		}

		/// <summary>
		/// This replaces the entire state for the component instance, and returns a Task that will complete when the state has been successfully mutated.
		/// The updater function will be called with the previous state including any changes already queued up by previous calls to SetState, and the
		/// current up-to-date props.
		/// </summary>
		[Name("setWrappedStateAsyncUsingUpdater")]
		protected Task SetStateAsync(Func<TState, TProps, TState> updater)
		{
			var tcs = new TaskCompletionSource<object>();
			SetState(updater, () => tcs.SetResult(null));
			return tcs.Task;
		}

		// These are the life cycle methods that React calls - they have to unwrap the props and state references (if provided) in order to pass them on to the methods above
		// (the life cycle methods that derived classes may make use of)
		private void ComponentWillReceiveProps(WrappedValue<TProps> nextPropsIfAny)
		{
			ComponentWillReceiveProps(ComponentPropsHelpers.UnWrapValueIfDefined(nextPropsIfAny));
		}
		private bool ShouldComponentUpdate(WrappedValue<TProps> nextPropsIfAny, WrappedValue<TState> nextStateIfAny)
		{
			return ShouldComponentUpdate(ComponentPropsHelpers.UnWrapValueIfDefined(nextPropsIfAny), ComponentPropsHelpers.UnWrapValueIfDefined(nextStateIfAny));
		}
		private void ComponentWillUpdate(WrappedValue<TProps> nextProps, WrappedValue<TState> nextState)
		{
			ComponentWillUpdate(ComponentPropsHelpers.UnWrapValueIfDefined(nextProps), ComponentPropsHelpers.UnWrapValueIfDefined(nextState));
		}
		private void ComponentDidUpdate(WrappedValue<TProps> previousProps, WrappedValue<TState> previousState)
		{
			ComponentDidUpdate(ComponentPropsHelpers.UnWrapValueIfDefined(previousProps), ComponentPropsHelpers.UnWrapValueIfDefined(previousState));
		}
	}
}
