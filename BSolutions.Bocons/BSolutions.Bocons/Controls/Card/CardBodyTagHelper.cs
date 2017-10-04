namespace BSolutions.Bocons.Controls.Card
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("card-body", ParentTag = "card")]
    [OutputElementHint("div")]
    public class CardBodyTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string TitleAttributeName = AttributePrefix + "title";
        private const string SubtitleAttributeName = AttributePrefix + "subtitle";
        private const string ColorAttributeName = AttributePrefix + "color";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeName(SubtitleAttributeName)]
        public string Subtitle { get; set; }

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.None;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("card-body");

            // Title
            if(!string.IsNullOrEmpty(this.Title))
            {
                output.PreContent.AppendHtml($"<h4 class=\"card-title\">{this.Title}</h4>");
            }

            // Subtitle
            if (!string.IsNullOrEmpty(this.Subtitle))
            {
                output.PreContent.AppendHtml($"<h6 class=\"card-subtitle mb-2 text-muted\">{this.Subtitle}</h6>");
            }

            // Color
            if (this.Color != Color.None)
            {
                output.AddCssClass(this.Color.GetColorInfo().TextCssClass);
            }
        }
    }
}
