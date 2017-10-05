namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Controls;

    [OutputElementHint("small")]
    [HtmlTargetElement("help", ParentTag = "form-group")]
    public class HelpTagHelper : BreconsTagHelperBase
    {
        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            output.AddCssClass("form-text text-muted");
        }

        public static IHtmlContent Build(string content, string helpId)
        {
            TagBuilder help = new TagBuilder("small");
            help.GenerateId(helpId, "-");
            help.AddCssClass("form-text text-muted");
            help.InnerHtml.Append(content);

            return help;
        }
    }
}
