namespace BSolutions.Bocons.Controls.Card
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("card-image", ParentTag = "card")]
    [OutputElementHint("img")]
    public class CardImageTagHelper : BreconsTagHelperBase
    {
        public CardImageTagHelper(IActionContextAccessor actionContextAccessor) : base()
        {
            this.ActionContextAccessor = actionContextAccessor;
        }

        #region --- Attribute Names ---

        private const string PositionAttributeName = AttributePrefix + "position";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(PositionAttributeName)]
        public CardImagePosition Position { get; set; } = CardImagePosition.Top;

        [CopyToOutput]
        [ConvertVirtualUrl]
        public string Src { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;

            // Position
            output.AddCssClass($"card-img-{this.Position.GetEnumInfo().Name}");
        }
    }
}
