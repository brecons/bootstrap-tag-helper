namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("navbar-nav", ParentTag = "navbar")]
    [RestrictChildren("navbar-link", "navbar-dropdown")]
    [ContextClass]
    public class NavbarNavTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.AddCssClass("navbar-nav mr-auto");
        }

    }
}
