using System;
using System.Linq;

namespace Bridge.React
{
	internal static class ComponentNameHelpers
	{
		internal static string GetDisplayName(object source)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			if (Script.Write<bool>("Bridge.isPlainObject(source)"))
				return "Component";

			return source.GetType().Name.Split('.', '[', '$', '`').First();
		}
	}
}