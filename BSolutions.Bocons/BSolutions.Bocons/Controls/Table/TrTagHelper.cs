namespace BSolutions.Bocons.Controls.Table
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("tr")]
    [HtmlTargetElement("tr", ParentTag = "tbody")]
    public class TrTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string BackgroundAttributeName = AttributePrefix + "background";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(BackgroundAttributeName)]
        public Color Background { get; set; } = Color.None;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Background
            if(this.Background != Color.None)
            {
                output.AddCssClass($"table-{this.Background.GetColorInfo().Name}");
            }
        }
    }
}
