namespace BSolutions.Bocons.Controls.Table
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class TableTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string StripedAttributeName = AttributePrefix + "striped";
        private const string SmallAttributeName = AttributePrefix + "small";
        private const string BorderedAttributeName = AttributePrefix + "bordered";
        private const string BorderlessAttributeName = AttributePrefix + "borderless";
        private const string ResponsiveAttributeName = AttributePrefix + "responsive";
        private const string HoverAttributeName = AttributePrefix + "hover";
        private const string ThemeAttributeName = AttributePrefix + "theme";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(StripedAttributeName)]
        public bool IsStriped { get; set; }

        [HtmlAttributeName(SmallAttributeName)]
        public bool IsSmall { get; set; }

        [HtmlAttributeName(BorderedAttributeName)]
        public bool IsBordered { get; set; }

        [HtmlAttributeName(BorderlessAttributeName)]
        public bool IsBorderless { get; set; }

        [HtmlAttributeName(ResponsiveAttributeName)]
        public bool IsResponsive { get; set; }

        [HtmlAttributeName(HoverAttributeName)]
        public bool IsHover { get; set; }

        [HtmlAttributeName(ThemeAttributeName)]
        public Theme Theme { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddCssClass("table");

            // Theme
            output.AddCssClass(this.Theme != Theme.Default ? $"table-{this.Theme.GetEnumInfo().Name}" : string.Empty);

            // Striped
            if (this.IsStriped)
            {
                output.AddCssClass("table-striped");
            }

            // Small
            if (this.IsSmall)
            {
                output.AddCssClass("table-sm");
            }

            // Bordered
            if (this.IsBordered)
            {
                output.AddCssClass("table-bordered");
            }

            // Borderless
            if(this.IsBorderless)
            {
                output.AddCssClass("table-borderless");
            }

            // Hover
            if (this.IsHover)
            {
                output.AddCssClass("table-hover");
            }

            // Responsive
            if(this.IsResponsive)
            {
                output.AddCssClass("table-responsive");
            }
        }
    }
}
