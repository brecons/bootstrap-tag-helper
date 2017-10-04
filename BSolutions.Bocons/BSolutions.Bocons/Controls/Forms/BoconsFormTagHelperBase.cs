namespace BSolutions.Bocons.Controls.Forms
{
    using BSolutions.Brecons.Core.Attributes.Controls;
    using BSolutions.Brecons.Core.Controls;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    /// <summary>
    /// Base class for each Brecons Bootstrap form tag helper.
    /// </summary>
    /// <seealso cref="BSolutions.Brecons.TagHelper.Controls.FormTagHelperBase" />
    public abstract class BoconsFormTagHelperBase : FormTagHelperBase
    {
        #region --- Properties ---

        [Context]
        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }

        [Context]
        [HtmlAttributeNotBound]
        public FormGroupTagHelper FormGroupContext { get; set; }

        #endregion

        public override void Init(TagHelperContext context)
        {
            base.Init(context);

            if(this.FormContext != null && this.FormContext.Validation)
            {
                this.Validation = this.FormContext.Validation;
            }
        }
    }
}
