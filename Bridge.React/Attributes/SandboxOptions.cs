namespace Bridge.React
{
    // Values taken from http://www.w3schools.com/tags/att_iframe_sandbox.asp
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    public enum SandboxOptions
    {
        [Name("allow-forms")]
        AllowForms,

        [Name("allow-pointer-lock")]
        AllowPointerLock,

        [Name("allow-popups")]
        AllowPopups,

        [Name("allow-same-origin")]
        AllowSameOrigin,

        [Name("allow-scripts")]
        AllowScripts,

        [Name("allow-top-navigation")]
        AllowTopNavigation
    }
}
