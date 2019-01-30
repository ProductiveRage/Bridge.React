using ProductiveRage.Immutable;

namespace Bridge.React.Examples
{
	public sealed class TodoApp : Component<TodoApp.Props, TodoApp.State>
	{
		private int _nextAvailableId = 0;
		public TodoApp(string label) : base(new Props(label)) { }

		protected override State GetInitialState()
		{
			return new State(
				inputValue: "",
				todos: NonNullList.Of(
					new TaskDetails(_nextAvailableId++, "Learn C#", done: true),
					new TaskDetails(_nextAvailableId++, "Learn React", done: false),
					new TaskDetails(_nextAvailableId++, "Build an awesome app with C# and React", done: false)
				)
			);
		}

		public override ReactElement Render()
		{
			return DOM.Div(new Attributes { Style = Style.Margin(5).Padding(5).FontSize(18) },
				DOM.H3(props.Label),
				DOM.Label("Description"),
				DOM.Input(new InputAttributes
				{
					Value = state.InputValue,
					OnChange = e => SetState(state.With(_ => _.InputValue, e.CurrentTarget.Value)),
                    Data = new {
                        my_custom_value = "custom",
                    },
                    Aria = new {
                        hidden = "true",
                    },
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
					state.Todos.Select((todo, index) => new TaskCard(
						task: todo,
						onChange: updatedTask => SetState(state.With(_ => _.Todos, index, updatedTask)),
						onRemove: () => SetState(state.With(_ => _.Todos, value => value.RemoveAt(index)))
					))
				)
			);
		}

		private void AppendTodo(string todoDescription)
		{
			SetState(state.With(
				_ => _.Todos,
				value => value.Add(
					new TaskDetails(
						description: todoDescription,
						done: false,
						id: _nextAvailableId++
					)
				)
			));
		}

		public sealed class Props : IAmImmutable
		{
			public Props(string label)
			{
				this.CtorSet(_ => _.Label, label);
			}
			public string Label { get; }
		}

		public sealed class State : IAmImmutable
		{
			public State(string inputValue, NonNullList<TaskDetails> todos)
			{
				this.CtorSet(_ => _.InputValue, inputValue);
				this.CtorSet(_ => _.Todos, todos);
			}
			public string InputValue { get; }
			public NonNullList<TaskDetails> Todos { get; }
		}
	}
}
