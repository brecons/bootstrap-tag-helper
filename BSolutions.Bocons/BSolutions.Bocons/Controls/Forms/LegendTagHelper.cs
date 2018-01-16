namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class LegendTagHelper : BreconsTagHelperBase
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

        public static IHtmlContent Build(string content, FormTagHelper formContext)
        {
            TagBuilder legend = new TagBuilder("legend");
            legend.AddCssClass("col-form-label");

            // Screenreader only
            if (formContext != null && formContext.LabelsSrOnly)
            {
                legend.AddCssClass("sr-only");
            }

            // Content
            legend.InnerHtml.Append(content);

            // Horizontal Form
            if (formContext != null && formContext.IsHorizontal)
            {
                if (formContext.LabelWidthXs > 0 && formContext.LabelWidthXs < 12) legend.AddCssClass($"col-{formContext.LabelWidthXs}");
                if (formContext.LabelWidthSm > 0 && formContext.LabelWidthSm < 12) legend.AddCssClass($"col-sm-{formContext.LabelWidthSm}");
                if (formContext.LabelWidthMd > 0 && formContext.LabelWidthMd < 12) legend.AddCssClass($"col-md-{formContext.LabelWidthMd}");
                if (formContext.LabelWidthLg > 0 && formContext.LabelWidthLg < 12) legend.AddCssClass($"col-lg-{formContext.LabelWidthLg}");
                if (formContext.LabelWidthXl > 0 && formContext.LabelWidthXl < 12) legend.AddCssClass($"col-xl-{formContext.LabelWidthXl}");
            }

            return legend;
        }
    }
}
