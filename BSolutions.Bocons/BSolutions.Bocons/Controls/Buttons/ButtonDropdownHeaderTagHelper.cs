namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("h6")]
    [HtmlTargetElement("header", ParentTag = "button-dropdown")]
    public class ButtonDropdownHeaderTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h6";
            output.AddCssClass("dropdown-header");
        }
    }
}
