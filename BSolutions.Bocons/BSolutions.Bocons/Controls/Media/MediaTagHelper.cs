namespace BSolutions.Bocons.Controls.Media
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    [RestrictChildren("media-image", "media-body")]
    public class MediaTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("media");
        }
    }
}
