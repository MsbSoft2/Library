#pragma checksum "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d2e41eded1ffaaf8b06317eb070d4b32fbf6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowBooks_ShowBooks), @"mvc.1.0.view", @"/Views/ShowBooks/ShowBooks.cshtml")]
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
#line 2 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
using Library.Domain.Convertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d2e41eded1ffaaf8b06317eb070d4b32fbf6de", @"/Views/ShowBooks/ShowBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da7d76abb7e102d32e6b1f22d7c24e8ae5089a43", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowBooks_ShowBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Domain.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius col-md-5 col-sm-5 col-xs-5 pull-left rounded rounded-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RentBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
   ViewData["Title"] = Model.BookName + ViewData["GroupName"].ToString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 col-sm-12 col-xs-12 pull-left"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">خانه </a></li>
        <li class=""breadcrumb-item""><a href=""#"">کتاب </a></li>
        <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 10 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                           Write(ViewData["GroupName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 11 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                      Write(Model.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n    </ul>\n\n    <section class=\"single-news border-radius col-md-12 col-sm-12 col-xs-12\">\n        <header><h2> ");
#nullable restore
#line 15 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                Write(Model.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2> <span> <i class=\"fa fa-calendar\"></i>  انتشار : ");
#nullable restore
#line 15 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                                                                      Write(Model.PublishYear.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></header>\n        <article class=\"col-md-12 col-sm-12 col-xs-12\">\n            <ul>\n                <li>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60d2e41eded1ffaaf8b06317eb070d4b32fbf6de7860", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 966, "~/contents/BookImages/", 966, 22, true);
#nullable restore
#line 19 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
AddHtmlAttributeValue("", 988, Model.ImageName, 988, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
AddHtmlAttributeValue("", 1011, Model.BookName, 1011, 15, false);

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
            WriteLiteral("\n                    <br />\n                    <p>\n                        توضیح مختصر: ");
#nullable restore
#line 22 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p>\n                        نویسنده: ");
#nullable restore
#line 25 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p>\n                        انتشارات: ");
#nullable restore
#line 28 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                             Write(Model.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p>\n                        قیمت اجاره(ریال): ");
#nullable restore
#line 31 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p>\n                        دسته بندی: ");
#nullable restore
#line 34 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                              Write(ViewData["GroupName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                </li>\n");
#nullable restore
#line 37 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"alert alert-info col-md-6 mt-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60d2e41eded1ffaaf8b06317eb070d4b32fbf6de12265", async() => {
                WriteLiteral("\n            ");
#nullable restore
#line 41 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 1886, "\"", 1941, 1);
#nullable restore
#line 42 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
WriteAttributeValue("", 1894, User.FindFirstValue(ClaimTypes.NameIdentifier), 1894, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1992, "\"", 2013, 1);
#nullable restore
#line 43 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
WriteAttributeValue("", 2000, Model.BookID, 2000, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <p>چه تعداد روز می خواهید اجاره کنید؟</p>\n            <input class=\"form-control\" type=\"number\" name=\"countDay\"");
                BeginWriteAttribute("value", " value=\"", 2141, "\"", 2149, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\n            <br />\n            <input class=\"btn btn-primary btn-block px-5\" type=\"submit\" value=\"اجاره کتاب\" />\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </li>\n");
#nullable restore
#line 50 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"alert alert-warning col-md-5 mt-3\">\n        <p>\n            برای اجاره ابتدا باید وارد سایت شوید !\n        </p>\n        <p>\n            <a class=\"btn btn-warning btn-block\" href=\"/login\">ورود به سایت</a>\n        </p>\n    </li>\n");
#nullable restore
#line 61 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </article>\n    </section>\n\n\n");
            WriteLiteral("\n\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Domain.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
