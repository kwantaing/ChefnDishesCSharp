#pragma checksum "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f6ec4144d6d3a285fd8003ba5e64c9bed535d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/_ViewImports.cshtml"
using ChefnDishes;

#line default
#line hidden
#line 2 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/_ViewImports.cshtml"
using ChefnDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6ec4144d6d3a285fd8003ba5e64c9bed535d36", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21cf01aeb7208c160eb4e672a0ce0ffe3aa148dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("<div>\n");
            EndContext();
            BeginContext(22, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(30, 16, false);
#line 3 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Detail.cshtml"
  Write(Model.first_name);

#line default
#line hidden
            EndContext();
            BeginContext(46, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(48, 15, false);
#line 3 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Detail.cshtml"
                    Write(Model.last_name);

#line default
#line hidden
            EndContext();
            BeginContext(63, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(76, 9, false);
#line 4 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Detail.cshtml"
  Write(Model.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(85, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(98, 12, false);
#line 5 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Detail.cshtml"
  Write(Model.Dishes);

#line default
#line hidden
            EndContext();
            BeginContext(110, 11, true);
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591
