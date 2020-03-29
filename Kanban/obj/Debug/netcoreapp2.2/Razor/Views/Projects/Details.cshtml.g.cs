#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b5e487f7f9a3133b80224b1b16ff7b5122b7752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
#line 5 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
using Kanban.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5e487f7f9a3133b80224b1b16ff7b5122b7752", @"/Views/Projects/Details.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 85, true);
            WriteLiteral("\r\n<div class=\"projectDetails\">\r\n  <h1><strong>Project Details</strong></h1>\r\n\r\n  <h3>");
            EndContext();
            BeginContext(172, 45, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
 Write(Html.DisplayNameFor(model=>model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(217, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(220, 43, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(263, 17, true);
            WriteLiteral("</h3>\r\n\r\n  <hr>\r\n");
            EndContext();
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
   if(@Model.ToDoLists.Count == 0)
  {

#line default
#line hidden
            BeginContext(321, 47, true);
            WriteLiteral("    <h3>There are no To Do assigned yet.</h3>\r\n");
            EndContext();
#line 17 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
  }
  else
  {

#line default
#line hidden
            BeginContext(386, 23, true);
            WriteLiteral("    <h2>To-Dos: </h2>\r\n");
            EndContext();
#line 21 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     foreach(ToDoList todoList in Model.ToDoLists)
    {

#line default
#line hidden
            BeginContext(468, 10, true);
            WriteLiteral("      <h3>");
            EndContext();
            BeginContext(479, 13, false);
#line 23 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     Write(todoList.Name);

#line default
#line hidden
            EndContext();
            BeginContext(492, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 24 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
#line 24 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(511, 8, true);
            WriteLiteral("  <hr>\r\n");
            EndContext();
#line 27 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
   if(Model.Managers.Count == 0)
  {

#line default
#line hidden
            BeginContext(558, 63, true);
            WriteLiteral("    <h3>There are no peole assinged on this product yet.</h3>\r\n");
            EndContext();
#line 30 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
  }
  else
  {

#line default
#line hidden
            BeginContext(639, 54, true);
            WriteLiteral("    <h2>People who are working on this product:</h2>\r\n");
            EndContext();
#line 34 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     foreach(var join in Model.Managers)
    {

#line default
#line hidden
            BeginContext(742, 10, true);
            WriteLiteral("      <h3>");
            EndContext();
            BeginContext(753, 17, false);
#line 36 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     Write(join.Manager.Name);

#line default
#line hidden
            EndContext();
            BeginContext(770, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 37 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
#line 37 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(789, 9, true);
            WriteLiteral("  \r\n  <p>");
            EndContext();
            BeginContext(799, 48, false);
#line 40 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Back to product list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(847, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(859, 69, false);
#line 41 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Edit Product", "Edit", new { id = Model.ProjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(928, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(940, 73, false);
#line 42 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Delete Product", "Delete", new { id = Model.ProjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kanban.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
