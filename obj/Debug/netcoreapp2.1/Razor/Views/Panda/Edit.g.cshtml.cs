#pragma checksum "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0ddf1e4e2092ea0769b4664ac3da788d00afb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panda_Edit), @"mvc.1.0.view", @"/Views/Panda/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Panda/Edit.cshtml", typeof(AspNetCore.Views_Panda_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0ddf1e4e2092ea0769b4664ac3da788d00afb4", @"/Views/Panda/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c21edf80b54368c49ff2a1c764d407bc883ba7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Panda_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Panda>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 34, true);
            WriteLiteral("<a href=\"/\">Home</a>\r\n<br><br>\r\n\r\n");
            EndContext();
            BeginContext(48, 949, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921d20495042413ea359401bce9b2486", async() => {
                BeginContext(101, 70, true);
                WriteLiteral("\r\n    <h5>Type</h5><input type=\"text\" name=\"Type\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 171, "\"", 190, 1);
#line 6 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
WriteAttributeValue("", 179, Model.Type, 179, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(191, 81, true);
                WriteLiteral(" />\r\n    <h5>Location</h5><input type=\"text\" name=\"Location\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 272, "\"", 295, 1);
#line 7 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
WriteAttributeValue("", 280, Model.Location, 280, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(296, 70, true);
                WriteLiteral(" />\r\n    <h5>Cuteness</h5><select class=\"form-control\" name=\"Cuteness\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 366, "\"", 389, 1);
#line 8 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
WriteAttributeValue("", 374, Model.Cuteness, 374, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(390, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 9 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
             for(int i=1; i<6; i++)
        {
            if(Model.Cuteness == i)
            {

#line default
#line hidden
                BeginContext(493, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(509, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7405eba15e48e8802874f2485b19ea", async() => {
                    BeginContext(538, 1, false);
#line 13 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
                                       Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(548, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 14 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(598, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(614, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c5becfb69714091a8703413cc570498", async() => {
                    BeginContext(623, 1, false);
#line 17 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
                   Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(633, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(661, 100, true);
                WriteLiteral("    </select > \r\n    <h5>Weight</h5><input type=\"number\" name=\"Weight\" class=\"form-control\" min=\"10\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 761, "\"", 782, 1);
#line 21 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
WriteAttributeValue("", 769, Model.Weight, 769, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(783, 106, true);
                WriteLiteral(" />\r\n    <h5>Description</h5><textarea name =\"Description\" placeholder=\"Description\" class=\"form-control\">");
                EndContext();
                BeginContext(890, 17, false);
#line 22 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
                                                                                                Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(907, 83, true);
                WriteLiteral("</textarea>\r\n    <input type=\"submit\" value = \"Update\" class=\"btn btn-success\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 63, "/update/", 63, 8, true);
#line 5 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
AddHtmlAttributeValue("", 71, Model.PandaId, 71, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(997, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(999, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29f9f9ba708a48a4aea50e8aa67fca12", async() => {
                BeginContext(1051, 71, true);
                WriteLiteral("\r\n    <input type=\"submit\" value = \"Delete\" class=\"btn btn-danger\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1013, "/delete/", 1013, 8, true);
#line 25 "C:\Users\maris\Desktop\C#\projects\Pandas\Views\Panda\Edit.cshtml"
AddHtmlAttributeValue("", 1021, Model.PandaId, 1021, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1129, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Panda> Html { get; private set; }
    }
}
#pragma warning restore 1591