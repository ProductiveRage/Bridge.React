using System;
using ProductiveRage.Immutable;

namespace Bridge.React.Examples
{
	public sealed class TaskCard : PureComponent<TaskCard.Props>
	{
		public TaskCard(TaskDetails task, Action<TaskDetails> onChange, Action onRemove) : base(new Props(task, onChange, onRemove)) { }

		public override ReactElement Render()
		{
			return DOM.Div(new Attributes { Style = TodoStyles.Container },
				DOM.H4(
					new Attributes { Style = props.Task.Done ? TodoStyles.TextDone : TodoStyles.TextNotDone },
					props.Task.Description
				),
				DOM.Button(
					new ButtonAttributes
					{
						Style = props.Task.Done ? TodoStyles.ToggleButtonDone : TodoStyles.ToggleButtonNotDone,
						OnClick = e => props.OnChange(props.Task.With(_ => _.Done, value => !value))
					},
					props.Task.Done ? "Not done yet!" : "Finished!"
				),
				DOM.Button(
					new ButtonAttributes
					{
						Style = TodoStyles.RemoveButton,
						OnClick = e => props.OnRemove()
					},
					"Remove"
				)
			);
		}

		public sealed class Props : PropsWithKey, IAmImmutable
		{
			public Props(TaskDetails task, Action<TaskDetails> onChange, Action onRemove) : base(task.Id)
			{
				this.CtorSet(_ => _.Task, task);
				this.CtorSet(_ => _.OnChange, onChange);
				this.CtorSet(_ => _.OnRemove, onRemove);
			}
			public TaskDetails Task { get; }
			public Action<TaskDetails> OnChange { get; }
			public Action OnRemove { get; }
		}
	}
}