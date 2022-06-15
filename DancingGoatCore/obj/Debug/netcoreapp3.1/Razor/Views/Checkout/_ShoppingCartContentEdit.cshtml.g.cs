#pragma checksum "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c0b9dc14301a34c893c7cdf039c1ce33ab7a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout__ShoppingCartContentEdit), @"mvc.1.0.view", @"/Views/Checkout/_ShoppingCartContentEdit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\code\dg_1506\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c0b9dc14301a34c893c7cdf039c1ce33ab7a4c", @"/Views/Checkout/_ShoppingCartContentEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout__ShoppingCartContentEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CartViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
 foreach (var cartItem in Model.CartItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 7 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
             if (!string.IsNullOrEmpty(cartItem.SKUImagePath))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"cart-item-image\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 294, "\"", 358, 1);
#nullable restore
#line 10 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 301, Url.Action("ItemDetail", new { skuId = cartItem.SKUID }), 301, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 390, "\"", 418, 1);
#nullable restore
#line 11 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 396, cartItem.SKUImagePath, 396, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 419, "\"", 442, 1);
#nullable restore
#line 11 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 425, cartItem.SKUName, 425, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 443, "\"", 468, 1);
#nullable restore
#line 11 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 451, cartItem.SKUName, 451, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 14 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cart-item-info\">\r\n                ");
#nullable restore
#line 16 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
           Write(Html.ActionLink(cartItem.SKUName, "ItemDetail", new { skuId = cartItem.SKUID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61c0b9dc14301a34c893c7cdf039c1ce33ab7a4c7692", async() => {
                WriteLiteral("\r\n                <div class=\"cart-item-amount\">\r\n                    <span>Qty</span>\r\n                    <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 921, "\"", 949, 1);
#nullable restore
#line 21 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 929, cartItem.CartItemID, 929, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"text\" name=\"Units\"");
                BeginWriteAttribute("value", " value=\"", 1006, "\"", 1037, 1);
#nullable restore
#line 22 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 1014, cartItem.CartItemUnits, 1014, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                    <input type=\"submit\" name=\"update\"");
                BeginWriteAttribute("value", " value=\"", 1118, "\"", 1150, 1);
#nullable restore
#line 23 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 1126, HtmlLocalizer["update"], 1126, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-default\" />\r\n                    <input type=\"submit\" name=\"remove\"");
                BeginWriteAttribute("value", " value=\"", 1234, "\"", 1266, 1);
#nullable restore
#line 24 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
WriteAttributeValue("", 1242, HtmlLocalizer["remove"], 1242, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-default\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            \r\n            ");
#nullable restore
#line 28 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
       Write(Html.ValidationMessage(cartItem.CartItemID.ToString(), new { @class = "red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2 cart-item-subtotal\">\r\n            <span>");
#nullable restore
#line 31 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
             Write(Model.FormatPrice(cartItem.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 35 "D:\code\dg_1506\DancingGoatCore\Views\Checkout\_ShoppingCartContentEdit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
