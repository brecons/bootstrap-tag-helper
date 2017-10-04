namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;

    [HtmlTargetElement("*", Attributes = PopoverAttributeName)]
    public class PopoverTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string PopoverAttributeName = AttributePrefix + "popover";
        private const string TitleAttributeName = PopoverAttributeName + "-title";
        private const string DismissibleAttributeName = PopoverAttributeName + "-dismissible";
        private const string DelayAttributeName = PopoverAttributeName + "-delay";
        private const string PlacementAttributeName = PopoverAttributeName + "-placement";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeName(PopoverAttributeName)]
        [CopyToOutput("data-content")]
        public string Content { get; set; }

        [HtmlAttributeName(PlacementAttributeName)]
        public Placement Placement { get; set; } = Placement.Top;

        [HtmlAttributeName(DismissibleAttributeName)]
        public bool Dismissible { get; set; }

        [HtmlAttributeName(DelayAttributeName)]
        [CopyToOutput("data-delay")]
        public int Delay { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.AddDataAttribute("toggle", "popover");
            output.AddDataAttribute("container", "body");
            output.AddDataAttribute("placement", this.Placement.GetEnumInfo().Name);

            // Title
            if(!string.IsNullOrEmpty(this.Title))
            {
                output.MergeAttribute("title", this.Title);
            }

            // Dismissible
            if (this.Dismissible)
            {
                output.AddDataAttribute("trigger", "focus");
            }
        }
    }
}
