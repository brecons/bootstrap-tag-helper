namespace BSolutions.Bocons.Controls.GridSystem
{
    using BSolutions.Brecons.Core.Controls;
    using BSolutions.Brecons.Core.Enumerations;
    using BSolutions.Brecons.Core.Extensions;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Linq;

    [OutputElementHint("div")]
    [HtmlTargetElement("column", ParentTag = "row")]
    public class ColumnTagHelper : BreconsTagHelperBase
    {
        #region --- Attribute Names ---

        private const string XsSizeAttributeName = "xs-size";
        private const string SmSizeAttributeName = "sm-size";
        private const string MdSizeAttributeName = "md-size";
        private const string LgSizeAttributeName = "lg-size";
        private const string XlSizeAttributeName = "xl-size";
        private const string XsOffsetAttributeName = "xs-offset";
        private const string SmOffsetAttributeName = "sm-offset";
        private const string MdOffsetAttributeName = "md-offset";
        private const string LgOffsetAttributeName = "lg-offset";
        private const string XlOffsetAttributeName = "xl-offset";
        private const string XsRenderAttributeName = "xs-render";
        private const string SmRenderAttributeName = "sm-render";
        private const string MdRenderAttributeName = "md-render";
        private const string LgRenderAttributeName = "lg-render";
        private const string XlRenderAttributeName = "xl-render";
        private const string XsOrderAttributeName = "xs-order";
        private const string SmOrderAttributeName = "sm-order";
        private const string MdOrderAttributeName = "md-order";
        private const string LgOrderAttributeName = "lg-order";
        private const string XlOrderAttributeName = "xl-order";
        private const string VerticalAlignmentAttributeName = "vertical-alignment";

        #endregion

        #region --- Properties ---

        [HtmlAttributeName(XsSizeAttributeName)]
        public int XsSize { get; set; }

        [HtmlAttributeName(SmSizeAttributeName)]
        public int SmSize { get; set; }

        [HtmlAttributeName(MdSizeAttributeName)]
        public int MdSize { get; set; }

        [HtmlAttributeName(LgSizeAttributeName)]
        public int LgSize { get; set; }

        [HtmlAttributeName(XlSizeAttributeName)]
        public int XlSize { get; set; }

        [HtmlAttributeName(XsOffsetAttributeName)]
        public int XsOffset { get; set; }

        [HtmlAttributeName(SmOffsetAttributeName)]
        public int SmOffset { get; set; }

        [HtmlAttributeName(MdOffsetAttributeName)]
        public int MdOffset { get; set; }

        [HtmlAttributeName(LgOffsetAttributeName)]
        public int LgOffset { get; set; }

        [HtmlAttributeName(XlOffsetAttributeName)]
        public int XlOffset { get; set; }

        [HtmlAttributeName(XsRenderAttributeName)]
        public GridColumnRenderType XsRender { get; set; } = GridColumnRenderType.Fixed;

        [HtmlAttributeName(SmRenderAttributeName)]
        public GridColumnRenderType SmRender { get; set; } = GridColumnRenderType.Fixed;

        [HtmlAttributeName(MdRenderAttributeName)]
        public GridColumnRenderType MdRender { get; set; } = GridColumnRenderType.Fixed;

        [HtmlAttributeName(LgRenderAttributeName)]
        public GridColumnRenderType LgRender { get; set; } = GridColumnRenderType.Fixed;

        [HtmlAttributeName(XlRenderAttributeName)]
        public GridColumnRenderType XlRender { get; set; } = GridColumnRenderType.Fixed;

        [HtmlAttributeName(XsOrderAttributeName)]
        public int XsOrder { get; set; }

        [HtmlAttributeName(SmOrderAttributeName)]
        public int SmOrder { get; set; }

        [HtmlAttributeName(MdOrderAttributeName)]
        public int MdOrder { get; set; }

        [HtmlAttributeName(LgOrderAttributeName)]
        public int LgOrder { get; set; }

        [HtmlAttributeName(XlOrderAttributeName)]
        public int XlOrder { get; set; }

        [HtmlAttributeName(VerticalAlignmentAttributeName)]
        public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Default;

        #endregion

        protected override void RenderProcess(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            // Size
            this.ProceedSize(output);

            // Offset
            this.ProcessOffset(output);

            // Order
            this.ProceedOrder(output);

            // Alignment
            switch(this.VerticalAlignment)
            {
                case VerticalAlignment.Top:
                    output.AddCssClass("align-self-start");
                    break;
                case VerticalAlignment.Middle:
                    output.AddCssClass("align-self-center");
                    break;
                case VerticalAlignment.Bottom:
                    output.AddCssClass("align-self-end");
                    break;
            }
        }

        private void ProceedSize(TagHelperOutput output)
        {
            // Extra Small Size
            switch(this.XsRender)
            {
                case GridColumnRenderType.Dynamic:
                    output.AddCssClass("col-auto");
                    break;
                case GridColumnRenderType.Fixed:
                    if (this.XsSize > 0 && this.XsSize <= 12) output.AddCssClass($"col-{this.XsSize}");
                    break;
                case GridColumnRenderType.Auto:
                    output.AddCssClass($"col");
                    break;
            }

            // Small Size
            switch (this.SmRender)
            {
                case GridColumnRenderType.Dynamic:
                    output.AddCssClass("col-sm-auto");
                    break;
                case GridColumnRenderType.Fixed:
                    if(this.SmSize > 0 && this.SmSize <= 12) output.AddCssClass($"col-sm-{this.SmSize}");
                    break;
                case GridColumnRenderType.Auto:
                    output.AddCssClass($"col-sm");
                    break;
            }

            // Medium Size
            switch (this.MdRender)
            {
                case GridColumnRenderType.Dynamic:
                    output.AddCssClass("col-md-auto");
                    break;
                case GridColumnRenderType.Fixed:
                    if (this.MdSize > 0 && this.MdSize <= 12) output.AddCssClass($"col-md-{this.MdSize}");
                    break;
                case GridColumnRenderType.Auto:
                    output.AddCssClass($"col-md");
                    break;
            }

            // Large Size
            switch (this.LgRender)
            {
                case GridColumnRenderType.Dynamic:
                    output.AddCssClass("col-lg-auto");
                    break;
                case GridColumnRenderType.Fixed:
                    if (this.LgSize > 0 && this.LgSize <= 12) output.AddCssClass($"col-lg-{this.LgSize}");
                    break;
                case GridColumnRenderType.Auto:
                    output.AddCssClass($"col-lg");
                    break;
            }

            // Extra Large Size
            switch (this.XlRender)
            {
                case GridColumnRenderType.Dynamic:
                    output.AddCssClass("col-xl-auto");
                    break;
                case GridColumnRenderType.Fixed:
                    if (this.XlSize > 0 && this.XlSize <= 12) output.AddCssClass($"col-xl-{this.XlSize}");
                    break;
                case GridColumnRenderType.Auto:
                    output.AddCssClass($"col-xl");
                    break;
            }

            // Default Size
            var classAttribute = output.Attributes.FirstOrDefault(a => a.Name == "class");
            if(classAttribute == null || !classAttribute.Value.ToString().Contains("col"))
            {
                output.AddCssClass("col");
            }
        }

        private void ProcessOffset(TagHelperOutput output)
        {
            // Extra Small Offset
            if(this.XsOffset > 0 && this.XsOffset <= 12)
            {
                output.AddCssClass($"offset-{this.XsOffset}");
            }

            // Small Offset
            if (this.SmOffset > 0 && this.SmOffset <= 12)
            {
                output.AddCssClass($"offset-sm-{this.SmOffset}");
            }

            // Medium Offset
            if (this.MdOffset > 0 && this.MdOffset <= 12)
            {
                output.AddCssClass($"offset-md-{this.MdOffset}");
            }

            // Large Offset
            if (this.LgOffset > 0 && this.LgOffset <= 12)
            {
                output.AddCssClass($"offset-lg-{this.LgOffset}");
            }

            // Extra Large Offset
            if (this.XlOffset > 0 && this.XlOffset <= 12)
            {
                output.AddCssClass($"offset-xl-{this.XlOffset}");
            }
        }

        private void ProceedOrder(TagHelperOutput output)
        {
            // Extra Small Order
            if(this.XsOrder > 0 && this.XsOrder <= 12)
            {
                output.AddCssClass($"order-{this.XsOrder}");
            }

            // Small Order
            if (this.SmOrder > 0 && this.SmOrder <= 12)
            {
                output.AddCssClass($"order-sm-{this.SmOrder}");
            }

            // Medium Order
            if (this.MdOrder > 0 && this.MdOrder <= 12)
            {
                output.AddCssClass($"order-md-{this.MdOrder}");
            }

            // Large Order
            if (this.LgOrder > 0 && this.LgOrder <= 12)
            {
                output.AddCssClass($"order-lg-{this.LgOrder}");
            }

            // Extra Large Order
            if (this.XlOrder > 0 && this.XlOrder <= 12)
            {
                output.AddCssClass($"order-xl-{this.XlOrder}");
            }
        }
    }
}
