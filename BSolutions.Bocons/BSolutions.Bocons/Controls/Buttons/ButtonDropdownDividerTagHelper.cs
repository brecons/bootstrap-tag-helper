namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("divider", ParentTag = "button-dropdown", TagStructure = TagStructure.WithoutEndTag)]
    public class ButtonDropdownDividerTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.AddCssClass("dropdown-divider");
            
        }
    }
}
