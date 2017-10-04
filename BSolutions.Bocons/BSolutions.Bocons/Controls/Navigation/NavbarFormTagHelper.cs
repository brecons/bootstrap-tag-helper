namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Brecons.Core.Controls;
    using Enumerations;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [OutputElementHint("form")]
    [HtmlTargetElement("navbar-form", ParentTag = "navbar")]
    public class NavbarFormTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "form";
            output.AddCssClass("form-inline");
        }
    }
}
