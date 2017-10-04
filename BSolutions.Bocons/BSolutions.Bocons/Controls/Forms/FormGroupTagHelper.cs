namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    [HtmlTargetElement("form-group", ParentTag = "form")]
    [RestrictChildren("input", "select", "textarea", "checkbox-list", "radio-list", "label", "help", "span", "validation")]
    public class FormGroupTagHelper : BreconsTagHelperBase
    {
        #region --- Properties ---

        [Context]
        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("form-group");

            // Horizontal Form
            if(this.FormContext != null && this.FormContext.IsHorizontal)
            {
                output.AddCssClass("row");
            }
        }
    }
}
