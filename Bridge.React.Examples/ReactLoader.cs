namespace Bridge.ReactLoader.Application
{
	/// <summary>
	/// This file is added to the project by the Bridge.ReactLoader NuGet package and should not be edited manually (if you update the NuGet package then this file will be replaced and so any
	/// manual changes would be lost)
	/// </summary>
	internal static class LibraryLoader
	{
		private static void LoadAppropriateVersion()
		{
#if DEBUG
			BridgeReactDebug.DebugBuild.Include();
#else
			BridgeReactRelease.ReleaseBuild.Include();
#endif
		}
	}
}
