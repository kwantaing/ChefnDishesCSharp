#pragma checksum "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e58d8d776c6474de678a8fd1a64e9dd5ce5842"
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
#line 1 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/_ViewImports.cshtml"
using ChefnDishes;

#line default
#line hidden
#line 2 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/_ViewImports.cshtml"
using ChefnDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e58d8d776c6474de678a8fd1a64e9dd5ce5842", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21cf01aeb7208c160eb4e672a0ce0ffe3aa148dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 189, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            EndContext();
#line 10 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
 foreach(var chef in Model){

#line default
#line hidden
            BeginContext(285, 10, true);
            WriteLiteral("    <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 295, "\"", 322, 2);
            WriteAttributeValue("", 302, "/chefs/", 302, 7, true);
#line 11 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
WriteAttributeValue("", 309, chef.user_id, 309, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(325, 15, false);
#line 11 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
                                  Write(chef.first_name);

#line default
#line hidden
            EndContext();
            BeginContext(340, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(342, 14, false);
#line 11 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
                                                   Write(chef.last_name);

#line default
#line hidden
            EndContext();
            BeginContext(356, 11, true);
            WriteLiteral("</a></h1>\r\n");
            EndContext();
#line 12 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/ChefnDishes/Views/Home/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
