using System;

namespace Bridge
{
	public class Union<T1, T2>
	{
		public static implicit operator Union<T1, T2>(T1 source) { throw new NotImplementedException(); }
	}

	public class EnumAttribute : Attribute
	{
		public EnumAttribute(Emit emit) { }
	}
	public class ExternalAttribute : Attribute { }
	public class IgnoreGenericAttribute : Attribute { }
	public class NameAttribute : Attribute
	{
		public NameAttribute(string name) { }
	}
	public class ObjectLiteralAttribute : Attribute
	{
		public ObjectLiteralAttribute() { }
		public ObjectLiteralAttribute(ObjectCreateMode createMode) { }
	}
	public class TemplateAttribute : Attribute
	{
		public TemplateAttribute(string name) { }
	}

	public enum Emit { StringNameLowerCase }
	public enum ObjectCreateMode { Plain }

	public static class Script
	{
		public static void Write(string script, params object[] args) { throw new NotImplementedException(); }
		public static T Write<T>(string script, params object[] args) { throw new NotImplementedException(); }
	}

	public static class BridgeExtensions
	{
		public static string[] Split(this string source, string separator) { return source.Split(new[] { separator }, StringSplitOptions.None); }
		public static Array Concat(this Array source, Array toAdd) { throw new NotImplementedException(); }
	}
}