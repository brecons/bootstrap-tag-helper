namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("radio-list", ParentTag = "form-group")]
    [ContextClass]
    public class RadioListTagHelper : CheckboxListTagHelper
    {
        protected override string CssClass => "radio-list";
    }
}
