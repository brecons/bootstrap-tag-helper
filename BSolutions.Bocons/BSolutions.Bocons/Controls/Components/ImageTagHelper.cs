namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("img")]
    [OutputElementHint("img")]
    public class ImageTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ThumbnailAttributeName = AttributePrefix + "thumbnail";
        private const string ResponsiveAttributeName = AttributePrefix + "responsive";
        private const string RoundAttributeName = AttributePrefix + "round";
        private const string CircleAttributeName = AttributePrefix + "circle";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ThumbnailAttributeName)]
        public bool Thumbnail { get; set; }

        [HtmlAttributeName(ResponsiveAttributeName)]
        public bool Responsive { get; set; }

        [HtmlAttributeName(RoundAttributeName)]
        public bool Round { get; set; }

        [HtmlAttributeName(CircleAttributeName)]
        public bool Circle { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Thumbnail
            if (this.Thumbnail)
            {
                output.AddCssClass("img-thumbnail");
            }

            // Round
            if(this.Round)
            {
                output.AddCssClass("rounded");
            }

            // Circle
            if(this.Circle)
            {
                output.AddCssClass("rounded-circle");
            }

            // Responsive
            if (this.Responsive)
            {
                output.AddCssClass("img-fluid");
            }
        }
    }
}
