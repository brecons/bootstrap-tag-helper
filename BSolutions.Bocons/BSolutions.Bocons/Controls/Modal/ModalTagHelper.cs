namespace BSolutions.Bocons.Controls.Modal
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Buttons;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Threading.Tasks;

    [ContextClass]
    [GenerateId("modal-")]
    [RestrictChildren("modal-header", "modal-body", "modal-footer")]
    public class ModalTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string ToggleButtonTextAttributeName = AttributePrefix + "toggle-text";
        private const string ToggleButtonColorAttributeName = AttributePrefix + "toggle-color";
        private const string TitleAttributeName = AttributePrefix + "title";
        private const string SizeAttributeName = AttributePrefix + "size";
        private const string PositionAttributeName = AttributePrefix + "position";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(ToggleButtonTextAttributeName)]
        public string ToggleButtonText { get; set; }

        [HtmlAttributeName(ToggleButtonColorAttributeName)]
        public Color ToggleButtonColor { get; set; }

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeNotBound]
        public string HeaderHtml { get; set; }

        [HtmlAttributeName(SizeAttributeName)]
        public Size Size { get; set; }

        [HtmlAttributeName(PositionAttributeName)]
        public ModalPosition Position { get; set; } = ModalPosition.Top;

        #endregion

        protected override async Task RenderProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await output.LoadChildContentAsync();

            // Header
            if (string.IsNullOrEmpty(this.HeaderHtml) && !string.IsNullOrEmpty(this.Title))
            {
                await new ModalHeaderTagHelper().RunTagHelperAsync(new TagHelperExtensions.Options { Context = context, Content = new DefaultTagHelperContent().AppendHtml(this.Title) });
            }

            // Toogle Button
            if (!string.IsNullOrEmpty(this.ToggleButtonText))
            {
                output.PreElement.AppendHtml(
                    await new ITagHelper[] {
                                    new ButtonTagHelper { Color = this.ToggleButtonColor },
                                    new ModalToggleTagHelper { ModalTarget = this.Id }
                    }.ToTagHelperContentAsync(
                        new TagHelperExtensions.Options
                        {
                            Content = new DefaultTagHelperContent().AppendHtml(this.ToggleButtonText),
                            TagName = "button"
                        }));
            }

            // Modal
            output.TagName = "div";
            output.AddCssClass("modal fade");
            output.Attributes.Add("tabindex", "-1");
            output.Attributes.Add("role", "dialog");
            output.Attributes.Add("aria-hidden", "true");

            // Header
            output.PreContent.AppendHtmlLine(this.HeaderHtml);

            // Content
            output.WrapContentOutside(this.BuildContent());

            // Dialog
            output.WrapContentOutside(this.BuildDialog());
        }

        private TagBuilder BuildDialog()
        {
            TagBuilder dialog = new TagBuilder("div");
            dialog.MergeAttribute("role", "document");
            dialog.AddCssClass("modal-dialog");

            // Size
            if(this.Size != Size.Default)
            {
                dialog.AddCssClass($"modal-{this.Size.GetEnumInfo().Name}");
            }

            // Position
            if(this.Position != ModalPosition.Top)
            {
                dialog.AddCssClass("modal-dialog-centered");
            }

            return dialog;
        }

        private TagBuilder BuildContent()
        {
            TagBuilder content = new TagBuilder("div");
            content.AddCssClass("modal-content");

            return content;
        }
    }
}
