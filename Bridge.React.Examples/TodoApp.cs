using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.React.Examples
{
	public class TodoApp : Component<TodoApp.Props, TodoApp.State>
	{
		private int _nextAvailableId = 0;
		public TodoApp(string label) : base(new Props { Label = label }) { }

		protected override State GetInitialState()
		{
			return new State
			{
				InputValue = "",
				Todos = new Todo[]
				{
					new Todo { Id = _nextAvailableId++, Description = "Learn C#", Done = true },
					new Todo { Id = _nextAvailableId++, Description = "Learn React", Done = false },
					new Todo { Id = _nextAvailableId++, Description = "Build an awesome app with C# and React", Done = false }
				}
			};
		}

		private State AppendTodo(string todoDescription)
		{
			var count = state.Todos.Count();
			var todo = new Todo
			{
				Description = todoDescription,
				Done = false,
				Id = _nextAvailableId++
			};

			return new State
			{
				InputValue = "",
				Todos = state.Todos.Append(todo)
			};
		}

		private State RemoveTodo(int id)
		{
			return new State
			{
				InputValue = state.InputValue,
				Todos = state.Todos.Where(todo => todo.Id != id)
			};
		}

		private State ToggleDone(int id)
		{
			var todos = state.Todos.ToArray();
			for(int i = 0; i < todos.Length; i++)
			{
				if (todos[i].Id == id)
				{
					todos[i].Done = !todos[i].Done;
				}
			}

			return new State
			{
				InputValue = state.InputValue,
				Todos = todos
			};
		}

		public override ReactElement Render()
		{
			return DOM.Div(new Attributes { ClassName = "wrapper" },
				DOM.H3(props.Label),
				DOM.Label("Description"),
				DOM.Input(new InputAttributes
				{
					Value = state.InputValue,
					OnChange = e => SetState(new State { InputValue = e.CurrentTarget.Value, Todos = state.Todos })
				}),
				DOM.Button(
					new ButtonAttributes
					{
						Disabled = string.IsNullOrWhiteSpace(state.InputValue),
						OnClick = e => SetState(AppendTodo(state.InputValue))
					},
					"Add"
				),
				DOM.Div(
					state.Todos
						 .Select(todo =>
								DOM.H4(new Attributes { ClassName = todo.Done ? "done" : "not-done" }, todo.Description),
								DOM.Button(
									new ButtonAttributes
									{
										ClassName = todo.Done ? "toggle-done" : "toggle-not-done",
										OnClick = e => SetState(ToggleDone(todo.Id))
									},
									todo.Done ? "Not done yet!" : "Finished!"
								),
								DOM.Button(
									new ButtonAttributes
									{
										ClassName = "remove-btn",
										OnClick = e => SetState(RemoveTodo(todo.Id))
									},
									"Remove"
								)
						 ))
						 .Pipe(DOM.Div)
				)
			);
		}

		[ObjectLiteral]
		public class Props
		{
			public string Label;
		}

		[ObjectLiteral]
		public class State
		{
			public string InputValue;
			public IEnumerable<Todo> Todos;
		}

		[ObjectLiteral]
		public class Todo
		{
			public int Id { get; set; }
			public string Description { get; set; }
			public bool Done { get; set; }
		}
	}

	public static class Extenstions
	{
		public static U Pipe<T, U>(this T value, Func<T, U> f)
		{
			return f(value);
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T value)
		{
			return source.Concat(new T[] { value });
		}
	}
}