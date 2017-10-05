namespace BSolutions.Bocons.Controls.Buttons
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("a", ParentTag = "button-dropdown")]
    public class ButtonDropdownItemTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string DisableAttributeName = AttributePrefix + "disable";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(DisableAttributeName)]
        public bool IsDisabled { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddCssClass("dropdown-item");

            //Disabled
            if(this.IsDisabled)
            {
                output.AddCssClass("disabled");
            }
        }
    }
}
