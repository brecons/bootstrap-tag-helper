namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [HtmlTargetElement("navbar-dropdown", ParentTag = "navbar-nav")]
    [RestrictChildren("navbar-link")]
    [GenerateId("navbar-dropdown-", false)]
    [ContextClass]
    public class NavbarDropdownTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string TitleAttributeName = AttributePrefix + "title";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = "li";
            output.AddCssClass("nav-item dropdown");

            // Dropdown Button
            output.PreContent.AppendHtml($"<a href=\"#\" class=\"nav-link dropdown-toggle\" id=\"{this.Id}\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">{this.Title}</a>");

            // Dropdown Items
            output.PreContent.AppendHtml($"<div class=\"dropdown-menu\" aria-labelledby=\"{this.Id}\">");
            output.PostContent.AppendHtml("</div>");
        }
    }
}
