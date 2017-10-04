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
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.AddCssClass("input-group-addon");
        }

        public static IHtmlContent Build(string text)
        {
            TagBuilder addon = new TagBuilder("span");
            addon.AddCssClass("input-group-addon");
            addon.InnerHtml.Append(text);

            return addon;
        }
    }
}
