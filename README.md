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

## Using third party / non-Bridge.NET components

Bridge supports multiple ways to interact with other JavaScript code, such as emitting raw JavaScript using "Script.Write" and by creating binding classes for the JavaScript types that you wish to work with.

As an example, take this component (from [The React Quick Start Guide: ES6 Edition](https://forums.bridge.net/forum/community/help/3959-bride-react-fails-on-master-branch)) -

	class Photo extends React.Component {
		render() {
			return (
				<div className='photo'>
					<img src={this.props.src} />
					<span>{this.props.caption}</span>
				</div>
			)
		}
	}

If you were writing JavaScript to render an instance of this component then you might do something like the following:

	ReactDOM.render(
  		React.createElement(
			Photo,
			{
				src: 'http://www.petmd.com/sites/default/files/what-does-it-mean-when-cat-wags-tail.jpg',
				caption: 'Cat!'
			}
		),
	  	document.getElementById('main')
	);

Perhaps the simplest way to wrap this up for use within a Bridge application would be to create a factory method for the Photo component - eg.

	public static class Photo
	{
		public static ReactElement Render(string src, string caption)
		{
			return Script.Write<ReactElement>("React.createElement(Photo, { src: src, caption: caption })");
		}
	}
	
This would allow you to write Bridge.NET code such as:

	React.render(
		Photo.Render(
			src: 'http://www.petmd.com/sites/default/files/what-does-it-mean-when-cat-wags-tail.jpg',
			caption: 'Cat!'
		),
	  	Document.GetElementById('main')
	);

Alternatively, you may wish to expose the component more like a traditional class, in which case you would write binding classes for the component and its props - eg.

	[External]
	public sealed class Photo
	{
		[Template("React.createElement(Photo, {props})")]
		public Photo(Props props) { }

		public static implicit operator ReactElement(Photo source)
		{
			return Script.Write<ReactElement>("source");
		}

		[ObjectLiteral]
		public sealed class Props
		{
			public string src { get; set; }
			public string caption { get; set; }
		}
	}

This would allow you to write Bridge.NET code like this:

	React.render(
		new Photo(new Photo.Props {
			src: 'http://www.petmd.com/sites/default/files/what-does-it-mean-when-cat-wags-tail.jpg',
			caption: 'Cat!'
		}),
	  	Document.GetElementById('main')
	);

You may prefer one approach or the other - possibly depending upon whether you prefer to think in functions or classes and possibly depending upon the complexity of the component.