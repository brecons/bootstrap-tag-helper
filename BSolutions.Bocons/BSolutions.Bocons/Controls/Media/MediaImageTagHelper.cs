namespace BSolutions.Bocons.Controls.Media
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("img")]
    [HtmlTargetElement("media-image", ParentTag = "media")]
    public class MediaImageTagHelper : BreconsTagHelperBase
    {
        public MediaImageTagHelper(IActionContextAccessor actionContextAccessor) : base()
        {
            this.ActionContextAccessor = actionContextAccessor;
        }

        #region --- Attribute Names ---

        private const string VerticalAlignmentAttributeName = AttributePrefix + "vertical-alignment";

        #endregion

        #region --- Properties ---

        [CopyToOutput]
        [ConvertVirtualUrl]
        public string Src { get; set; }

        [HtmlAttributeName(VerticalAlignmentAttributeName)]
        public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Default;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;

            output.AddCssClass("d-flex");

            // Vertical Alignment
            switch(this.VerticalAlignment)
            {
                case VerticalAlignment.Top:
                    output.AddCssClass("align-self-start");
                    break;
                case VerticalAlignment.Middle:
                    output.AddCssClass("align-self-center");
                    break;
                case VerticalAlignment.Bottom:
                    output.AddCssClass("align-self-end");
                    break;
            }
        }
    }
}
