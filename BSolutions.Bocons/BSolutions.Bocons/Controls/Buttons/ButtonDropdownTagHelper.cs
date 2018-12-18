namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [OutputElementHint("button")]
    [RestrictChildren("a", "text", "header", "divider")]
    [HtmlTargetElement("button-dropdown")]
    [GenerateId("dropdown-", false)]
    public class ButtonDropdownTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string TitleAttributeName = AttributePrefix + "title";
        private const string VariationAttributeName = AttributePrefix + "variation";
        private const string ColorAttributeName = AttributePrefix + "color";
        private const string RightAlignmentAttributeName = AttributePrefix + "alignment-right";
        private const string SizeAttributeName = AttributePrefix + "size";
        private const string SplitAttributeName = AttributePrefix + "split";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(VariationAttributeName)]
        public DropdownButtonPosition Variation { get; set; } = DropdownButtonPosition.Bottom;

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.Primary;

        [HtmlAttributeName(RightAlignmentAttributeName)]
        public bool RightAlignment { get; set; }

        [HtmlAttributeName(SizeAttributeName)]
        public Size Size { get; set; } = Size.Default;

        [HtmlAttributeName(SplitAttributeName)]
        public bool IsSplit { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var items = await output.GetChildContentAsync();

            output.TagName = "button";
            output.AddCssClass("btn");

            // Color
            if (this.Color != Color.None)
            {
                output.AddCssClass($"btn-{this.Color.GetColorInfo().Name}");
            }

            // Size
            if (this.Size != Size.Default)
            {
                output.AddCssClass($"btn-{this.Size.GetEnumInfo().Name}");
            }

            // Title
            output.Content.Append(this.Title);

            // Split
            if (this.IsSplit)
            {
                output.PostElement.AppendHtml(this.DropdownButtonBuilder());
            }
            else
            {
                output.AddCssClass("dropdown-toggle");
                output.MergeAttribute("type", "button");
                output.MergeAttribute("data-toggle", "dropdown");
                output.MergeAttribute("aria-haspopup", "true");
                output.MergeAttribute("aria-expanded", "false");
            }

            // Menu
            output.PostElement.AppendHtml($"<div class=\"{(this.RightAlignment ? "dropdown-menu dropdown-menu-right" : "dropdown-menu")}\" aria-labelledby=\"{this.Id}\">");
            output.PostElement.AppendHtml(items);
            output.PostElement.AppendHtml("</div>");

            // Container
            output.WrapHtmlOutside($"<div class=\"{(this.Variation != DropdownButtonPosition.Bottom ? $"btn-group {this.Variation.GetEnumInfo().Name}" : "btn-group")}\">", "</div>");
        }

        private TagBuilder DropdownButtonBuilder()
        {
            TagBuilder button = new TagBuilder("button");
            button.AddCssClass("btn dropdown-toggle");
            button.MergeAttribute("type", "button");
            button.MergeAttribute("data-toggle", "dropdown");
            button.MergeAttribute("aria-haspopup", "true");
            button.MergeAttribute("aria-expanded", "false");

            // Color
            if(this.Color != Color.None)
            {
                button.AddCssClass($"btn-{this.Color.GetColorInfo().Name}");
            }

            // Size
            if (this.Size != Size.Default)
            {
                button.AddCssClass($"btn-{this.Size.GetEnumInfo().Name}");
            }

            button.InnerHtml.AppendHtml($"<span class=\"sr-only\">{this.Title}</span>");

            return button;
        }
    }
}
