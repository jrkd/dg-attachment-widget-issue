#pragma checksum "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb3eee99650be205caac5bd106a90a726dbd999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_FormSections_TitledSection__TitledSection), @"mvc.1.0.view", @"/Components/FormSections/TitledSection/_TitledSection.cshtml")]
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
#line 1 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\code\dg_1506\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
using Kentico.Forms.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
using DancingGoat.Components.FormSections.TitledSection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb3eee99650be205caac5bd106a90a726dbd999", @"/Components/FormSections/TitledSection/_TitledSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_FormSections_TitledSection__TitledSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormSectionViewModel<TitledSectionProperties>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
 if (!string.IsNullOrEmpty(Model?.Properties?.Title))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
Write(Html.Raw(Html.Kentico().ResolveRichText(Model.Properties.Title)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
                                                                     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 14 "D:\code\dg_1506\DancingGoatCore\Components\FormSections\TitledSection\_TitledSection.cshtml"
   Write(await Html.Kentico().FormZoneAsync());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormSectionViewModel<TitledSectionProperties>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
