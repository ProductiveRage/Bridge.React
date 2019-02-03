using System;
using Bridge.Html5;
using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public static class AriaAttributeTests
	{
		public static void RunTests()
		{
			Module("AriaAttribute Tests");

			Test("DOM.Div with null attributes", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(null, "Hello"),
					container => {
						assert.Ok(true); // Only making sure that a null attributes references doesn't break thing (so no need to check markup)
						done();
						container.Remove();
					}
				);
			});

			Test("DOM.Div with ClassName-only attributes (no aria attributes)", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test" }, "Hello"),
					container => {
						assert.Ok(true); // Only making sure that a null attributes references doesn't break thing (so no need to check markup)
						done();
						container.Remove();
					}
				);
			});

			Test("DOM.Div with ClassName and empty aria value", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Aria = null }, "Hello"),
					container => {
						assert.Ok(true); // Only making sure that a null attributes references doesn't break thing (so no need to check markup)
						done();
						container.Remove();
					}
				);
			});

			Test("DOM.Div with ClassName and aria 'toggle' value", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Aria = new { toggle = "on" } }, "Hello"),
					container =>
					{
						container.Remove();
						var div = container.QuerySelector("div.test") as HTMLElement;
						if (div == null)
							throw new Exception("Unable to locate 'test' div");
						assert.StrictEqual(div.GetAttribute("aria-toggle"), "on");
						done();
					}
				);
			});

			Test("DOM.Div with ClassName and aria 'toggle_me_on' value (to demonstrate underscore-to-hyphen string name replacement)", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Aria = new { toggle_me_on = "on" } }, "Hello"),
					container =>
					{
						container.Remove();
						var div = container.QuerySelector("div.test") as HTMLElement;
						if (div == null)
							throw new Exception("Unable to locate 'test' div");
						assert.StrictEqual(div.GetAttribute("aria-toggle-me-on"), "on");
						done();
					}
				);
			});
		}
	}
}