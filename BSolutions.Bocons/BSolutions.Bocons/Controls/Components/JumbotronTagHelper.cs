namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [OutputElementHint("div")]
    public class JumbotronTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string FluidAttributeName = AttributePrefix + "fluid";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(FluidAttributeName)]
        public bool IsFluid { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("jumbotron");

            // Full Width
            if (this.IsFluid)
            {
                output.AddCssClass("jumbotron-fluid");

                output.PreContent.SetHtmlContent(@"<div class=""container"">");
                output.PostContent.SetHtmlContent(@"</div>");
            }
        }
    }
}
