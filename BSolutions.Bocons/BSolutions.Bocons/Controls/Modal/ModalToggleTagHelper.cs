namespace BSolutions.Bocons.Controls.Modal
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("button", Attributes = ModalTargetAttributeName)]
    public class ModalToggleTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ModalTargetAttributeName = AttributePrefix + "modal-target";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ModalTargetAttributeName)]
        public string ModalTarget { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("data-target", "#" + this.ModalTarget);
            output.Attributes.Add("data-toggle", "modal");
        }
    }
}
