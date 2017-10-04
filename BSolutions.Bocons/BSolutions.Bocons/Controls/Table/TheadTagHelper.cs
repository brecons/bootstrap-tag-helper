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
            switch(this.Theme)
            {
                case Theme.Dark:
                    output.AddCssClass("thead-inverse");
                    break;
                case Theme.Light:
                    output.AddCssClass("thead-default");
                    break;
            }

            
        }
    }
}
