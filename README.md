# Bridge.React
Bindings for [Bridge.NET](http://bridge.net/) for React - write React applications in C#!

For more information, there is a working example at [bitbucket.org/DanRoberts/reactbridgedotnet](https://bitbucket.org/DanRoberts/reactbridgedotnet/). I'm publishing this bindings-only repository on GitHub since GitHub seems to be many people's first and last port of call! Any changes, fixes or updates made to the Bitbucket example will be pulled forward here.

As well as the basic library calls (such as React.Render and the DOM factory methods like div, span, etc..) there are two base classes to make creating custom components simple in C#; "Component" and "StatelessComponent". Below is a very simple example that illustrates all of this -

	using System;
	using Bridge.Html5;
	using Bridge.React;

	namespace BridgeExamples
	{
		public class Start
		{
			[Ready]
			public static void Main()
			{
				React.Render(
					new MessageEntryForm("Name:", value => Window.Alert("Save \"" + value + "\"")),
					Document.GetElementById("main")
				);
			}
		}

		public class MessageEntryForm : Component<MessageEntryForm.Props, MessageEntryForm.State>
		{
			public MessageEntryForm(string label, Action<string> onSave)
				: base(new Props { Label = label, OnSave = onSave }) { }

			protected override MessageEntryForm.State GetInitialState()
			{
				return new State { Value = "" };
			}

			public override ReactElement Render()
			{
				return DOM.Div(new Attributes { ClassName = "wrapper" },
					DOM.Label(null, props.Label),
					DOM.Input(new InputAttributes
					{
						Value = state.Value,
						OnChange = e => SetState(new State { Value = e.CurrentTarget.Value })
					}),
					DOM.Button(
						new ButtonAttributes
						{
							Disabled = string.IsNullOrWhiteSpace(state.Value),
							OnClick = e => props.OnSave(state.Value)
						},
						"Save"
					)
				);
			}

			public class Props
			{
				public string Label;
				public Action<string> OnSave;
			}

			public class State
			{
				public string Value;
			}
		}
	}
	
## A warning against Bridge's "preserveMemberCase" option

When Bridge translates C# into JavaScript, by default it will change pascal-named class member names (eg. "GetName"), which are commonly used in C#, into the camel-cased names (eg. "getName"), as are more commonly seen in JavaScript code. If you don't like this option then you may set an option in your bridge.json file -

    preserveMemberCase: true
	
However, if you do so, then you will not be able to use this library (or, indeed, almost any other Bridge.NET library that isn't also built with "preserveMemberCase: true").

There is a bug report about this problem open with the Bridge Team (see "[preserveMemberCase causes errors when referencing project without preserveMemberCase](http://forums.bridge.net/forum/community/help/3314-preservemembercase-causes-errors-when-referencing-project-without-preservemembercase)") but there are internal discussions how best to fix it. Until then, I strongly recommend against using preserveMemberCase!