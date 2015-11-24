namespace Bridge.React
{
    /// <summary>
    /// The Render method of any custom components must return a ReactElement instance - this is not something that is ever directly created, they may only be created
    /// by one of the builtin DOM element creation functions or by the React.createElement function (which is called by the Component base class). As such, this is
    /// not a class that needs to be included in the generated JavaScript, it is just to let the C# compiler keep track of how this internal element type passed
    /// through the system.
    /// </summary>
    [External]
    public sealed class ReactElement
    {
        private ReactElement() { }
    }
}
