namespace BSolutions.Bocons.Controls.Pagination
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using BSolutions.Bocons.Localization;

    [OutputElementHint("ul")]
    [RestrictChildren("pagination-item")]
    [ContextClass]
    public class PaginationTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string TitleAttributeName = AttributePrefix + "title";
        private const string SizeAttributeName = AttributePrefix + "size";
        private const string PreviousTextAttributeName = AttributePrefix + "previous-text";
        private const string PreviousHrefAttributeName = AttributePrefix + "previous-href";
        private const string NextHrefAttributeName = AttributePrefix + "next-href";
        private const string NextTextAttributeName = AttributePrefix + "next-text";
        private const string AlignmentAttributeName = AttributePrefix + "alignment";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeName(SizeAttributeName)]
        public Size Size { get; set; }

        [HtmlAttributeName(PreviousHrefAttributeName)]
        public string PreviousHref { get; set; }

        [HtmlAttributeName(PreviousTextAttributeName)]
        public string PreviousText { get; set; }

        [HtmlAttributeName(NextHrefAttributeName)]
        public string NextHref { get; set; }

        [HtmlAttributeName(NextTextAttributeName)]
        public string NextText { get; set; }

        [HtmlAttributeName(AlignmentAttributeName)]
        public HorizontalAlignment Alignment { get; set; }

        [HtmlAttributeNotBound]
        public List<PaginationItemTagHelper> Items { get; set; } = new List<PaginationItemTagHelper>();

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = "ul";
            output.AddCssClass("pagination");

            // Previous
            if (this.Items.Any() && this.Items.First().IsActive)
            {
                output.Content.AppendHtml($"<li class=\"page-item disabled\"><a class=\"page-link\" href=\"{this.PreviousHref}\" aria-label=\"{Resources.Pagination_Previous}\"><span aria-hidden=\"true\">{(!string.IsNullOrEmpty(this.PreviousText) ? this.PreviousText : "&laquo;")}</span><span class=\"sr-only\">{Resources.Pagination_Previous}</span></a></li>");
            }
            else
            {
                output.Content.AppendHtml($"<li class=\"page-item\"><a class=\"page-link\" href=\"{this.PreviousHref}\" aria-label=\"{Resources.Pagination_Previous}\"><span aria-hidden=\"true\">{(!string.IsNullOrEmpty(this.PreviousText) ? this.PreviousText : "&laquo;")}</span><span class=\"sr-only\">{Resources.Pagination_Previous}</span></a></li>");
            }

            // Items
            foreach (var item in this.Items)
            {
                output.Content.AppendHtml(item.Generate());
            }

            // Next
            if (this.Items.Any() && this.Items.Last().IsActive)
            {
                output.Content.AppendHtml($"<li class=\"page-item disabled\"><a class=\"page-link\" href=\"{this.NextHref}\" aria-label=\"{Resources.Pagination_Next}\"><span aria-hidden=\"true\">{(!string.IsNullOrEmpty(this.NextText) ? this.NextText : "&raquo;")}</span><span class=\"sr-only\">{Resources.Pagination_Next}</span></a></li>");
            }
            else
            {
                output.Content.AppendHtml($"<li class=\"page-item\"><a class=\"page-link\" href=\"{this.NextHref}\" aria-label=\"{Resources.Pagination_Next}\"><span aria-hidden=\"true\">{(!string.IsNullOrEmpty(this.NextText) ? this.NextText : "&raquo;")}</span><span class=\"sr-only\">{Resources.Pagination_Next}</span></a></li>");
            }

            // Size
            if (this.Size != Size.Default)
            {
                output.AddCssClass($"pagination-{this.Size.GetEnumInfo().Name}");
            }

            // Alignment
            switch(this.Alignment)
            {
                case HorizontalAlignment.Center:
                    output.AddCssClass("justify-content-center");
                    break;
                case HorizontalAlignment.Right:
                    output.AddCssClass("justify-content-end");
                    break;
            }

            output.WrapHtmlOutside($"<nav aria-label=\"{(!string.IsNullOrEmpty(this.Title) ? this.Title : Resources.Pagination_Menu)}\">", "</nav>");
        }
    }
}
