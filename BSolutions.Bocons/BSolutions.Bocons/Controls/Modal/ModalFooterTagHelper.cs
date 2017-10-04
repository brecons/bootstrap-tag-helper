namespace BSolutions.Bocons.Controls.Modal
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("modal-footer", ParentTag = "modal")]
    [OutputElementHint("div")]
    public class ModalFooterTagHelper : BreconsTagHelperBase
    {
        #region --- Properties ---

        [HtmlAttributeNotBound]
        [Context]
        public ModalTagHelper ModalContext { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.LoadChildContentAsync();

            output.TagName = "div";
            output.AddCssClass("modal-footer");
        }
    }
}
