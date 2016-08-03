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

		private void AppendTodo(string todoDescription)
		{
			var count = state.Todos.Count();
			var todo = new Todo
			{
				Description = todoDescription,
				Done = false,
				Id = _nextAvailableId++
			};

			SetState(new State
			{
				InputValue = "",
				Todos = state.Todos.Append(todo)
			});
		}

		private void RemoveTodo(int id)
		{
			SetState(new State
			{
				InputValue = state.InputValue,
				Todos = state.Todos.Where(todo => todo.Id != id)
			});
		}

		private void ToggleDone(int id)
		{
			var todos = state.Todos.ToArray();
			for(int i = 0; i < todos.Length; i++)
			{
				if (todos[i].Id == id)
				{
					todos[i].Done = !todos[i].Done;
				}
			}

			SetState(new State
			{
				InputValue = state.InputValue,
				Todos = todos
			});
		}

		public override ReactElement Render()
		{
			return DOM.Div(new Attributes
            {
                Style = Style.Margin(5).Padding(5).FontSize(18)
            },
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
						OnClick = e => AppendTodo(state.InputValue)
					},
					"Add"
				),
				DOM.Div(
					state.Todos.Select(todo =>
						DOM.Div(new Attributes { Key = todo.Id, Style = TodoStyles.Container },
							DOM.H4(
                                new Attributes { Style = todo.Done ? TodoStyles.TextDone : TodoStyles.TextNotDone },
                                todo.Description),
							DOM.Button(
								new ButtonAttributes
								{
                                    Style = todo.Done ? TodoStyles.ToggleButtonDone : TodoStyles.ToggleButtonNotDone,
									OnClick = e => ToggleDone(todo.Id)
								},
								todo.Done ? "Not done yet!" : "Finished!"
							),
							DOM.Button(
								new ButtonAttributes
								{
									Style = TodoStyles.RemoveButton,
									OnClick = e => RemoveTodo(todo.Id)
								},
								"Remove"
							)
						)
					)
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
		public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T value)
		{
			return source.Concat(new T[] { value });
		}
	}
}