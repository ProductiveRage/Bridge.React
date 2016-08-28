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
				return source.ToString();

			// There appears to be a bug in Bridge 15.0 which means that the GetClassName method function returns the wrong value, but accessing the (undocumented) $$name
			// property still works - so we'll use that for now. See http://forums.bridge.net/forum/bridge-net-pro/bugs/2613-change-to-getclassname-behaviour.
			return Script.Write<string>("source.$$name").Split(".").Last();
		}
	}
}