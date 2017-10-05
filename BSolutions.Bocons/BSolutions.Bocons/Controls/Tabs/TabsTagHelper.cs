namespace BSolutions.Bocons.Controls.Tabs
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [OutputElementHint("nav")]
    [GenerateId("tabs-")]
    [ContextClass]
    [RestrictChildren("tabs-pane")]
    public class TabsTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string PillsAttributeName = AttributePrefix + "pills";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(PillsAttributeName)]
        public bool Pills { get; set; }

        [HtmlAttributeNotBound]
        public List<TabsPaneTagHelper> Panes { get; set; } = new List<TabsPaneTagHelper>();

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = "nav";
            output.AddCssClass(this.Pills ? "nav nav-pills mb-3" : "nav nav-tabs");
            output.MergeAttribute("role", "tablist");
            
            // Active
            if(!this.Panes.Any(p => p.IsActive))
            {
                this.Panes.First().IsActive = true;
            }

            // Tab Item
            foreach(var pane in this.Panes)
            {
                output.PreContent.AppendHtml(this.BuildTabItem(pane));
            }

            // Tab Pane
            output.PostElement.AppendHtml("<div class=\"tab-content\">");

            foreach (var pane in this.Panes)
            {
                output.PostElement.AppendHtml(this.BuildTabPane(pane));
            }

            output.PostElement.AppendHtml("</div>");
        }

        private IHtmlContent BuildTabItem(TabsPaneTagHelper pane)
        {
            TagBuilder item = new TagBuilder("a");
            item.AddCssClass(pane.IsActive ? "nav-item nav-link active" : "nav-item nav-link");
            item.GenerateId($"{pane.Id}-tab", "-");
            item.MergeAttribute("data-toggle", this.Pills ? "pill" : "tab");
            item.MergeAttribute("role", "tab");
            item.MergeAttribute("href", $"#{pane.Id}");
            item.MergeAttribute("aria-controls", pane.Id);
            item.MergeAttribute("aria-expanded", pane.IsActive ? "true" : "false");
            item.InnerHtml.Append(pane.Header);

            return item;
        }

        private IHtmlContent BuildTabPane(TabsPaneTagHelper pane)
        {
            TagBuilder item = new TagBuilder("div");
            item.AddCssClass(pane.IsActive ? "tab-pane fade show active" : "tab-pane fade");
            item.GenerateId($"{pane.Id}", "-");
            item.MergeAttribute("role", "tabpanel");
            item.MergeAttribute("aria-labelledby", $"{pane.Id}-tab");
            item.InnerHtml.AppendHtml(pane.Content.GetContent());

            return item;
        }
    }
}
