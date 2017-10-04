namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class LabelTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string SrOnlyAttributeName = AttributePrefix + "sronly";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(SrOnlyAttributeName)]
        public bool SrOnly { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Screenreader only
            if (this.SrOnly)
            {
                output.AddCssClass("sr-only");
            }
        }

        public static IHtmlContent Build(string content, string controlId, bool isRequired, FormTagHelper formContext)
        {
            TagBuilder label = new TagBuilder("label");

            // Control Link
            if (!string.IsNullOrEmpty(controlId))
            {
                label.Attributes.Add("for", controlId);
            }

            // Screenreader only
            if (formContext != null && formContext.LabelsSrOnly)
            {
                label.AddCssClass("sr-only");
            }

            // Content
            label.InnerHtml.Append(content);

            if (isRequired)
            {
                label.InnerHtml.AppendHtml("<span class=\"required\" aria-required=\"true\"> * </span>");
            }

            // Horizontal Form
            if (formContext != null && formContext.IsHorizontal)
            {
                label.AddCssClass("col-form-label");

                if (formContext.LabelWidthXs > 0 && formContext.LabelWidthXs < 12) label.AddCssClass($"col-{formContext.LabelWidthXs}");
                if (formContext.LabelWidthSm > 0 && formContext.LabelWidthSm < 12) label.AddCssClass($"col-sm-{formContext.LabelWidthSm}");
                if (formContext.LabelWidthMd > 0 && formContext.LabelWidthMd < 12) label.AddCssClass($"col-md-{formContext.LabelWidthMd}");
                if (formContext.LabelWidthLg > 0 && formContext.LabelWidthLg < 12) label.AddCssClass($"col-lg-{formContext.LabelWidthLg}");
                if (formContext.LabelWidthXl > 0 && formContext.LabelWidthXl < 12) label.AddCssClass($"col-xl-{formContext.LabelWidthXl}");
            }

            return label;
        }
    }
}
