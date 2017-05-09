using System;
using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public sealed class PropInstanceComparisonTests
	{
		public static PropInstanceComparisonTests Instance { get; } = new PropInstanceComparisonTests();
		private PropInstanceComparisonTests() { }

		public void RunTests()
		{
			Module("PureComponent props comparisons (for ShouldComponentUpdate implementation)");

			Test("Two instances of single-string-property class where string values match", assert =>
			{
				assert.StrictEqual(
					ComponentPropsHelpers<SingleStringPropertyClass>.DoPropsReferencesMatch(
						new SingleStringPropertyClass("abc"),
						new SingleStringPropertyClass("abc")
					),
					true
				);
			});

			Test("Two instances of single-function-property class where functions are equivalent anonymous static lambdas that Bridge lifts to named methods", assert =>
			{
				assert.StrictEqual(
					ComponentPropsHelpers<SingleFunctionPropertyClass>.DoPropsReferencesMatch(
						new SingleFunctionPropertyClass(value => Console.WriteLine(value)),
						new SingleFunctionPropertyClass(value => Console.WriteLine(value))
					),
					true
				);
			});

			Test("Two instances of single-function-property class where functions are equivalent bound functions", assert =>
			{
				assert.StrictEqual(
					ComponentPropsHelpers<SingleFunctionPropertyClass>.DoPropsReferencesMatch(
						new SingleFunctionPropertyClass(InstanceMethod),
						new SingleFunctionPropertyClass(InstanceMethod)
					),
					true
				);
			});

			// These two props instances will be given then exact same reference, so this is a really easy case
			Test("Two instances of single-function-property class where functions are the same function property on a known reference", assert =>
			{
				var bindToTarget = new SingleFunctionPropertyClass(value => Console.WriteLine(value));
				assert.StrictEqual(
					ComponentPropsHelpers<SingleFunctionPropertyClass>.DoPropsReferencesMatch(
						new SingleFunctionPropertyClass(bindToTarget.OnChange),
						new SingleFunctionPropertyClass(bindToTarget.OnChange)
					),
					true
				);
			});

			/* TODO: Not sure if can support this - could look at the functions' ToString values but they could be bound to different targets using JS .bind and that information
			   is not accessible and so the comparison may not be reliable
			Test("Two instances of single-function-property class where functions are equivalent anonymous static lambdas that Bridge can't lift to named methods", assert =>
			{
				var outerValue = "abc"; // Having the lambdas access this value prevents them from being lifted into their own methods
				assert.StrictEqual(
					ComponentPropsHelpers<SingleFunctionPropertyClass>.DoPropsReferencesMatch(
						new SingleFunctionPropertyClass(value => Console.WriteLine(outerValue + ":" + value)),
						new SingleFunctionPropertyClass(value => Console.WriteLine(outerValue + ":" + value))
					),
					true
				);
			});
			*/
		}

		private void InstanceMethod(string value) { }

		public sealed class SingleStringPropertyClass
		{
			public SingleStringPropertyClass(string name)
			{
				Name = name;
			}
			public string Name { get; }
		}

		public sealed class SingleFunctionPropertyClass
		{
			public SingleFunctionPropertyClass(Action<string> onChange)
			{
				OnChange = onChange;
			}
			public Action<string> OnChange { get; }
		}

		public sealed class SingleActionPropertyClass
		{
			public SingleActionPropertyClass(Action work)
			{
				Work = work;
			}
			public Action Work { get; }
		}
	}
}
