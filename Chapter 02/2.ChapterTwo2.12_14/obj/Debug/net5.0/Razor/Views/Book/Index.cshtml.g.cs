#pragma checksum "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2521368f067302a11cce9d88d1fc198a5d56e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\_ViewImports.cshtml"
using _2.ChapterTwo2._12_14;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\_ViewImports.cshtml"
using _2.ChapterTwo2._12_14.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2521368f067302a11cce9d88d1fc198a5d56e7e", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98d2e32628ab373d60a2c4328993624a6517701", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_2.ChapterTwo2._12_14.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Book";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Book</h1>\r\n<br />\r\n<b>Book Id: </b> ");
#nullable restore
#line 8 "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\Book\Index.cshtml"
            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Book Title:</b> ");
#nullable restore
#line 10 "C:\Users\Alexandre Malavasi\source\repos\BPBDesignPatternWithCSharpAndDotNetCore\2.ChapterTwo2.12_14\Views\Book\Index.cshtml"
              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_2.ChapterTwo2._12_14.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591