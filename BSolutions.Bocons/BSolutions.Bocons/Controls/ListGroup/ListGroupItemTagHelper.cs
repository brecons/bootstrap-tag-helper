namespace BSolutions.Bocons.Controls.ListGroup
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Extensions;
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;

    [OutputElementHint("li")]
    [HtmlTargetElement("list-group-item", ParentTag = "list-group")]
    public class ListGroupItemTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ColorAttributeName = AttributePrefix + "color";
        private const string BadgeAttributeName = AttributePrefix + "badge";
        private const string BadgeColorAttributeName = AttributePrefix + "badge-color";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; }

        [HtmlAttributeName(BadgeAttributeName)]
        public string Badge { get; set; }

        [HtmlAttributeName(BadgeColorAttributeName)]
        public Color BadgeColor { get; set; } = Color.None;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            output.AddCssClass("list-group-item");

            // Color
            if(this.Color != Color.None)
            {
                output.AddCssClass($"list-group-item-{this.Color.GetColorInfo().Name}");
            }

            // Badge
            if(!string.IsNullOrEmpty(this.Badge))
            {
                output.AddCssClass("d-flex justify-content-between align-items-center");
                output.PostContent.AppendHtml($"<span class=\"{(this.BadgeColor != Color.None ? $"badge badge-{this.BadgeColor.GetColorInfo().Name} badge-pill" : "badge badge-dark badge-pill")}\">{this.Badge}</span>");
            }
        }
    }
}
