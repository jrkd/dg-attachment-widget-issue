#pragma checksum "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705604177948686aed5ccd4e0a89dc1b7dfd6928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_YourAccount), @"mvc.1.0.view", @"/Views/Account/YourAccount.cshtml")]
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
#line 1 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
using Kentico.Membership.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705604177948686aed5ccd4e0a89dc1b7dfd6928", @"/Views/Account/YourAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_YourAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.YourAccountViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeAvatar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("avatarUploadForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-more"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Your account"].Value;
    ViewData["PageClass"] = "inverted no-bg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>");
#nullable restore
#line 11 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
   Write(HtmlLocalizer["Your account"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <h3>");
#nullable restore
#line 14 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
           Write(HtmlLocalizer["Personal details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div>");
#nullable restore
#line 15 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
            Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                                  Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 16 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
            Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 529, "\"", 567, 1);
#nullable restore
#line 18 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
WriteAttributeValue("", 536, Url.Action("Edit", "Account" ), 536, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                                                     Write(HtmlLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
         if (Model.User.Roles.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <h3>");
#nullable restore
#line 24 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
               Write(HtmlLocalizer["Roles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <ul>\r\n");
#nullable restore
#line 26 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                     foreach (var role in Model.User.Roles)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 28 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                       Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 32 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4\">\r\n        <div class=\"avatar\" onclick=\"document.getElementById(\'avatarUpload\').click()\">\r\n            <img class=\"avatar-image\"");
            BeginWriteAttribute("src", " src=\"", 1144, "\"", 1256, 1);
#nullable restore
#line 35 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
WriteAttributeValue("", 1150, Url.Kentico().AvatarUrl(Model.User.UserName, pathToDefaultAvatar: " ~/Content/Images/default-avatar.png"), 1150, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"avatar-upload-info\">\r\n                <div class=\"text\">");
#nullable restore
#line 37 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                             Write(HtmlLocalizer["Change photo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
         if (Model.AvatarUpdateFailed)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"avatar-error\">\r\n                <span class=\"avatar-error-message\">");
#nullable restore
#line 43 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
                                              Write(HtmlLocalizer["Please upload a valid image."]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <script type=""text/javascript"">
                if (window.history.replaceState) {
                    window.history.replaceState({}, document.title, window.location.pathname);
                }
            </script>
");
#nullable restore
#line 50 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705604177948686aed5ccd4e0a89dc1b7dfd692813103", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 53 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
       Write(Html.TextBox("avatarUpload", "", new { type = "file", id = "avatarUpload", accept = "image/*", onchange = "document.getElementById('avatarUploadForm').submit()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"clear\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705604177948686aed5ccd4e0a89dc1b7dfd692815677", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 61 "D:\code\dg_1506\DancingGoatCore\Views\Account\YourAccount.cshtml"
           Write(HtmlLocalizer["Your orders"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.YourAccountViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
