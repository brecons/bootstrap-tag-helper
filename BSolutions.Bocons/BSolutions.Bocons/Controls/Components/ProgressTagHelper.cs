namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("progress", TagStructure = TagStructure.WithoutEndTag)]
    [OutputElementHint("div")]
    public class ProgressTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ValueAttributeName = AttributePrefix + "value";
        private const string LabelAttributeName = AttributePrefix + "label";
        private const string HeightAttributeName = AttributePrefix + "height";
        private const string ColorAttributeName = AttributePrefix + "color";
        private const string StripedAttributeName = AttributePrefix + "striped";
        private const string AnimatedAttributeName = AttributePrefix + "animated";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ValueAttributeName)]
        public int Value { get; set; }

        [HtmlAttributeName(LabelAttributeName)]
        public bool HasLabel { get; set; }

        [HtmlAttributeName(HeightAttributeName)]
        public int Height { get; set; } = 16;

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.Primary;

        [HtmlAttributeName(StripedAttributeName)]
        public bool IsStriped { get; set; }

        [HtmlAttributeName(AnimatedAttributeName)]
        public bool IsAnimated { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.AddCssClass("progress");

            // Height
            output.AddCssStyle("height", $"{this.Height}px");

            output.Content.SetHtmlContent(this.BuildProgressbar());
        }

        private TagBuilder BuildProgressbar()
        {
            TagBuilder progressbar = new TagBuilder("div");
            progressbar.AddCssClass($"progress-bar");
            progressbar.AddCssClass(this.Color.GetColorInfo().BackgroundCssClass);

            progressbar.MergeAttribute("aria-valuemin", "0");
            progressbar.MergeAttribute("aria-valuemax", "100");
            progressbar.MergeAttribute("aria-valuenow", this.Value.ToString());
            progressbar.MergeAttribute("role", "progressbar");
            progressbar.MergeAttribute("style", $"width: {this.Value}%;");

            // Label
            if (this.HasLabel)
            {
                progressbar.InnerHtml.Append($"{this.Value}%");
            }

            // Animated and Striped
            if (this.IsAnimated)
            {
                progressbar.AddCssClass("progress-bar-striped progress-bar-animated");
            }
            else if (this.IsStriped)
            {
                progressbar.AddCssClass("progress-bar-striped");
            }

            return progressbar;
        }
    }
}
