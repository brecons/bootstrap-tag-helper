namespace BSolutions.Bocons.Controls.Breadcrumb
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("breadcrumb-item", ParentTag = "breadcrumb")]
    [OutputElementHint("li")]
    public class BreadcrumbItemTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string HrefAttributeName = AttributePrefix + "href";
        private const string ActiveAttributeName = AttributePrefix + "active";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(HrefAttributeName)]
        public string Href { get; set; }

        [HtmlAttributeName(ActiveAttributeName)]
        public bool Active { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            output.AddCssClass("breadcrumb-item");

            if (this.Active)
            {
                output.AddCssClass("active");
            }
            else

            if (!string.IsNullOrEmpty(this.Href))
            {
                output.PreContent.SetHtmlContent($"<a href=\"{this.Href}\">");
                output.PostContent.SetHtmlContent("</a>");
            }
        }
    }
}
