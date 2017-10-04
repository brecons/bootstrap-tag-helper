namespace BSolutions.Bocons.Controls.Media
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [OutputElementHint("div")]
    [HtmlTargetElement("media-body", ParentTag = "media")]
    public class MediaBodyTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string HeaderAttributeName = AttributePrefix + "header";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(HeaderAttributeName)]
        public string Header { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("media-body");

            // Header
            if(!string.IsNullOrEmpty(this.Header))
            {
                output.PreContent.AppendHtml($"<h5 class=\"mt-0\">{this.Header}</h5>");
            }
        }
    }
}
