namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Bocons.Rendering;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [GenerateId("select-")]
    public class SelectTagHelper : BoconsFormTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Binding
            this.BindProperty(context);

            output.AddCssClass("form-control");

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
    }
}
