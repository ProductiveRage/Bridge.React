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

			return type.ContainingAssembly.Identity.Name == "Bridge.React";
		}
	}
}
