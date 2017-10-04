namespace BSolutions.Bocons.Controls.Tabs
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [HtmlTargetElement("tabs-pane", ParentTag = "tabs")]
    [GenerateId("pane-")]
    public class TabsPaneTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string HeaderAttributeName = AttributePrefix + "header";
        private const string ActiveAttributeName = AttributePrefix + "active";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(HeaderAttributeName)]
        public string Header { get; set; }

        [HtmlAttributeName(ActiveAttributeName)]
        public bool IsActive { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public TabsTagHelper TabsContext { get; set; }

        [HtmlAttributeNotBound]
        public TagHelperContent Content { get; set; }

        #endregion

        public override void Init(TagHelperContext context)
        {
            base.Init(context);
            this.TabsContext.Panes.Add(this);
        }

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            this.Content = await output.GetChildContentAsync();
            output.SuppressOutput();
        }
    }
}
