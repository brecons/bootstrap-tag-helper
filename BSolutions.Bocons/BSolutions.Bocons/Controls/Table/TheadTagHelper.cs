namespace BSolutions.Bocons.Controls.Table
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("thead")]
    [HtmlTargetElement("thead", ParentTag = "table")]
    public class TheadTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ThemeAttributeName = AttributePrefix + "theme";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ThemeAttributeName)]
        public Theme Theme { get; set; } = Theme.Default;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            // Theme
            output.AddCssClass(this.Theme != Theme.Default ? $"thead-{this.Theme.GetEnumInfo().Name}" : string.Empty);
        }
    }
}
