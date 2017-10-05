namespace BSolutions.Bocons.Controls.ListGroup
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("a")]
    [HtmlTargetElement("list-group-link", ParentTag = "list-group")]
    public class ListGroupLinkTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string DisableAttributeName = AttributePrefix + "disable";
        private const string ColorAttributeName = AttributePrefix + "color";
        private const string ActiveAttributeName = AttributePrefix + "active";
        private const string BadgeAttributeName = AttributePrefix + "badge";
        private const string BadgeColorAttributeName = AttributePrefix + "badge-color";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; }

        [HtmlAttributeName(DisableAttributeName)]
        public bool IsDisabled { get; set; }

        [HtmlAttributeName(ActiveAttributeName)]
        public bool IsActive { get; set; }

        [HtmlAttributeName(BadgeAttributeName)]
        public string Badge { get; set; }

        [HtmlAttributeName(BadgeColorAttributeName)]
        public Color BadgeColor { get; set; } = Color.None;

        [Context]
        [HtmlAttributeNotBound]
        public ListGroupTagHelper ListGroupContext { get; set; }

        #endregion

        protected virtual string TagName => "a";

        public override void Init(TagHelperContext context)
        {
            base.Init(context);
            this.ListGroupContext.IsLinkGroup = true;
        }

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = this.TagName;
            output.AddCssClass("list-group-item list-group-item-action");

            // Disable
            if (this.IsDisabled)
            {
                output.AddCssClass("disabled");
            }

            // Style
            if (this.Color != Color.None)
            {
                output.AddCssClass($"list-group-item-{this.Color.GetColorInfo().Name}");
            }

            // Active
            if (this.IsActive)
            {
                output.AddCssClass("active");
            }

            // Badge
            if (!string.IsNullOrEmpty(this.Badge))
            {
                output.AddCssClass("d-flex justify-content-between align-items-center");
                output.PostContent.AppendHtml($"<span class=\"{(this.BadgeColor != Color.None ? $"badge badge-{this.BadgeColor.GetColorInfo().Name} badge-pill" : "badge badge-dark badge-pill")}\">{this.Badge}</span>");
            }
        }
    }
}
