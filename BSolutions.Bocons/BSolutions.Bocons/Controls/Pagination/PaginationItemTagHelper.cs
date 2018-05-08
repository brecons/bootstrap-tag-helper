namespace BSolutions.Bocons.Controls.Pagination
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using BSolutions.Bocons.Localization;

    [OutputElementHint("li")]
    [HtmlTargetElement("pagination-item", ParentTag = "pagination")]
    public class PaginationItemTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ActiveAttributeName = AttributePrefix + "active";
        private const string DisableAttributeName = AttributePrefix + "disable";

        #endregion

        #region --- Properties ---

        public string Href { get; set; } = "#";

        [HtmlAttributeName(ActiveAttributeName)]
        public bool IsActive { get; set; }

        [HtmlAttributeName(DisableAttributeName)]
        public bool IsDisabled { get; set; }

        [HtmlAttributeNotBound]
        public string Content { get; set; }

        [Context]
        protected PaginationTagHelper PaginationContext { get; set; }

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();
            Content = (await output.GetChildContentAsync()).GetContent();
            PaginationContext.Items.Add(this);
        }

        public IHtmlContent Generate()
        {
            TagBuilder li = new TagBuilder("li");
            li.AddCssClass("page-item");

            // Active
            if(this.IsActive)
            {
                li.AddCssClass("active");
                li.InnerHtml.AppendHtml($"<a class=\"page-link\" href=\"{this.Href}\">{this.Content} <span class=\"sr-only\">({Resources.Pagination_Current})</span></a>");
            }
            else
            {
                li.InnerHtml.AppendHtml($"<a class=\"page-link\" href=\"{this.Href}\">{this.Content}</a>");
            }

            // Disabled
            if(this.IsDisabled)
            {
                li.AddCssClass("disabled");
            }

            return li;
        }
    }
}
