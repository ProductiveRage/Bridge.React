using System;
using System.Text.RegularExpressions;

namespace Bridge
{
	public class Any<T1, T2>
	{
		public static implicit operator Any<T1, T2>(T1 source) { throw new NotImplementedException(); }
	}

	public class ExternalAttribute : Attribute { }
	public class NameAttribute : Attribute
	{
		public NameAttribute(string name) { }
	}
	public class ObjectLiteralAttribute : Attribute { }

	public static class Script
	{
		public static void Write(string script) { throw new NotImplementedException(); }
		public static T Write<T>(string script) { throw new NotImplementedException(); }
	}

	public static class BridgeExtensions
	{
		public static string GetClassName(this object source) { throw new NotImplementedException(); }
		public static string[] Split(this string source, string separator) { return source.Split(new[] { separator }, StringSplitOptions.None); }
		public static Array Concat(this Array source, Array toAdd) { throw new NotImplementedException(); }
	}
}