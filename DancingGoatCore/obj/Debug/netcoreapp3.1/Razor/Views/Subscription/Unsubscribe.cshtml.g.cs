#pragma checksum "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d433fdb9fb555bacaa354e8307e7529f99bcb7e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_Unsubscribe), @"mvc.1.0.view", @"/Views/Subscription/Unsubscribe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d433fdb9fb555bacaa354e8307e7529f99bcb7e5", @"/Views/Subscription/Unsubscribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Subscription_Unsubscribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.UnsubscriptionModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Newsletter unsubscription"];
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"row text-and-image\">\n    <div class=\"col-md-6\">\n        <div class=\"text-and-image-text\">\n            <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 354, 1);
#nullable restore
#line 10 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
WriteAttributeValue("", 308, Url.Content("~/Content/Images/empty_cup.jpg"), 308, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n    </div>\n    <div class=\"col-md-6\">\n        <h2>");
#nullable restore
#line 14 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
       Write(HtmlLocalizer[ViewData.ModelState.IsValid ? "Goodbye!" : "Oops!"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <p>\n            <span class=\"InfoLabel\">\n");
#nullable restore
#line 17 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
                 if (!string.IsNullOrEmpty(Model.UnsubscriptionResult))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
               Write(Model.UnsubscriptionResult);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
                                               
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
               Write(Html.ValidationMessage("ErrorMessage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\code\dg_1506\DancingGoatCore\Views\Subscription\Unsubscribe.cshtml"
                                                           ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\n</p>\n    </div>\n</section>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.UnsubscriptionModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
