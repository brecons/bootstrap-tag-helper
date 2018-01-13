namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Controls;

    [HtmlTargetElement("addon", ParentTag = "input-group")]
    [OutputElementHint("span")]
    public class AddonTagHelper : BreconsTagHelperBase
    {
        private const string AppendAttributeName = AttributePrefix + "append";

        [HtmlAttributeName(AppendAttributeName)]
        public bool IsAppend { get; set; }

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass(this.IsAppend ? "input-group-append" : "input-group-prepend");
        }

        public static IHtmlContent Build(string text, bool isAppend)
        {
            TagBuilder addon = new TagBuilder("div");
            addon.AddCssClass(isAppend ? "input-group-append" : "input-group-prepend");
            addon.InnerHtml.AppendHtml($"<span class=\"input-group-text\">{text}</span>");

            return addon;
        }
    }
}
