namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [RestrictChildren("button", "a", "button-dropdown")]
    [OutputElementHint("div")]
    public class ButtonGroupTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string VerticalAttributeName = AttributePrefix + "vertical";
        private const string SizeAttributeName = AttributePrefix + "size";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(SizeAttributeName)]
        public Size Size { get; set; } = Size.Default;

        [HtmlAttributeName(VerticalAttributeName)]
        public bool IsVertical { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass(this.IsVertical ? "btn-group-vertical" : "btn-group");
            output.MergeAttribute("role", "group");

            // Size
            if(this.Size != Size.Default)
            {
                output.AddCssClass($"btn-group-{this.Size.GetEnumInfo().Name}");
            }
        }
    }
}
