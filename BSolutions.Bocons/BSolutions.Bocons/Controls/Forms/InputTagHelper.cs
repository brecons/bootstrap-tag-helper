namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Bocons.Rendering;
    using BSolutions.Brecons.Core;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Linq;

    [GenerateId("input-")]
    public class InputTagHelper : BoconsFormTagHelperBase
    {
        #region --- Attribute Names ---

        private const string PreAddonAttributeName = AttributePrefix + "pre-addon";
        private const string PostAddonAttributeName = AttributePrefix + "post-addon";
        private const string StaticAttributeName = AttributePrefix + "static";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(PreAddonAttributeName)]
        public string PreAddon { get; set; }

        [HtmlAttributeName(PostAddonAttributeName)]
        public string PostAddon { get; set; }

        [CopyToOutput]
        public string Type { get; set; }

        [HtmlAttributeName(StaticAttributeName)]
        public bool IsStatic { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public CheckboxListTagHelper CheckboxListContext { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public RadioListTagHelper RadioListContext { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Binding
            this.BindProperty(context);
            
            // Radio or Checkbox
            if(this.Type != null && BreconsConsts.CheckTypes.Any(t => t == this.Type.ToLower()))
            {
                this.RenderCheckControl(output);
            }
            // Button
            else if(this.Type != null && BreconsConsts.ButtonTypes.Any(t => t == this.Type.ToLower()))
            {
                this.RenderButtonControl(output);
            }
            // Range
            else if(this.Type != null && BreconsConsts.ButtonTypes.Any(t => t == this.Type.ToLower()))
            {
                this.RenderRangeControl(output);
            }
            // Input
            else if (this.Type != null && BreconsConsts.InputTypes.Any(t => t == this.Type.ToLower()))
            {
                this.RenderTextControl(output);
            }
            else
            {
                this.Type = "text";
                this.RenderTextControl(output);
            }
        }

        /// <summary>
        /// Renders input controls from type 'checkbox' and 'radio'.
        /// </summary>
        /// <param name="output">The tag helper output.</param>
        private void RenderCheckControl(TagHelperOutput output)
        {
            output.AddCssClass("form-check-input");

            // Label
            if (!string.IsNullOrEmpty(this.Label))
            {
                output.PostElement.AppendHtml($"<label class\"form-check-label\" for=\"{this.Id}\">{this.Label}</label>");
            }

            // Form Check
            TagBuilder check = new TagBuilder("div");

            if(this.CheckboxListContext != null)
            {
                check.AddCssClass(this.CheckboxListContext.IsInline ? "form-check form-check-inline" : "form-check");
            }
            else if(this.RadioListContext != null)
            {
                check.AddCssClass(this.RadioListContext.IsInline ? "form-check form-check-inline" : "form-check");
            }
            else
            {
                check.AddCssClass("form-check");
            }

            output.WrapOutside(check);
        }

        /// <summary>
        /// Renders input controls from type 'button'.
        /// </summary>
        /// <param name="output">The tag helper output.</param>
        private void RenderButtonControl(TagHelperOutput output)
        {

        }

        /// <summary>
        /// Renders range controls from type 'range'.
        /// </summary>
        /// <param name="output">The tag helper output.</param>
        private void RenderRangeControl(TagHelperOutput output)
        {
            output.AddCssClass("form-control-range");

            // Validation
            this.RenderValidation(output);

            // Help
            this.RenderHelp(output);

            // Horizontal
            this.RenderHorizontal(output);

            // Size
            this.RenderSize(output);

            // Label
            this.RenderLabel(output);
        }

        /// <summary>
        /// Renders input controls from type 'text' and 'file'.
        /// </summary>
        /// <param name="output">The tag helper output.</param>
        private void RenderTextControl(TagHelperOutput output)
        {
            // Validation
            this.RenderValidation(output);

            // Required
            if(this.IsRequired)
            {
                output.Attributes.Add("required", "required");
            }

            // Input Addons
            if (!string.IsNullOrEmpty(this.PostAddon) || !string.IsNullOrEmpty(this.PreAddon))
            {
                // Input Group
                output.PreElement.PrependHtml(this.Size != Size.Default ? $"<div class=\"input-group input-group-{this.Size.GetEnumInfo().Name}\">" : "<div class=\"input-group\">");

                // Pre Addon
                if (!string.IsNullOrEmpty(this.PreAddon))
                {
                    output.PreElement.AppendHtml(AddonTagHelper.Build(this.PreAddon, AddonType.Prepend));
                }

                // Post Addon
                if (!string.IsNullOrEmpty(this.PostAddon))
                {
                    output.PostElement.AppendHtml(AddonTagHelper.Build(this.PostAddon, AddonType.Append));
                }

                output.PostElement.AppendHtml("</div>");
            }

            // Help
            this.RenderHelp(output);

            // Horizontal
            this.RenderHorizontal(output);

            // Static
            if (this.IsStatic)
            {
                output.AddCssClass("form-control-plaintext");
                output.MergeAttribute("readonly", "readonly");
            }
            // Text or File
            else
            {
                output.AddCssClass(this.Type.ToLower() == "file" ? "form-control-file" : "form-control");
            }

            // Size
            this.RenderSize(output);

            // Label
            this.RenderLabel(output);
        }
    }
}
