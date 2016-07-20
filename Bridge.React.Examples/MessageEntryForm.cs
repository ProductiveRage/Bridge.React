using System;
using System.Linq;
using Bridge.React;
using System.Collections.Generic;

namespace Bridge.React.Examples
{

    public class MessageEntryForm : Component<MessageEntryForm.Props, MessageEntryForm.State>
    {
        public MessageEntryForm(string label)
            : base(new Props { Label = label }) { }

        protected override State GetInitialState()
        {
            return new State
            {
                InputValue = "",
                Values = Enumerable.Empty<string>()
            };
        }

        public override ReactElement Render()
        {
            return DOM.Div(new Attributes { ClassName = "wrapper" },
                DOM.Div(
                    DOM.Label(null, props.Label),
                    DOM.Input(new InputAttributes
                    {
                        Value = state.InputValue,
                        OnChange = e => SetState(new State { InputValue = e.CurrentTarget.Value, Values = state.Values })
                    }),
                    DOM.Button(
                    new ButtonAttributes
                    {
                        Disabled = string.IsNullOrWhiteSpace(state.InputValue),
                        OnClick = e =>
                        {
                            var nextState = new State
                            {
                                InputValue = "",
                                Values = state.Values.Append(state.InputValue)
                            };

                            SetState(nextState);
                        }
                    },
                    "Add"
                )),
                state.Values
                     .Select(DOM.Li)
                     .Pipe(DOM.UL)
                     .Pipe(DOM.Div)
            );
        }


        public class Props
        {
            public string Label;
        }

        public class State
        {
            public string InputValue;
            public IEnumerable<string> Values;
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