namespace BSolutions.Bocons.Rendering
{
    using BSolutions.Bocons.Controls.Forms;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    internal static class FormTagHelperRendering
    {
        /// <summary>
        /// Renders the validation styles and elements.
        /// </summary>
        /// <param name="tagHelper">The tag helper.</param>
        /// <param name="output">The tag helper output.</param>
        internal static void RenderValidation(this BoconsFormTagHelperBase tagHelper, TagHelperOutput output)
        {
            // Validation Css Class
            if (!tagHelper.IsPostValid())
            {
                output.AddCssClass("is-invalid");
            }

            // Validation Message
            if (tagHelper.For != null && tagHelper.Validation)
            {
                output.PostElement.AppendHtml(ValidationTagHelper.Generate(tagHelper.For, tagHelper.ViewContext));
            }
        }

        /// <summary>
        /// Renders the help.
        /// </summary>
        /// <param name="tagHelper">The tag helper.</param>
        /// <param name="output">The tag helper output.</param>
        internal static void RenderHelp(this BoconsFormTagHelperBase tagHelper, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(tagHelper.Help))
            {
                output.MergeAttribute("aria-describedby", $"{tagHelper.Id}-help");
                output.PostElement.AppendHtml(HelpTagHelper.Build(tagHelper.Help, $"{tagHelper.Id}-help"));
            }
        }

        /// <summary>
        /// Renders the label.
        /// </summary>
        /// <param name="tagHelper">The tag helper.</param>
        /// <param name="output">The tag helper output.</param>
        internal static void RenderLabel(this BoconsFormTagHelperBase tagHelper, TagHelperOutput output)
        {
            // Label
            if (!string.IsNullOrEmpty(tagHelper.Label))
            {
                output.PreElement.Prepend(LabelTagHelper.Build(tagHelper.Label, tagHelper.Id, tagHelper.IsRequired, tagHelper.FormContext));
            }
        }

        internal static void RenderHorizontal(this BoconsFormTagHelperBase tagHelper, TagHelperOutput output)
        {
            if (tagHelper.FormContext != null)
            {
                tagHelper.FormContext.WrapInDivForHorizontalForm(output);
            }
        }

        internal static void RenderSize(this BoconsFormTagHelperBase tagHelper, TagHelperOutput output)
        {
            if (tagHelper.Size != Size.Default)
            {
                output.AddCssClass($"form-control-{tagHelper.Size.GetEnumInfo().Name}");
            }
        }
    }
}
