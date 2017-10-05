namespace BSolutions.Bocons.Extensions
{
    using BSolutions.Bocons.Controls.Forms;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    internal static class FormTagHelperExtensions
    {
        /// <summary>
        /// Checks if the bounded property of the tag helper is valid.
        /// </summary>
        /// <param name="tagHelper">The tag helper.</param>
        /// <returns>Returns true if the bounded property is valid,</returns>
        /// <remarks>If no property is bound to the tag helper, the result is true.</remarks>
        internal static bool IsValid(this BoconsFormTagHelperBase tagHelper)
        {
            if(tagHelper.For != null)
            {
                return tagHelper.ViewContext.ViewData.ModelState.GetFieldValidationState(tagHelper.For.Metadata.PropertyName) == ModelValidationState.Valid;
            }

            return true;
        }

        /// <summary>
        /// Checks if the bounded property of the tag helper is valid on a POST request.
        /// </summary>
        /// <param name="tagHelper">The tag helper.</param>
        /// <returns>Returns true if the bounded property is valid,</returns>
        /// <remarks>If no property is bound to the tag helper or the request is not a POST, the result is true.</remarks>
        internal static bool IsPostValid(this BoconsFormTagHelperBase tagHelper)
        {
            if (tagHelper.For != null && tagHelper.ViewContext.HttpContext.Request.Method == "POST")
            {
                return tagHelper.ViewContext.ViewData.ModelState.GetFieldValidationState(tagHelper.For.Metadata.PropertyName) == ModelValidationState.Valid;
            }

            return true;
        }
    }
}
