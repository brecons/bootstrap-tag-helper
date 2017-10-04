namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("span")]
    public class BadgeTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ColorAttributeName = AttributePrefix + "color";
        private const string PillAttributeName = AttributePrefix + "pill";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.Secondary;

        [HtmlAttributeName(PillAttributeName)]
        public bool IsPill { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.AddCssClass("badge");

            // Color
            if (this.Color != Color.None)
            {
                output.AddCssClass($"badge-{this.Color.GetColorInfo().Name}");
            }

            // Pill
            if(this.IsPill)
            {
                output.AddCssClass("badge-pill");
            }
        }
    }
}
