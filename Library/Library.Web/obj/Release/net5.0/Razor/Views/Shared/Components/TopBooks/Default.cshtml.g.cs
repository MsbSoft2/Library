#pragma checksum "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de15ce1a74f11a3a247e71db030b19bf6c3df05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopBooks_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopBooks/Default.cshtml")]
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
#line 2 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Core.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
using Library.Domain.Convertor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de15ce1a74f11a3a247e71db030b19bf6c3df05f", @"/Views/Shared/Components/TopBooks/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da7d76abb7e102d32e6b1f22d7c24e8ae5089a43", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopBooks_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Domain.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section class=\"last-news-side border-radius\">\n    <header><i class=\"icons icon-star\"></i> <h3> پربازدیدترین کتاب ها </h3></header>\n    <ul>\n");
#nullable restore
#line 7 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de15ce1a74f11a3a247e71db030b19bf6c3df05f4854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 359, "~/contents/BookImages/", 359, 22, true);
#nullable restore
#line 11 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
AddHtmlAttributeValue("", 381, item.ImageName, 381, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h2> <a");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 452, 2);
            WriteAttributeValue("", 433, "/Books/", 433, 7, true);
#nullable restore
#line 12 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
WriteAttributeValue("", 440, item.BookID, 440, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
                                                  Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                    <span>");
#nullable restore
#line 13 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
                     Write(item.PublishYear.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </li>\n");
#nullable restore
#line 15 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\Shared\Components\TopBooks\Default.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Domain.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
