namespace BSolutions.Bocons.Controls.Breadcrumb
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [OutputElementHint("ol")]
    [RestrictChildren("breadcrumb-item")]
    public class BreadcrumbTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ol";
            output.AddCssClass("breadcrumb");
        }
    }
}
