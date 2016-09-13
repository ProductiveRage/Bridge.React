using System;

namespace Bridge.React
{
	internal static class ComponentNameHelpers
	{
		internal static string GetDisplayName(object source)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			if (Script.Write<bool>("Bridge.isPlainObject(source)"))
				return source.ToString();

			return source.GetType().FullName;
		}
	}
}