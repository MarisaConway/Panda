#pragma checksum "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaeb3313b3ee3f5b334135b11382f7e5b85b86d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panda_Index), @"mvc.1.0.view", @"/Views/Panda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Panda/Index.cshtml", typeof(AspNetCore.Views_Panda_Index))]
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
#line 1 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\_ViewImports.cshtml"
using Pandas;

#line default
#line hidden
#line 2 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\_ViewImports.cshtml"
using Pandas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaeb3313b3ee3f5b334135b11382f7e5b85b86d6", @"/Views/Panda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c21edf80b54368c49ff2a1c764d407bc883ba7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Panda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 366, true);
            WriteLiteral(@"<div class =""jumbotron"">
    <h1>Welcome to Pandas!</h1>
</div>
<a href=""/new""><button class=""btn btn-info"">New Panda</button></a>
<table class=""table table-striped table-hover"">
    <tr>
        <th>Type</th>
        <th>Location</th>
        <th>Cuteness</th>
        <th>Weight</th>
        <th>Description</th>
        <th>Created At</th>
    </tr>
");
            EndContext();
#line 14 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
     foreach(var panda in ViewBag.Pandas)
    {

#line default
#line hidden
            BeginContext(416, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 448, "\"", 476, 2);
            WriteAttributeValue("", 455, "/panda/", 455, 7, true);
#line 17 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
WriteAttributeValue("", 462, panda.PandaId, 462, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(477, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(479, 10, false);
#line 17 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
                                           Write(panda.Type);

#line default
#line hidden
            EndContext();
            BeginContext(489, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(517, 14, false);
#line 18 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
           Write(panda.Location);

#line default
#line hidden
            EndContext();
            BeginContext(531, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(555, 14, false);
#line 19 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
           Write(panda.Cuteness);

#line default
#line hidden
            EndContext();
            BeginContext(569, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(593, 12, false);
#line 20 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
           Write(panda.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(605, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(629, 17, false);
#line 21 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
           Write(panda.Description);

#line default
#line hidden
            EndContext();
            BeginContext(646, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(670, 16, false);
#line 22 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
           Write(panda.Created_At);

#line default
#line hidden
            EndContext();
            BeginContext(686, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(715, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591