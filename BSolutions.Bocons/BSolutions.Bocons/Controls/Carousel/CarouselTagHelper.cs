namespace BSolutions.Bocons.Controls.Carousel
{
    using BSolutions.Bocons.Localization;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [OutputElementHint("div")]
    [RestrictChildren("carousel-item")]
    [ContextClass]
    [GenerateId("carousel-")]
    public class CarouselTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ControlsAttributeName = AttributePrefix + "controls";
        private const string IndicatorsAttributeName = AttributePrefix + "indicators";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ControlsAttributeName)]
        public bool HasControls { get; set; }

        [HtmlAttributeName(IndicatorsAttributeName)]
        public bool HasIndicators { get; set; }

        [HtmlAttributeNotBound]
        public List<CarouselItemTagHelper> Items { get; } = new List<CarouselItemTagHelper>();

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddCssClass("carousel slide");
            output.AddDataAttribute("ride", "carousel");
            output.Content.SetHtmlContent(await output.GetChildContentAsync());

            // Indicators
            if(this.HasIndicators)
            {
                output.PreContent.AppendHtml("<ol class=\"carousel-indicators\">");
                for (int i = 0; i < this.Items.Count; i++)
                {
                    output.PreContent.AppendHtml(this.Items[i].Active
                        ? $"<li data-target=\"#{this.Id}\" data-slide-to=\"{i}\" class=\"active\"></li>"
                        : $"<li data-target=\"#{this.Id}\" data-slide-to=\"{i}\"></li>");
                }
                output.PreContent.AppendHtml("</ol>");
            }

            // Item wrapper
            output.Content.Wrap(new TagBuilder("div") { Attributes = { { "class", "carousel-inner" } } });

            // Controls
            if(this.HasControls)
            {
                output.PostContent.AppendHtml($"<a class=\"carousel-control-prev\" href=\"#{this.Id}\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span><span class=\"sr-only\">{Resources.Carousel_Previous}</span></a><a class=\"carousel-control-next\" href=\"#{Id}\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span><span class=\"sr-only\">{Resources.Carousel_Next}</span></a>");
            }
        }
    }
}
