namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Bocons.Extensions;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("a", Attributes = ButtonAttributeName)]
    [HtmlTargetElement("button")]
    public class ButtonTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ButtonAttributeName = AttributePrefix + "button";
        private const string ColorAttributeName = AttributePrefix + "color";
        private const string OutlineAttributeName = AttributePrefix + "outline";
        private const string SizeAttributeName = AttributePrefix + "size";
        private const string BlockAttributeName = AttributePrefix + "block";
        private const string ActiveAttributeName = AttributePrefix + "active";
        private const string DisableAttributeName = AttributePrefix + "disable";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ButtonAttributeName)]
        public bool Button { get; set; }

        [HtmlAttributeName(ColorAttributeName)]
        public Color Color { get; set; } = Color.Primary;

        [HtmlAttributeName(OutlineAttributeName)]
        public bool IsOutline { get; set; }

        [HtmlAttributeName(SizeAttributeName)]
        public Size Size { get; set; } = Size.Default;

        [HtmlAttributeName(BlockAttributeName)]
        public bool IsBlock { get; set; }

        [HtmlAttributeName(ActiveAttributeName)]
        public bool IsActive { get; set; }

        [HtmlAttributeName(DisableAttributeName)]
        public bool IsDisabled { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddCssClass("btn");

            // Role
            if(output.TagName == "a")
            {
                output.MergeAttribute("role", "button");
            }

            // Color
            if(this.Color != Color.None)
            {
                output.AddCssClass(this.IsOutline ? $"btn-outline-{this.Color.GetColorInfo().Name}" : $"btn-{this.Color.GetColorInfo().Name}");
            }

            // Size
            if(this.Size != Size.Default)
            {
                output.AddCssClass($"btn-{this.Size.GetEnumInfo().Name}");
            }

            // Block
            if (this.IsBlock)
            {
                output.AddCssClass("btn-block");
            }

            // Active
            if(this.IsActive)
            {
                output.AddCssClass("active");
            }

            // Disable
            if (this.IsDisabled)
            {
                if(output.TagName == "a")
                {
                    output.AddCssClass("disabled");
                    output.AddAriaAttribute("disabled", "true");
                }
                else
                {
                    output.MergeAttribute("disabled", "disabled");
                }
                
            }
        }
    }
}
