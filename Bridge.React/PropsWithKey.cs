namespace Bridge.React
{
	/// <summary>
	/// When creating custom components that may be used as part of a list of dynamic children elements, it is important that each component instance be able to
	/// have a unique key provided to them. To try to make this as simple as possible, props classes for custom components may be derived from this class and the
	/// key passed in and maintained for access by React. The Key property itself is private since there is no need for the custom component to access the key -
	/// it is important only that the parent of the component be able to provide the component with a key and that React be able to retrieve that key.
	/// </summary>
	public abstract class PropsWithKey
	{
		protected PropsWithKey(Union<int, string> key)
		{
			Key = key;
		}
		private Union<int, string> Key { get; set; }
	}
}