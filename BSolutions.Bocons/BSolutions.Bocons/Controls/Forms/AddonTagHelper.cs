namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;

    [HtmlTargetElement("addon", ParentTag = "input-group")]
    [OutputElementHint("span")]
    public class AddonTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string TypeAttributeName = AttributePrefix + "type";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(TypeAttributeName)]
        public AddonType Type { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass($"input-group-{this.Type.GetEnumInfo().Name}");
        }

        public static IHtmlContent Build(string text, AddonType type)
        {
            TagBuilder addon = new TagBuilder("div");
            addon.AddCssClass($"input-group-{type.GetEnumInfo().Name}");
            addon.InnerHtml.AppendHtml($"<span class=\"input-group-text\">{text}</span>");

            return addon;
        }
    }
}
