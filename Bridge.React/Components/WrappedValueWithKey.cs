namespace Bridge.React
{
	[ObjectLiteral(ObjectCreateMode.Plain)]
	internal class WrappedValueWithKey<TValue> : WrappedValue<TValue>
	{
		public Union<string, int> Key { get; set; }
	}
}