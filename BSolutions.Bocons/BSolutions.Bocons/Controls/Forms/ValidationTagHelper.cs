namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    [OutputElementHint("div")]
    [HtmlTargetElement("validation", ParentTag = "form-group")]
    public class ValidationTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string AspForAttributeName = "asp-for";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(AspForAttributeName)]
        public ModelExpression For { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("invalid-feedback");
            output.MergeAttribute("data-valmsg-for", this.For.Metadata.PropertyName);
            output.MergeAttribute("data-valmsg-replace", "true");

            // Error Message
            var modelState = this.ViewContext.ViewData.ModelState.FirstOrDefault(k => k.Key == this.For.Metadata.PropertyName).Value;
            if (modelState != null && modelState.ValidationState == ModelValidationState.Invalid)
            {
                output.AddCssClass("field-validation-error");
                output.Content.SetContent(modelState.Errors.FirstOrDefault()?.ErrorMessage);
            }
            else
            {
                output.AddCssClass("field-validation-valid");
            }
        }

        public static IHtmlContent Generate(FormTagHelperBase tagHelper)
        {
            var builder = new TagBuilder("div") { TagRenderMode = TagRenderMode.Normal };
            builder.AddCssClass("invalid-feedback");
            builder.MergeAttribute("data-valmsg-for", tagHelper.Id);
            builder.MergeAttribute("data-valmsg-replace", "true");

            // Error Message
            var modelState = tagHelper.ViewContext.ViewData.ModelState.FirstOrDefault(k => k.Key == tagHelper.For.Metadata.PropertyName).Value;
            if (modelState != null && modelState.ValidationState == ModelValidationState.Invalid)
            {
                builder.AddCssClass("field-validation-error");
                builder.InnerHtml.Append(modelState.Errors.FirstOrDefault()?.ErrorMessage);
            }
            else
            {
                builder.AddCssClass("field-validation-valid");
            }

            return builder;
        }
    }
}
