#pragma checksum "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e15097fe612c20e35f63d724c937333f6c2c07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Managers_Index), @"mvc.1.0.view", @"/Views/Managers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Managers/Index.cshtml", typeof(AspNetCore.Views_Managers_Index))]
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
#line 5 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
using Kanban.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e15097fe612c20e35f63d724c937333f6c2c07", @"/Views/Managers/Index.cshtml")]
    public class Views_Managers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kanban.Models.Manager>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 70, true);
            WriteLiteral("\r\n<div class=\"managerIndex\">\r\n  <h1><strong>Managers</strong></h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
   if (Model.Any())
  {
    

#line default
#line hidden
#line 13 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
     foreach (Manager manager in Model)
    {

#line default
#line hidden
            BeginContext(243, 9, true);
            WriteLiteral("      <p>");
            EndContext();
            BeginContext(253, 75, false);
#line 15 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
    Write(Html.ActionLink($"{manager.Name}", "Details", new { id =manager.ManagerId}));

#line default
#line hidden
            EndContext();
            BeginContext(328, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
    }

#line default
#line hidden
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
     
  }
  else
  {

#line default
#line hidden
            BeginContext(359, 51, true);
            WriteLiteral("    <h3>Managers are not in data yet.</h3>\r\n    <p>");
            EndContext();
            BeginContext(411, 44, false);
#line 21 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
  Write(Html.ActionLink("Add new manager", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(455, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Managers\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(466, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kanban.Models.Manager>> Html { get; private set; }
    }
}
#pragma warning restore 1591
