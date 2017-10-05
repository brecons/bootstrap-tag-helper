namespace BSolutions.Bocons.Controls.ListGroup
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("button")]
    [HtmlTargetElement("list-group-button", ParentTag = "list-group")]
    public class ListGroupButtonTagHelper : ListGroupLinkTagHelper
    {
        protected override string TagName => "button";
    }
}
