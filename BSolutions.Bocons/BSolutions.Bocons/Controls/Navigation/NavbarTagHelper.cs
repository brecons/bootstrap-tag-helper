namespace BSolutions.Bocons.Controls.Navigation
{
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using BSolutions.Brecons.Core.Localization;
    using Enumerations;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [OutputElementHint("nav")]
    [RestrictChildren("navbar-nav", "navbar-form", "navbar-text")]
    [GenerateId("navbar-", false)]
    public class NavbarTagHelper : BreconsTagHelperBase
    {
        public NavbarTagHelper(IActionContextAccessor actionContextAccessor)
        {
            this.ActionContextAccessor = actionContextAccessor;
        }

        #region --- Attribute Names ---

        private const string BrandTextAttributeName = AttributePrefix + "brand-text";
        private const string BrandImageAttributeName = AttributePrefix + "brand-image";
        private const string BrandHrefAttributeName = AttributePrefix + "brand-href";
        private const string ThemeAttributeName = AttributePrefix + "theme";
        private const string BackgroundAttributeName = AttributePrefix + "background";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(BrandHrefAttributeName)]
        public string BrandHref { get; set; } = "#";

        [HtmlAttributeName(BrandTextAttributeName)]
        public string BrandText { get; set; }

        [HtmlAttributeName(BrandImageAttributeName)]
        [ConvertVirtualUrl]
        public string BrandImage { get; set; }

        [HtmlAttributeName(ThemeAttributeName)]
        public Theme Theme { get; set; } = Theme.Light;

        [HtmlAttributeName(BackgroundAttributeName)]
        public Color Background { get; set; } = Color.Light;

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = "nav";
            output.AddCssClass("navbar navbar-expand-lg");

            // Theme
            if(this.Theme != Theme.Default)
            {
                output.AddCssClass($"navbar-{this.Theme.GetEnumInfo().Name}");

                // Set background to valid color
                this.Background = this.Theme == Theme.Dark && this.Background == Color.Light ? Color.Dark : this.Background;
            }
            else
            {
                output.AddCssClass($"navbar-light");
            }

            // Background
            output.AddCssClass(this.Background.GetColorInfo().BackgroundCssClass);

            // Brand
            if(!string.IsNullOrEmpty(this.BrandText) || !string.IsNullOrEmpty(this.BrandImage))
            {
                output.PreContent.AppendHtml(this.GenerateBrand());
            }

            // Toggler
            output.PreContent.AppendHtml($"<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#{this.Id}\" aria-controls=\"{this.Id}\" aria-expanded=\"false\" aria-label=\"{Resources.ToggleNavigation}\"><span class=\"navbar-toggler-icon\"></span></button>");

            // Wrapper
            output.WrapHtmlContentInside($"<div class=\"collapse navbar-collapse\" id=\"{this.Id}\">", "</div>");
        }

        private IHtmlContent GenerateBrand()
        {
            // Anchor
            TagBuilder brand = new TagBuilder("a");
            brand.AddCssClass("navbar-brand");
            brand.Attributes.Add("href", this.BrandHref);

            // Image
            if(!string.IsNullOrEmpty(this.BrandImage))
            {
                TagBuilder img = new TagBuilder("img") { TagRenderMode = TagRenderMode.SelfClosing };
                img.Attributes.Add("src", this.BrandImage);
                img.Attributes.Add("height", "30");
                img.Attributes.Add("alt", this.BrandText);

                if(!string.IsNullOrEmpty(this.BrandText))
                {
                    img.AddCssClass("d-inline-block align-top");
                }

                brand.InnerHtml.AppendHtml(img);
            }

            // Text
            brand.InnerHtml.Append($" {this.BrandText}");

            return brand;
        }
    }
}
