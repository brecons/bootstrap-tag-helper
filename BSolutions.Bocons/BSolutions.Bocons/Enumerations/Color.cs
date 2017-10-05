namespace BSolutions.Bocons.Enumerations
{
    using BSolutions.Brecons.Core.Attributes.Enumerations;

    public enum Color
    {
        None,

        [ColorInfo("primary", TextCssClass = "text-primary", BackgroundCssClass = "bg-primary", BorderCssClass = "border-primary")]
        Primary,

        [ColorInfo("secondary", TextCssClass = "text-secondary", BackgroundCssClass = "bg-secondary", BorderCssClass = "border-secondary")]
        Secondary,

        [ColorInfo("success", TextCssClass = "text-success", BackgroundCssClass = "bg-success", BorderCssClass = "border-success")]
        Success,

        [ColorInfo("danger", TextCssClass = "text-danger", BackgroundCssClass = "bg-danger", BorderCssClass = "border-danger")]
        Danger,

        [ColorInfo("warning", TextCssClass = "text-warning", BackgroundCssClass = "bg-warning", BorderCssClass = "border-warning")]
        Warning,

        [ColorInfo("info", TextCssClass = "text-info", BackgroundCssClass = "bg-info", BorderCssClass = "border-info")]
        Info,

        [ColorInfo("light", TextCssClass = "text-light", BackgroundCssClass = "bg-light", BorderCssClass = "border-light")]
        Light,

        [ColorInfo("dark", TextCssClass = "text-dark", BackgroundCssClass = "bg-dark", BorderCssClass = "border-dark")]
        Dark,

        [ColorInfo("white", TextCssClass = "text-white", BackgroundCssClass = "bg-white", BorderCssClass = "border-white")]
        White
    }
}
