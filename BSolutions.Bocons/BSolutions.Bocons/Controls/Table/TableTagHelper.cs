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
        private const string BorderAttributeName = AttributePrefix + "border";
        private const string HoverAttributeName = AttributePrefix + "hover";
        private const string ThemeAttributeName = AttributePrefix + "theme";
        private const string ResponsiveAttributeName = AttributePrefix + "responsive";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(StripedAttributeName)]
        public bool IsStriped { get; set; }

        [HtmlAttributeName(SmallAttributeName)]
        public bool IsSmall { get; set; }

        [HtmlAttributeName(BorderAttributeName)]
        public TableBorder Border { get; set; } = TableBorder.Regular;

        [HtmlAttributeName(HoverAttributeName)]
        public bool IsHover { get; set; }

        [HtmlAttributeName(ThemeAttributeName)]
        public Theme Theme { get; set; }

        [HtmlAttributeName(ResponsiveAttributeName)]
        public Breakpoint? Responsive { get; set; }

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

            // Border
            switch(this.Border)
            {
                case TableBorder.Bordered:
                    output.AddCssClass("table-bordered");
                    break;
                case TableBorder.Borderless:
                    output.AddCssClass("table-borderless");
                    break;
            }

            // Hover
            if (this.IsHover)
            {
                output.AddCssClass("table-hover");
            }

            // Responsive
            if(this.Responsive.HasValue)
            {
                output.WrapHtmlOutside($"<div class=\"{(this.Responsive.Value == Breakpoint.XSmall ? "table-responsive" : $"table-responsive-{this.Responsive.GetEnumInfo().Name}")}\">", "</div>");
            }
        }
    }
}