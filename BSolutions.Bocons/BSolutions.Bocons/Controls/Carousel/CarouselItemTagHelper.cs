namespace BSolutions.Bocons.Controls.Carousel
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [HtmlTargetElement("carousel-item", ParentTag = "carousel")]
    [OutputElementHint("div")]
    public class CarouselItemTagHelper : BreconsTagHelperBase
    {
        public CarouselItemTagHelper(IActionContextAccessor actionContextAccessor)
        {
            this.ActionContextAccessor = actionContextAccessor;
        }

        #region --- Attribute Names ---

        private const string ActiveAttributeName = AttributePrefix + "active";
        private const string SrcAttributeName = AttributePrefix + "src";
        private const string AltAttributeName = AttributePrefix + "alt";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(SrcAttributeName)]
        [ConvertVirtualUrl]
        public string Src { get; set; }

        [HtmlAttributeName(AltAttributeName)]
        public string Alt { get; set; }

        [HtmlAttributeName(ActiveAttributeName)]
        public bool Active { get; set; }

        [Context]
        protected CarouselTagHelper CarouselContext { get; set; }

        #endregion

        public override void Init(TagHelperContext context)
        {
            base.Init(context);
            CarouselContext.Items.Add(this);
        }

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("carousel-item");

            // Active
            if (this.Active)
            {
                output.AddCssClass("active");
            }

            output.PreContent.PrependHtml($"<img class=\"d-block w-100\" src=\"{this.Src}\" alt=\"{this.Alt}\" />");
            output.Content.SetHtmlContent(await output.GetChildContentAsync());

            // Caption
            if (!output.Content.IsEmptyOrWhiteSpace)
            {
                output.PreContent.AppendHtml("<div class=\"carousel-caption d-none d-md-block\">");
                output.PostContent.PrependHtml("</div>");
            }
        }
    }
}
