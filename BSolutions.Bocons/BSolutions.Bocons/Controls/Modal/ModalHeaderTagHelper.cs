namespace BSolutions.Bocons.Controls.Modal
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Attributes.Controls;

    [HtmlTargetElement("modal-header", ParentTag = "modal")]
    [OutputElementHint("div")]
    public class ModalHeaderTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string DisableCloseIconAttributeName = AttributePrefix + "disable-close-icon";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(DisableCloseIconAttributeName)]
        public bool DisableCloseIcon { get; set; }

        [HtmlAttributeNotBound]
        [Context]
        public ModalTagHelper ModalContext { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("modal-header");

            // Close Button
            if (!this.DisableCloseIcon)
            {
                output.PostContent.AppendHtml("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            }

            // Header
            var content = await output.GetChildContentAsync();

            if(this.ModalContext != null && !string.IsNullOrEmpty(this.ModalContext.Title))
            {
                output.Content.AppendHtml($"<h4 class=\"modal-title\">{content.GetContent()}</h4>");
            }
            else
            {
                output.Content.AppendHtml(content.GetContent());
            }
            
            this.ModalContext.HeaderHtml = output.ToTagHelperContent().GetContent();

            output.SuppressOutput();
        }
    }
}
