namespace BSolutions.Bocons.Controls.ListGroup
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [ContextClass]
    [RestrictChildren("list-group-item", "list-group-link", "list-group-button")]
    public class ListGroupTagHelper : BreconsTagHelperBase
    {
        [HtmlAttributeNotBound]
        public bool IsLinkGroup { get; set; }

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.GetChildContentAsync();

            output.TagName = this.IsLinkGroup ? "div" : "ul";
            output.AddCssClass("list-group");
        }
    }
}
