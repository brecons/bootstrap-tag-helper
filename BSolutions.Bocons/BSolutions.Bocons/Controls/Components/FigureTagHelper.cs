namespace BSolutions.Bocons.Controls.Components
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("figure")]
    [HtmlTargetElement("figure", TagStructure = TagStructure.WithoutEndTag)]
    public class FigureTagHelper : BreconsTagHelperBase
    {
        public FigureTagHelper(IActionContextAccessor actionContextAccessor)
        {
            this.ActionContextAccessor = actionContextAccessor;
        }

        #region --- Attribute Names ---

        private const string ImageAttributeName = AttributePrefix + "image";
        private const string WidthAttributeName = AttributePrefix + "width";
        private const string HeightAttributeName = AttributePrefix + "height";
        private const string CaptionAttributeName = AttributePrefix + "caption";
        private const string HorizontalAligmentAttributeName = AttributePrefix + "alignment";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ImageAttributeName)]
        [ConvertVirtualUrl]
        public string Image { get; set; }

        [HtmlAttributeName(CaptionAttributeName)]
        public string Caption { get; set; }

        [HtmlAttributeName(HorizontalAligmentAttributeName)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        [HtmlAttributeName(WidthAttributeName)]
        public int Width { get; set; }

        [HtmlAttributeName(HeightAttributeName)]
        public int Height { get; set; }

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "figure";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.AddCssClass("figure");

            // Image
            TagBuilder img = new TagBuilder("img") { TagRenderMode = TagRenderMode.SelfClosing };
            img.AddCssClass("figure-img img-fluid rounded");
            img.Attributes.Add("src", this.Image);
            if (this.Width > 0) img.Attributes.Add("width", this.Width.ToString());
            if (this.Height > 0) img.Attributes.Add("height", this.Height.ToString());
            output.PreContent.AppendHtml(img);

            // Caption
            TagBuilder figcaption = new TagBuilder("figcaption");
            figcaption.AddCssClass("figure-caption");
            figcaption.InnerHtml.Append(this.Caption);
            
            // Alignment
            if(this.HorizontalAlignment != HorizontalAlignment.Default)
            {
                figcaption.AddCssClass($"text-{this.HorizontalAlignment.GetEnumInfo().Name}");
            }

            output.PostContent.AppendHtml(figcaption);
        }
    }
}
