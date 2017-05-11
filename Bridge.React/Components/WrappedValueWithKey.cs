namespace Bridge.React
{
	[ObjectLiteral(ObjectCreateMode.Plain)]
	internal class WrappedValueWithKey<T> : WrappedValue<T>
	{
		public Union<string, int> Key { get; set; }
	}
}