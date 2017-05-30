using System;
using Bridge.Html5;
using static Bridge.QUnit.QUnit;

namespace Bridge.React.Tests
{
	public static class DataAttributeTests
	{
		public static void RunTests()
		{
			Module("DataAttribute Tests");

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

			Test("DOM.Div with ClassName-only attributes (no data attributes)", assert =>
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

			Test("DOM.Div with ClassName and empty data value", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Data = null }, "Hello"),
					container => {
						assert.Ok(true); // Only making sure that a null attributes references doesn't break thing (so no need to check markup)
						done();
						container.Remove();
					}
				);
			});

			Test("DOM.Div with ClassName and data 'toggle' value", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Data = new { toggle = "on" } }, "Hello"),
					container =>
					{
						container.Remove();
						var div = container.QuerySelector("div.test") as HTMLElement;
						if (div == null)
							throw new Exception("Unable to locate 'test' div");
						assert.StrictEqual(div.GetAttribute("data-toggle"), "on");
						done();
					}
				);
			});

			Test("DOM.Div with ClassName and data 'toggle_me' value (to demonstrate underscore-to-hyphen string name replacement)", assert =>
			{
				var done = assert.Async();
				TestComponentMounter.Render(
					DOM.Div(new Attributes { ClassName = "test", Data = new { toggle_me = "on" } }, "Hello"),
					container =>
					{
						container.Remove();
						var div = container.QuerySelector("div.test") as HTMLElement;
						if (div == null)
							throw new Exception("Unable to locate 'test' div");
						assert.StrictEqual(div.GetAttribute("data-toggle-me"), "on");
						done();
					}
				);
			});
		}
	}
}