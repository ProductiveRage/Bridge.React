using System;

namespace Bridge.React
{
	[ObjectLiteral(ObjectCreateMode.Plain)]
	internal class WrappedValueWithKeyAndRef<TValue, TComponent> : WrappedValue<TValue>
	{
		public Union<string, int> Key { get; set; }

		public Action<TComponent> Ref { get; set; }
	}
}