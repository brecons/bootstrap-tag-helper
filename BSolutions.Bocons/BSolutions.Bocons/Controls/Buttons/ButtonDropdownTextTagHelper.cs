namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("text", ParentTag = "button-dropdown")]
    public class ButtonDropdownTextTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.AddCssClass("dropdown-item-text");
        }
    }
}
