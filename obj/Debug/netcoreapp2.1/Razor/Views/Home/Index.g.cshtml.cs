#pragma checksum "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc0f2a1004beb2b6e707ac275501dc033950463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore;

#line default
#line hidden
#line 2 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore.Models;

#line default
#line hidden
#line 3 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc0f2a1004beb2b6e707ac275501dc033950463", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d89248ab5a2aa85b5137a91a264db578a1fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 35, false);
#line 3 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
            EndContext();
            BeginContext(61, 112, true);
            WriteLiteral("\r\n\r\n<h2>Preferred books of the week</h2>\r\n<h4>Customers\' preferences - Just for you!</h4>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\Home\Index.cshtml"
     foreach (var book in Model.PreferredBooks)
    {
        

#line default
#line hidden
            BeginContext(238, 38, false);
#line 11 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\Home\Index.cshtml"
   Write(Html.PartialAsync("BooksSummary",book));

#line default
#line hidden
            EndContext();
#line 11 "D:\Visual Studio Codes\Online Book Store\OnlineBookStore\Views\Home\Index.cshtml"
                                               
    }

#line default
#line hidden
            BeginContext(285, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
