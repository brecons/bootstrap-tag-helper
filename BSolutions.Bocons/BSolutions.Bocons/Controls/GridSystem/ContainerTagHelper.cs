namespace BSolutions.Bocons.Controls.GridSystem
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;

    [OutputElementHint("div")]
    public class ContainerTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string FluidAttributeName = AttributePrefix + "fluid";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(FluidAttributeName)]
        public bool Fluid { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass(this.Fluid ? "container-fluid" : "container");
        }
    }
}
