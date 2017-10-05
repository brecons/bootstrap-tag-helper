namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;

    [ContextClass]
    public class FormTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string LabelWidthXsAttributeName = AttributePrefix + "label-width-xs";
        private const string LabelWidthSmAttributeName = AttributePrefix + "label-width-sm";
        private const string LabelWidthMdAttributeName = AttributePrefix + "label-width-md";
        private const string LabelWidthLgAttributeName = AttributePrefix + "label-width-lg";
        private const string LabelWidthXlAttributeName = AttributePrefix + "label-width-xl";
        private const string LabelsSrOnlyAttributeName = AttributePrefix + "labels-sr-only";
        private const string HorizontalAttributeName = AttributePrefix + "horizontal";
        private const string ValidationAttributeName = AttributePrefix + "validation";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(LabelWidthXsAttributeName)]
        public int LabelWidthXs { get; set; }

        [HtmlAttributeName(LabelWidthSmAttributeName)]
        public int LabelWidthSm { get; set; }

        [HtmlAttributeName(LabelWidthMdAttributeName)]
        public int LabelWidthMd { get; set; }

        [HtmlAttributeName(LabelWidthLgAttributeName)]
        public int LabelWidthLg { get; set; }

        [HtmlAttributeName(LabelWidthXlAttributeName)]
        public int LabelWidthXl { get; set; }

        [HtmlAttributeName(HorizontalAttributeName)]
        public bool IsHorizontal { get; set; }

        [HtmlAttributeName(LabelsSrOnlyAttributeName)]
        public bool LabelsSrOnly { get; set; }

        [HtmlAttributeName(ValidationAttributeName)]
        public bool Validation { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
        }

        /// <summary>
        /// Wraps the tag helper output in a div for horizontal form layout.
        /// </summary>
        /// <param name="output">The tag helper output.</param>
        public void WrapInDivForHorizontalForm(TagHelperOutput output)
        {
            if (this.IsHorizontal)
            {
                var builder = new TagBuilder("div") { TagRenderMode = TagRenderMode.StartTag };

                if (this.LabelWidthXs > 0 && this.LabelWidthXs < 12)
                {
                    builder.AddCssClass("col-" + (12 - LabelWidthXs));
                }

                if (this.LabelWidthSm > 0 && this.LabelWidthSm < 12)
                {
                    builder.AddCssClass("col-sm-" + (12 - LabelWidthSm));
                }

                if (this.LabelWidthMd != 0 && this.LabelWidthMd < 12)
                {
                    builder.AddCssClass("col-md-" + (12 - LabelWidthMd));
                }

                if (this.LabelWidthLg != 0 && this.LabelWidthLg < 12)
                {
                    builder.AddCssClass("col-lg-" + (12 - LabelWidthLg));
                }

                if (this.LabelWidthXl != 0 && this.LabelWidthXl < 12)
                {
                    builder.AddCssClass("col-xl-" + (12 - LabelWidthXl));
                }

                output.PreElement.Prepend(builder);
                output.PostElement.AppendHtml("</div>");
            }
        }
    }
}
