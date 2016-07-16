using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.React
{
	/// <summary>
	/// This provides a class which may be derived from in order to declare React components. Due to the way that React initialises components, it is important that derived classes
	/// do not perform any logic or initialisation in their constructor, nor may they have any other configuration passed into their constructor but that which is described by the
	/// props (and state, where applicable) data. The constructors will not be executed and so any logic or member initialisation in there will be silenty ignored.
	/// </summary>
	public abstract class Component<TProps, TState>
	{
		private static object _reactComponentClass = null;
		private readonly ReactElement _reactElement;
		protected Component(TProps props, params Any<ReactElement, string>[] children)
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
			// for it. The internal React mechanism means that the component's constructor will not be executed, which is why ALL state and configuration options for a
			// component must be contained within the props (and state, where appropriate). Note: In most cases where children are specified as a params array, we don't want
			// the "children require unique keys" warning from React (you don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here
			// either - to achieve this, we prepare an arguments array and pass that to React.createElement in an "apply" call.
			Array createElementArgs = new object[] { _reactComponentClass, ComponentHelpers<TProps>.WrapProps(props) };
			if (children != null)
				createElementArgs = createElementArgs.Concat(children);
			_reactElement = Script.Write<ReactElement>("React.createElement.apply(null, createElementArgs)");
		}

		private object CreateReactComponentClass()
		{
			// For each derived class we need to create React component class, this is like a template for the form of the component - individual instances will be created by
			// taking this template and using React.createElement to prepare a new element with the specified props. There should only be one React component class per unique
			// class but multiple React elements - one per instance of the class. The template is prepared by taking the first instance of any component class and ensuring
			// promoting all functions from the class prototype (which is where they will be defined for Bridge classes) since React's internal logic uses hasOwnProperty when
			// looking for key functions such as "render". Most functions can be promoted in a simple manner but there are some exceptions - "constructor" must be ignored
			// (otherwise React will raise a warning "You are attempting to define `constructor` on your component more than once" and "setState") and any of the component
			// lifecycle methods that involves props or state access need special handling. This is because React presumes that all props and state objects will be simple
			// object literals and they get picked apart during processing - so if a Bridge class is used for the props object that has a "name" property with "getName" and
			// "setName" functions on the prototype then React will maintain the "name" value but lose the getter and setter. The way around this is to stash the props object
			// in a simple wrapper with a "value" property which React will allow through its internals since it doesn't recursively meddle with the data - this "value" may be
			// a Bridge class (or an ObjectLiteral, it doesn't matter). The only complications around this approach are that anywhere that props are accessed, a redirection is
			// required - so that the component class gets the "value" reference. This counts not only for components' "this.props" access but also for functions such as
			// "componentWillReceiveProps" since the C# code will expect the "nextProps" value to be of type TProps and not a wrapper with a "value" property of type TProps.
			// The same logic goes for the state reference. Note that this effectively means that state is completely replaced when the "SetState" function is called, since the
			// single "value" reference is over-written. This makes the "SetState" implementation here closer to "replaceState" in React, but I didn't name it "ReplaceState"
			// instead of "SetState" since the React 0.14 docs say that that function may be removed in the future. However, "SetState" replacing the entire state reference,
			// rather than merging it with whatever data is already there is - I think - the least surprising approach when considered in terms of C#; it makes more sense to
			// replace the current data with the new reference, rather than merge - merging is not a common action in C#, though it is in JavaScript (eg. merging default
			// "options" with any explicit settings in many JavaScript APIs).
			var className = this.GetClassName().Split(".").Last();
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

			// .. then overwrite the functions that need special treatment (lifecycle functions involving props and/or state)
			var getInitialState = bridgeComponentInstance.getInitialState;
			bridgeComponentInstance.getInitialState = function (state) {
				return { value: getInitialState.apply(this) };
			};
			var componentWillReceiveProps = bridgeComponentInstance.componentWillReceiveProps;
			bridgeComponentInstance.componentWillReceiveProps = function (nextProps) {
				componentWillReceiveProps.apply(this, [ nextProps ? nextProps.value : nextProps ]);
			};
			var shouldComponentUpdate = bridgeComponentInstance.shouldComponentUpdate;
			bridgeComponentInstance.shouldComponentUpdate = function (nextProps, nextState) {
				return shouldComponentUpdate.apply(this, [ nextProps ? nextProps.value : nextProps, nextState ? nextState.value : nextState ]);
			};
			var componentWillUpdate = bridgeComponentInstance.componentWillUpdate;
			bridgeComponentInstance.componentWillUpdate = function (nextProps, nextState) {
				componentWillUpdate.apply(this, [ nextProps ? nextProps.value : nextProps, nextState ? nextState.value : nextState ]);
			};
			var componentDidUpdate = bridgeComponentInstance.componentDidUpdate;
			bridgeComponentInstance.componentDidUpdate = function (previousProps, previousState) {
				componentDidUpdate.apply(this, [ previousProps ? previousProps.value : previousProps, previousState ? previousState.value : previousState ]);
			};
			reactComponentClass = React.createClass(bridgeComponentInstance);
			*/
			return reactComponentClass;
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
		/// State is not used by all components and so this may be null
		/// </summary>
		protected TState state
		{
			// If tate is non-null then it needs to be "unwrapped" when the C# code requests it
			get { return Script.Write<TState>("this.state ? this.state.value : null"); }
		}

		/// <summary>
		/// This will never be null nor contain any null references, though it may be empty if there are no children to render
		/// </summary>
		protected Any<ReactElement, string>[] Children
		{
			get { return Script.Write<Any<ReactElement, string>[]>("this.props && this.props.children ? this.props.children : []"); }
		}

		public static implicit operator ReactElement(Component<TProps, TState> component)
		{
			if (component == null)
				throw new ArgumentNullException("component");

			return component._reactElement;
		}

		public static implicit operator Any<ReactElement, string>(Component<TProps, TState> component)
		{
			if (component == null)
				throw new ArgumentNullException("component");

			return component._reactElement;
		}

		/// <summary>
		/// State is not used by all components and so it is valid to return null from any implementation of this function
		/// </summary>
		protected virtual TState GetInitialState() { return default(TState); }

		protected virtual void ComponentWillMount() { }

		protected virtual void ComponentDidMount() { }

		/// <summary>
		/// Props is not used by all components and so it is valid for the nextProps reference passed up here to be null
		/// </summary>
		protected virtual void ComponentWillReceiveProps(TProps nextProps) { }

		/// <summary>
		/// If this returns false then the proposed component update will be cancelled - this may be used as an optimisation to avoid unnecessary updates. Since deep equality
		/// checks can be expensive, taking advantage of this mechanism is easiest when the props and state types are immutable and so equality checks are as simple (and cheap)
		/// as a reference equality test. Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed
		/// up here to be null.
		/// </summary>
		protected virtual bool ShouldComponentUpdate(TProps nextProps, TState nextState) { return true; }

		/// <summary>
		/// Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed up here to be null
		/// </summary>
		protected virtual void ComponentWillUpdate(TProps nextProps, TState nextState) { }

		/// <summary>
		/// Props and State are not used by all components and so it is valid for either or both of the nextProps and nextState references passed up here to be null
		/// </summary>
		protected virtual void ComponentDidUpdate(TProps previousProps, TState previousState) { }

		protected virtual void ComponentWillUnmount() { }

		public abstract ReactElement Render();

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
		protected void SetState(TState state, Action action)
		{
			Script.Write("this.setState({ value: state }, action)");
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
	}
}
