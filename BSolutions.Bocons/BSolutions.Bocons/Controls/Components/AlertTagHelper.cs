namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Bocons.Localization;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;

    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    [OutputElementHint("div")]
    public class AlertTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ColorAttributeName = AttributePrefix + "color";
        private const string DismissibleAttributeName = AttributePrefix + "dismissible";
        private const string DisableLinkStylingAttributeName = AttributePrefix + "disable-link-styling";
        private const string TitleAttributeName = AttributePrefix + "title";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.Primary;

        [HtmlAttributeName(DismissibleAttributeName)]
        public bool Dismissible { get; set; }

        [HtmlAttributeName(DisableLinkStylingAttributeName)]
        public bool DisableLinkStyling { get; set; }

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("alert");
            output.MergeAttribute("role", "alert");

            // Color
            if(this.Color != Color.None)
            {
                output.AddCssClass($"alert-{this.Color.GetColorInfo().Name}");
            }

            // Title
            if (!string.IsNullOrEmpty(this.Title))
            {
                output.PreContent.AppendHtml($"<h4 class=\"alert-heading\">{this.Title}</h4> ");
            }

            // Dismissible
            if (this.Dismissible)
            {
                output.AddCssClass("alert-dismissible");
                output.PreContent.SetHtmlContent($"<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"{Resources.Alert_CloseIconText}\"><span aria-hidden=\"true\">&times;</span></button>");
            }

            // Disable Link Styling
            if (!DisableLinkStyling)
            {
                var content = await output.GetChildContentAsync(true);
                output.Content.SetHtmlContent(Regex.Replace(content.GetContent(), "<a( [^>]+)?>", this.AddLinkStyle));
            }
        }

        private string AddLinkStyle(Match match)
        {
            if (match.ToString().Contains("class=\""))
            {
                return match.ToString().Replace("class=\"", "class=\"alert-link ");
            }

            return "<a class=\"alert-link\"" + match.ToString().Substring(2);

        }
    }
}
