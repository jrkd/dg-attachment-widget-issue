#pragma checksum "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd030b309030d8751a5a4354491cea66dbbeac5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brewers_BrewersList), @"mvc.1.0.view", @"/Views/Brewers/BrewersList.cshtml")]
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
#nullable restore
#line 1 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
using DancingGoat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd030b309030d8751a5a4354491cea66dbbeac5b", @"/Views/Brewers/BrewersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Brewers_BrewersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductListItemViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n");
#nullable restore
#line 4 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
 if (Model.Any())
{
    foreach (var brewer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- 3 products on row for large screen -->\r\n        <div class=\"col-md-6 col-lg-4\">\r\n            ");
#nullable restore
#line 10 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
       Write(Html.DisplayFor(m => brewer, "ProductListItem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 12 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"ContentLabel\">");
#nullable restore
#line 16 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
                          Write(HtmlLocalizer["No matching products."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 17 "D:\code\dg_1506\DancingGoatCore\Views\Brewers\BrewersList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductListItemViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
