using System;

namespace Bridge.React
{
	[ObjectLiteral(ObjectCreateMode.Plain)]
	internal class WrappedValueWithRef<TValue, TComponent> : WrappedValue<TValue>
	{
		public Action<TComponent> Ref { get; set; }
	}
}