using System;

namespace Bridge.React
{
	[Obsolete("Support for Actions attributed to different sources (i.e. View vs. Server actions) will be removed from the IDispatcher interface. MessageSourceOptions should no longer be used.")]
	public enum MessageSourceOptions
	{
		Server,
		View
	}
}