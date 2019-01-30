# Bridge.React
Bindings for [Bridge.NET](http://bridge.net/) for React - write React applications in C#!

As well as the basic library calls (such as React.Render and the DOM factory methods like div, span, etc..) there are three base classes to make creating custom components simple in C#; **Component**, **StatelessComponent** and **PureComponent**. Below is a very simple example that illustrates all of this -

	using System;
	using Bridge.Html5;
	using Bridge.React;

	namespace BridgeExamples
	{
		public class Start
		{
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

The **Component** base class is intended to allow you to write stateful "Container" components (to use the terminology from the article [Presentational and Container Components](https://medium.com/@dan_abramov/smart-and-dumb-components-7ca2f9a7c7d0)) while **StatelessComponent** and **PureComponent** are for writing components that have only Props and no State.

Ideally, components would rely *only* upon information in their Props reference - in which case they are considered "pure" because they rely solely upon their Props input and ambient references. If a component displayed the current time by using directly accessing DateTime.Now, for example, then that would not be "pure" because its rendering would require information outside of its Props reference. Almost all "Presentation" components should be pure and so should be derived from the **PureComponent** base class.

The **PureComponent** has a builtin "ShouldComponentUpdate" implementation that will return false if the old Props and the new Props contain values that appear to be equivalent, which often means that React has less "reconciliation" work to do and so is a nice optimisation to get for free (the **PureComponent** is similar to React's own **PureComponent** implementation but it is written to better understand Bridge.NET - for example, it supports equality checks using an "Equals" method instead of requiring reference equality and it understands that two bound functions that point at the same function and the same bind-target are equivalent).

I find that these bindings work very well with my [ProductiveRage.Immutable](https://github.com/ProductiveRage/Bridge.Immutable) library because that makes it easier to model immutable types, which all component Props and State types would ideally be (React expects Props and State references to remain consistent and for completely new references to be provided when a component must be given new Props or State - being able to describe this with the type system can be very beneficial). The code further up does not use that library but if you would like to see a sample application that uses the Bridge.React bindings *and* ProductiveRage.Immutable then you may find a "Todo list" project in the Bridge.React.Examples folder of this repo.

### Loading the React JavaScript library

This library / NuGet package only provides *bindings* to the React library, it is presumed that the library itself will be present at runtime (which can be as simple as including the appropriate script tag into the HTML of the application page). However, if you want to pull in the React library through a NuGet package (benefits include not having to include the script tag into your HTML manually and being able to track the React library version in the same way as you track other third party NuGet dependencies) then check out the [Bridge.ReactLoader](https://github.com/ProductiveRage/Bridge.ReactLoader).

## Support for data-* and aria-* HTML element DOM attributes

React natively supports passing any data-* and aria-* attributes directly into the DOM elements as mentioned here:

https://reactjs.org/docs/dom-elements.html

However there is no easy way to define those as a part of the type safe attributes classes when using Bridge to compile C# to Javascript. To support this there is dynamic "Data" and "Aria" properties that allows you to set any values that you want. Any property name within the Data or Aria object will be extracted into individual "data-*" and "aria-*" properties when passed to React - eg.

    new Attributes { 
        ClassName = "toggler", 
        Data = new { 
            toggle_me = "yes-please" 
        },
        Aria = new { 
            hidden = "true" 
        }
    }

will become

    { 
        "className": "toggler", 
        "data-toggle-me": "yes-please",
        "aria-hidden": "true" 
    }

Since C# does not allow hyphens in property names but these are quite common in data attribute names, any underscores in the "Data" or "Aria" reference property names will be replaced with hyphens (hopefully there aren't any / many "data-*" attribute names in use that want underscores!).

You can include as many or as few properties in the "Data" and "Aria" objects as you want to. Ensure that you don't repeat the "Data" or "Aria" part of the names, though - note that in the above example, the "Data" property is called "toggle_me" and not "data_toggle_me".

At runtime this is supported via the Bridge.React.fixAttr() function, so if you are writing you own bindings keep that in mind as shown in the example below.

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
		[Template("React.createElement(Photo, Bridge.React.fixAttr({props}))")]
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

Note the use of Bridge.React.fixAttr() to process the properties before it is passed to the underlying class. Make sure you use this if you wish to be able to pass down expanded data- and aria- properties to the underlying component.

You may prefer one approach or the other - possibly depending upon whether you prefer to think in functions or classes and possibly depending upon the complexity of the component.