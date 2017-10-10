using System;

namespace Bridge.React
{
	/// <summary>
	/// While the class-based component structure (using the PureComponent and StatelessComponent base classes) is very convenient and feels natural, there is some overhead to
	/// constructing the component instances. For the vast majority of the time, this will probably not cause any problems. However, if you have a page where you may need to
	/// update 1000s of elements at a time then this construction cost may become non-neligible. An alternative is to use static render methods instead of component classes.
	/// The methods in this class make that possible - the render methods used provided must take a single props argument and return a ReactElement. If the props type supports
	/// shallow comparison for change detection (which is highly recommended but often requires immutable types to be used for all properties) then the Pure method should be
	/// used; this will result in a component with a ShouldComponentUpdate implementation that will tell React not to re-render if the props data hasn't changed. If the props
	/// type does not support shallow comparison then the Stateless method should be used; this uses a lighter weight structure to create the React element but there is no
	/// way to support a ShouldComponentUpdate mechanism.
	/// </summary>
	public static class StaticComponent
	{
		/// <summary>
		/// Use this if the props type supports shallow comparison (which generally requires immutable types to be used for all of the props values) - the resulting component
		/// will automatically be assigned a ShouldComponentUpdate function so that re-renders of the component may be avoided if the props data has not changed.
		/// </summary>
		public static ReactElement Pure<TProps>(Func<TProps, ReactElement> renderer, TProps props)
		{
			/*@
			var componentClass = renderer.$$componentClass;
			if (!componentClass) {
				var doPropsReferencesMatch = this.doPropsReferencesMatch;
				componentClass = React.createClass({
					displayName: renderer.name,
					render: function () {
						return renderer(this.props.value);
					},
					shouldComponentUpdate: function (nextProps, nextState) {
						return !doPropsReferencesMatch(this.props ? this.props.value : null, nextProps ? nextProps.value : null);
					}
				});
				renderer.$$componentClass = componentClass;
			}
			*/
			var wrappedProps = ComponentPropsHelpers.WrapProps(props);
			return Script.Write<ReactElement>("React.createElement(componentClass, wrappedProps)");
		}

		/// <summary>
		/// Use this if the props type does not support shallow comparisons
		/// </summary>
		public static ReactElement Stateless<TProps>(Func<TProps, ReactElement> renderer, TProps props)
		{
			/*@
			var namedScopeBoundFunction;
			eval("namedScopeBoundFunction = function " + renderer.name + "(props) { return renderer(props ? props.value : props); };");
			*/
			var wrappedProps = ComponentPropsHelpers.WrapProps(props);
			return Script.Write<ReactElement>("React.createElement(namedScopeBoundFunction, wrappedProps)");
		}

		/// <summary>
		/// This method is just here to make it easier for the native JavaScript in the method above to call the static function in the ComponentPropsHelpers
		/// class without us having to bake in the way that Bridge represents static functions on classes
		/// </summary>
		[IgnoreGeneric]
		internal static bool DoPropsReferencesMatch<TProps>(TProps props1, TProps props2)
		{
			return ComponentPropsHelpers.DoPropsReferencesMatch(props1, props2);
		}
	}
}
