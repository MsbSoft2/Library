#pragma checksum "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d876f9299a924f0f9e3706d95507e027f20c1439"
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
#line 2 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\_ViewImports.cshtml"
using Library.Core.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
using Library.Domain.Convertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d876f9299a924f0f9e3706d95507e027f20c1439", @"/Views/ShowBooks/ShowBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74ed94e53790b699e6863a6fc058b2fd54a399f", @"/Views/_ViewImports.cshtml")]
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
#line 4 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
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
#line 10 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                           Write(ViewData["GroupName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 11 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                      Write(Model.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    </ul>\r\n\r\n    <section class=\"single-news border-radius col-md-12 col-sm-12 col-xs-12\">\r\n        <header><h2> ");
#nullable restore
#line 15 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                Write(Model.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2> <span> <i class=\"fa fa-calendar\"></i>  انتشار : ");
#nullable restore
#line 15 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                                                                      Write(Model.PublishYear.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></header>\r\n        <article class=\"col-md-12 col-sm-12 col-xs-12\">\r\n            <ul>\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d876f9299a924f0f9e3706d95507e027f20c14397511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 984, "~/contents/BookImages/", 984, 22, true);
#nullable restore
#line 19 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
AddHtmlAttributeValue("", 1006, Model.ImageName, 1006, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
AddHtmlAttributeValue("", 1029, Model.BookName, 1029, 15, false);

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
            WriteLiteral("\r\n                    <br />\r\n                    <p>\r\n                        توضیح مختصر: ");
#nullable restore
#line 22 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        نویسنده: ");
#nullable restore
#line 25 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        انتشارات: ");
#nullable restore
#line 28 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                             Write(Model.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        قیمت اجاره(ریال): ");
#nullable restore
#line 31 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        دسته بندی: ");
#nullable restore
#line 34 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                              Write(ViewData["GroupName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </li>\r\n");
#nullable restore
#line 37 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"alert alert-info col-md-6 mt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d876f9299a924f0f9e3706d95507e027f20c143911710", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 1927, "\"", 1982, 1);
#nullable restore
#line 42 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
WriteAttributeValue("", 1935, User.FindFirstValue(ClaimTypes.NameIdentifier), 1935, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 2034, "\"", 2055, 1);
#nullable restore
#line 43 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
WriteAttributeValue("", 2042, Model.BookID, 2042, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <p>چه تعداد روز می خواهید اجاره کنید؟</p>\r\n            <input class=\"form-control\" type=\"number\" name=\"countDay\"");
                BeginWriteAttribute("value", " value=\"", 2185, "\"", 2193, 0);
                EndWriteAttribute();
                WriteLiteral(" required />\r\n            <br />\r\n            <input class=\"btn btn-primary btn-block px-5\" type=\"submit\" value=\"اجاره کتاب\" />\r\n        ");
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
            WriteLiteral("\r\n    </li>\r\n");
#nullable restore
#line 50 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"alert alert-warning col-md-5 mt-3\">\r\n        <p>\r\n            برای اجاره ابتدا باید وارد سایت شوید !\r\n        </p>\r\n        <p>\r\n            <a class=\"btn btn-warning btn-block\" href=\"/login\">ورود به سایت</a>\r\n        </p>\r\n    </li>\r\n");
#nullable restore
#line 61 "C:\Users\Mehrsa\Desktop\Library\Library\Library.Web\Views\ShowBooks\ShowBooks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </article>\r\n    </section>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n");
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
