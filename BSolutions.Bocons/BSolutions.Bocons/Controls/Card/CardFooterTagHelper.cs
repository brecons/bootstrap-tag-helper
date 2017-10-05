namespace BSolutions.Bocons.Controls.Card
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("card-footer", ParentTag = "card")]
    [OutputElementHint("div")]
    public class CardFooterTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("card-footer");
        }
    }
}
