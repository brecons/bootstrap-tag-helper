namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("checkbox-list", ParentTag = "form-group")]
    [ContextClass]
    public class CheckboxListTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string InlineAttributeName = AttributePrefix + "inline";
        private const string LabelAttributeName = AttributePrefix + "label";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(LabelAttributeName)]
        public string Label { get; set; }

        [HtmlAttributeName(InlineAttributeName)]
        public bool IsInline { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }

        #endregion

        protected virtual string CssClass => "checkbox-list";

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = "div";
            output.AddCssClass(this.CssClass);

            // Horizontal Form
            if (this.FormContext != null)
            {
                this.FormContext.WrapInDivForHorizontalForm(output);
            }

            // Label
            if(!string.IsNullOrEmpty(this.Label))
            {
                output.PreElement.Prepend(LegendTagHelper.Build(this.Label, this.FormContext));
            }
        }
    }
}
