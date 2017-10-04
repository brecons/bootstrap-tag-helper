namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using BSolutions.Brecons.Core.Localization;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("a")]
    [HtmlTargetElement("navbar-link", ParentTag = "navbar-nav")]
    [HtmlTargetElement("navbar-link", ParentTag = "navbar-dropdown")]
    public class NavbarLinkTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ActiveAttributeName = AttributePrefix +  "active";
        private const string DisableAttributeName = AttributePrefix + "disable";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ActiveAttributeName)]
        public bool Active { get; set; }

        [HtmlAttributeName(DisableAttributeName)]
        public bool IsDisabled { get; set; }

        [CopyToOutput]
        public string Href { get; set; } = "#";

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.AddCssClass(!context.HasContextItem<NavbarDropdownTagHelper>() ? "nav-link" : "dropdown-item");

            // Disabled
            if(this.IsDisabled)
            {
                output.AddCssClass("disabled");
            }

            // Active
            if (this.Active && context.HasContextItem<NavbarDropdownTagHelper>())
            {
                output.AddCssClass("active");
                output.PostContent.AppendHtml($"<span class=\"sr-only\">({Resources.Current})</span>");
            }
            else if (this.Active && !context.HasContextItem<NavbarDropdownTagHelper>())
            {
                output.PostContent.AppendHtml($"<span class=\"sr-only\">({Resources.Current})</span>");
                output.WrapHtmlOutside($"<li class=\"nav-item active\">", "</li>");
            }
            else if (!context.HasContextItem<NavbarDropdownTagHelper>())
            {
                output.WrapHtmlOutside($"<li class=\"nav-item\">", "</li>");
            }

}
    }
}
