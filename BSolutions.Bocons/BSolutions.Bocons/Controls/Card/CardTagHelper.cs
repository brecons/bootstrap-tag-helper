namespace BSolutions.Bocons.Controls.Card
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    [RestrictChildren("card-header", "card-body", "card-footer", "card-image")]
    public class CardTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string AlignmentAttributeName = AttributePrefix + "alignment";
        private const string ColorAttributeName = AttributePrefix + "color";
        private const string BorderAttributeName = AttributePrefix + "border";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(AlignmentAttributeName)]
        public HorizontalAlignment Alignment { get; set; } = HorizontalAlignment.Default;

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.None;

        [HtmlAttributeName(BorderAttributeName)]
        public Color Border { get; set; } = Color.None;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("card");

            // Alignment
            if(this.Alignment != HorizontalAlignment.Default)
            {
                output.AddCssClass($"text-{this.Alignment.GetEnumInfo().Name}");
            }

            // Color
            if (this.Color != Color.None)
            {
                output.AddCssClass(this.Color == Color.Light
                    ? this.Color.GetColorInfo().BackgroundCssClass
                    : $"text-white {this.Color.GetColorInfo().BackgroundCssClass}");
            }

            // Border
            if(this.Border != Color.None)
            {
                output.AddCssClass(this.Border.GetColorInfo().BorderCssClass);
            }
        }
    }
}
