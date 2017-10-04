namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Brecons.Core.Controls;
    using Enumerations;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("navbar-text", ParentTag = "navbar")]
    public class NavbarTextTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.AddCssClass("navbar-text");
        }
    }
}
