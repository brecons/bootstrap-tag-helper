namespace BSolutions.Bocons.Controls.Modal
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("modal-body", ParentTag = "modal")]
    public class ModalBodyTagHelper : BreconsTagHelperBase
    {
        [HtmlAttributeNotBound]
        [Context]
        public ModalTagHelper ModalContext { get; set; }

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.LoadChildContentAsync();

            output.TagName = "div";
            output.AddCssClass("modal-body");
        }
    }
}
