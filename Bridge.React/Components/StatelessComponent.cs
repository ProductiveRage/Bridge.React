using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React
{
	public abstract class StatelessComponent<TProps>
	{
		private static Dictionary<Type, Func<TProps, ReactElement>> _reactStatelessRenderFunctions = new Dictionary<Type, Func<TProps, ReactElement>>();
		private readonly ReactElement _reactElement;
		protected StatelessComponent(TProps props, params Union<ReactElement, string>[] children)
		{
			if (children != null)
			{
				if (children.Any(element => element == null))
					throw new ArgumentException("Null reference encountered in children set");
			}

			// When preparing the "_reactStatelessRenderFunction" reference, a local "reactStatelessRenderFunction" alias is used - this is just so that the JavaScript
			// code further down (which calls React.createElement) can use this local alias and not have to know how Bridge stores static references.
			Func<TProps, ReactElement> reactStatelessRenderFunction;
			var currentType = ((object)this).GetType(); // Cast to object first in case derived class uses [IgnoreGeneric] - see http://forums.bridge.net/forum/bridge-net-pro/bugs/3343
			if (!_reactStatelessRenderFunctions.TryGetValue(currentType, out reactStatelessRenderFunction))
			{
				reactStatelessRenderFunction = CreateStatelessRenderFunction();
				_reactStatelessRenderFunctions[currentType] = reactStatelessRenderFunction;
			}

			// When we pass the props reference to React.createElement, React's internals will rip it apart and reform it - which will cause problems if TProps is a
			// class with property getters and setters (or any other function) defined on the prototype, since members from the class prototype are not maintained
			// in this process. Wrapping the props reference into a "value" property gets around this problem, we just have to remember to unwrap them again when
			// we render. In most cases where children are specified as a params array, we don't want the "children require unique keys" warning from React (you
			// don't get it if you call DOM.Div(null, "Item1", "Item2"), so we don't want it in most cases here either - to achieve this, we prepare an arguments
			// array and pass that to React.createElement in an "apply" call. Similar techniques are used in the stateful component.
			Array createElementArgs = new object[] { reactStatelessRenderFunction, ComponentPropsHelpers.WrapProps(props) };
			if (children != null)
				createElementArgs = createElementArgs.Concat(children);
			_reactElement = Script.Write<ReactElement>("React.createElement.apply(null, createElementArgs)");
		}

		private Func<TProps, ReactElement> CreateStatelessRenderFunction()
		{
			// We need to prepare a function to give to React.createElement that takes a props reference and maintains that for the instance of the element for the
			// duration of the Render call AND for any work that might happen later, such as in an OnChange callback (or other event-handler). To do this, we need an
			// instance that will capture this props value and that has all of the functionality of the original component (such as any functions that it has). The
			// best way that I can think of is to use Object.create to prepare a new instance, taking the prototype of the component class, and then setting its
			// props reference, then wrapping this all in a function that calls its Render function, binding to this instance. This woud mean that the constructor
			// would not get called on the component, but that's just the same as for stateful components (from the Component class).
			/*@
			var classPrototype = this.constructor.prototype;
			var scopeBoundFunction = function(props) {
				var target = Object.create(classPrototype);
				target.props = props;
				return target.render.apply(target, []);
			}
			*/

			// We have an anonymous function for the renderer now but it would better to name it, since React Dev Tools will use show the function name (if defined) as
			// the component name in the tree. The only way to do this is, unfortunately, with eval - but the only dynamic content is the class name (which should be
			// safe to use since valid C# class names should be valid JavaScript function names, with no escaping required) and this work is only performed once per
			// class, since it is stored in a static variable - so the eval calls will be made very infrequently (so performance is not a concern).
			var className = ComponentNameHelpers.GetDisplayName(this);
			Func<TProps, ReactElement> namedScopeBoundFunction = null;
			/*@
			eval("namedScopeBoundFunction = function " + className + "(props) { return scopeBoundFunction(props); };");
			*/
			return namedScopeBoundFunction;
		}

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
				// See notes in PureComponent's Children property for details about what's going on here
				return Script.Write<Union<ReactElement, string>[]>("this.props && this.props.children ? (Array.isArray(this.props.children) ? this.props.children : [this.props.children]) : []");
			}
		}

		public abstract ReactElement Render();

		public static implicit operator ReactElement(StatelessComponent<TProps> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null StatelessComponent reference will pass through this operator method and
			// so null needs to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}

		public static implicit operator Union<ReactElement, string>(StatelessComponent<TProps> component)
		{
			// Since React 0.11 (see https://facebook.github.io/react/blog/2014/07/17/react-v0.11.html), it has been acceptable to return null from a Render method to
			// indicate that nothing should be rendered. As such, it's possible that a null StatelessComponent reference will pass through this operator method and
			// so null needs to be allowed (previously this would throw a ArgumentNullException for a null component).
			if (component == null)
				return null;
			return component._reactElement;
		}
	}
}
