namespace BSolutions.Bocons.Controls.Modal
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("h1", ParentTag = "modal-header")]
    [HtmlTargetElement("h2", ParentTag = "modal-header")]
    [HtmlTargetElement("h3", ParentTag = "modal-header")]
    [HtmlTargetElement("h4", ParentTag = "modal-header")]
    [HtmlTargetElement("h5", ParentTag = "modal-header")]
    [HtmlTargetElement("h6", ParentTag = "modal-header")]
    public class ModalTitleTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddCssClass("modal-title");
        }
    }
}
