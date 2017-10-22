# Bridge.React
Bindings for [Bridge.NET](http://bridge.net/) for React - write React applications in C#!

(If you want to see these bindings in use in a sample application, this repo includes a "ToDo list" example in the Bridge.React.Examples folder).

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
