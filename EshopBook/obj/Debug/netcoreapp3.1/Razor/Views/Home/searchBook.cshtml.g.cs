#pragma checksum "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3758e0fd46e42cbfa76fa1cf3645d446a74d42ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_searchBook), @"mvc.1.0.view", @"/Views/Home/searchBook.cshtml")]
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
#line 1 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\_ViewImports.cshtml"
using EshopBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\_ViewImports.cshtml"
using EshopBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3758e0fd46e42cbfa76fa1cf3645d446a74d42ad", @"/Views/Home/searchBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5c3608f6627d2289b7995b37218d03e4e3894b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_searchBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EshopBook.Models.Books>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
  
    ViewData["Title"] = "کتاب ها";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3758e0fd46e42cbfa76fa1cf3645d446a74d42ad4600", async() => {
                WriteLiteral("کتاب فروشی آنلاین");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
        <ul class=""nav navbar-nav ml-auto"">
            <li class=""nav-item"">
                <h4 class=""text-dark""><b>جست و جوی کتاب</b></h4>
            </li>
        </ul>
    </div>
</nav>

<div class=""text-center"">
    <div class=""card"">
");
#nullable restore
#line 20 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-header bg-dark text-white\">\r\n                <h4>");
#nullable restore
#line 23 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
               Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h6><b>نویسنده: </b> ");
#nullable restore
#line 26 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
                                Write(item.BookAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <hr />\r\n                <h6><b>شابک: </b> ");
#nullable restore
#line 28 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
                             Write(item.BookShabak);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <hr />\r\n                <h6><b>تاریخ انتشار: </b> ");
#nullable restore
#line 30 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
                                     Write(item.BookRelease.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <hr />\r\n                <h6><b>قیمت: </b> ");
#nullable restore
#line 32 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
                             Write(item.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</h6>\r\n            </div>\r\n");
#nullable restore
#line 34 "F:\ProjectASP\Core\EshopBook\EshopBook\Views\Home\searchBook.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EshopBook.Models.Books>> Html { get; private set; }
    }
}
#pragma warning restore 1591
