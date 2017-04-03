using System;
using Microsoft.CodeAnalysis;

namespace Bridge.React.Analyser
{
	public static class ITypeSymbolExtensions
	{
		public static bool IsPartOfBridgeReact(this ITypeSymbol type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			// If the type is "object[]" then ContainingAssembly wil be null - if so, ignore it (we don't want to throw an NRE)
			return type.ContainingAssembly?.Identity.Name == "Bridge.React";
		}
	}
}
