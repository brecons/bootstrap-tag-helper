namespace BSolutions.Bocons.Controls.Table
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class TableTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string StripedAttributeName = AttributePrefix + "striped";
        private const string SmallAttributeName = AttributePrefix + "small";
        private const string BorderedAttributeName = AttributePrefix + "bordered";
        private const string ResponsiveAttributeName = AttributePrefix + "responsive";
        private const string HoverAttributeName = AttributePrefix + "hover";
        private const string InverseAttributeName = AttributePrefix + "inverse";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(StripedAttributeName)]
        public bool IsStriped { get; set; }

        [HtmlAttributeName(SmallAttributeName)]
        public bool IsSmall { get; set; }

        [HtmlAttributeName(BorderedAttributeName)]
        public bool IsBordered { get; set; }

        [HtmlAttributeName(ResponsiveAttributeName)]
        public bool IsResponsive { get; set; }

        [HtmlAttributeName(HoverAttributeName)]
        public bool IsHover { get; set; }

        [HtmlAttributeName(InverseAttributeName)]
        public bool IsInverse { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddCssClass("table");

            // Inverse
            if(this.IsInverse)
            {
                output.AddCssClass("table-inverse");
            }

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
