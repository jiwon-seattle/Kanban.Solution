#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#\Kanban.Solution\Kanban\Views\Shared\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf8ac483611dfb43e75f1d156fe6f0724b2a34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Header), @"mvc.1.0.view", @"/Views/Shared/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Header.cshtml", typeof(AspNetCore.Views_Shared_Header))]
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
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#\Kanban.Solution\Kanban\Views\_ViewImports.cshtml"
using Kanban;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf8ac483611dfb43e75f1d156fe6f0724b2a34f", @"/Views/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f7f928e61db042c3893e2f60280f9a262c5d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/kanbanheader.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30px; height: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 52, true);
            WriteLiteral("<div class=\"header\">\r\n\r\n  <div id=\"headerImg\">\r\n  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 52, "\'", 87, 1);
#line 4 "C:\Users\Jiwon Han\Desktop\Coding\c#\Kanban.Solution\Kanban\Views\Shared\Header.cshtml"
WriteAttributeValue("", 59, Url.Action("Index", "Home"), 59, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(88, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(89, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbf8ac483611dfb43e75f1d156fe6f0724b2a34f4264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 81, true);
            WriteLiteral("</a>\r\n  </div>\r\n  <p style=\"width: 100px; padding: 20px; border: 2px solid red;\">");
            EndContext();
            BeginContext(242, 48, false);
#line 6 "C:\Users\Jiwon Han\Desktop\Coding\c#\Kanban.Solution\Kanban\Views\Shared\Header.cshtml"
                                                            Write(Html.ActionLink("Projects", "Index", "Projects"));

#line default
#line hidden
            EndContext();
            BeginContext(290, 71, true);
            WriteLiteral("</p>\r\n  <p style=\"width: 100px; padding: 20px; border: 2px solid red;\">");
            EndContext();
            BeginContext(362, 46, false);
#line 7 "C:\Users\Jiwon Han\Desktop\Coding\c#\Kanban.Solution\Kanban\Views\Shared\Header.cshtml"
                                                            Write(Html.ActionLink("People", "Index", "Managers"));

#line default
#line hidden
            EndContext();
            BeginContext(408, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(803, 8, true);
            WriteLiteral("\r\n</div>");
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
