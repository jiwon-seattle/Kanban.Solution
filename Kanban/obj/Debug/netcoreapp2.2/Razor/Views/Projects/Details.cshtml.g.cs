#pragma checksum "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7631d7795a402cae57b9e404a260f136bc3e8481"
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
#line 5 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
using Kanban.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7631d7795a402cae57b9e404a260f136bc3e8481", @"/Views/Projects/Details.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 109, true);
            WriteLiteral("\r\n<div class=\"projectDetails\">\r\n  <h1><strong>Project Details</strong></h1>\r\n  \r\n  <hr>\r\n  <h3>About Project ");
            EndContext();
            BeginContext(196, 43, false);
#line 12 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(239, 26, true);
            WriteLiteral("</h3>\r\n  <p>Project Name: ");
            EndContext();
            BeginContext(266, 17, false);
#line 13 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
              Write(Model.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(283, 24, true);
            WriteLiteral("</p>\r\n  <p>Description: ");
            EndContext();
            BeginContext(308, 13, false);
#line 14 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
             Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(321, 26, true);
            WriteLiteral("</p>\r\n  <p>Kikc Off Date: ");
            EndContext();
            BeginContext(348, 23, false);
#line 15 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
               Write(Model.KickOffDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(371, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(373, 21, false);
#line 15 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                        Write(Model.KickOffDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(394, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(396, 22, false);
#line 15 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                               Write(Model.KickOffDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(418, 21, true);
            WriteLiteral("</p>\r\n  <p>Due Date: ");
            EndContext();
            BeginContext(440, 19, false);
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
          Write(Model.DueDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(459, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(461, 17, false);
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                               Write(Model.DueDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(478, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(480, 18, false);
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                  Write(Model.DueDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(498, 30, true);
            WriteLiteral("</p>\r\n  <p>Project Active : \r\n");
            EndContext();
#line 18 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     if (@Model.ActiveStatus == true)
    {

#line default
#line hidden
            BeginContext(574, 40, true);
            WriteLiteral("      <span class=\"checkmark\">✔</span>\r\n");
            EndContext();
#line 21 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }
    else 
    {

#line default
#line hidden
            BeginContext(639, 40, true);
            WriteLiteral("      <span class=\"wrongmark\">✘</span>\r\n");
            EndContext();
#line 25 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(686, 20, true);
            WriteLiteral("  </p>\r\n  <hr>\r\n  \r\n");
            EndContext();
#line 29 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
   if(@Model.ToDoLists.Count == 0)
  {

#line default
#line hidden
            BeginContext(747, 47, true);
            WriteLiteral("    <h3>There are no To Do assigned yet.</h3>\r\n");
            EndContext();
            BeginContext(799, 51, false);
#line 32 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Add Tasks", "Create", "ToDoLists"));

#line default
#line hidden
            EndContext();
#line 32 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                        
  }
  else
  {

#line default
#line hidden
            BeginContext(870, 27, true);
            WriteLiteral("    <h2>Work Items: </h2>\r\n");
            EndContext();
#line 37 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     foreach(ToDoList todoList in Model.ToDoLists)
    {

#line default
#line hidden
            BeginContext(956, 10, true);
            WriteLiteral("      <h3>");
            EndContext();
            BeginContext(967, 111, false);
#line 39 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     Write(Html.ActionLink(@todoList.Name, "Details", "ToDoLists", new { @class = "linkStyle", id = todoList.ToDoListId }));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 40 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1097, 51, false);
#line 41 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Add Tasks", "Create", "ToDoLists"));

#line default
#line hidden
            EndContext();
#line 41 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                        
  }

#line default
#line hidden
            BeginContext(1155, 8, true);
            WriteLiteral("  <hr>\r\n");
            EndContext();
#line 44 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
   if(Model.Managers.Count == 0)
  {

#line default
#line hidden
            BeginContext(1202, 63, true);
            WriteLiteral("    <h3>There are no peole assinged on this product yet.</h3>\r\n");
            EndContext();
            BeginContext(1270, 93, false);
#line 47 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Assign people to this project", "AssignPeople", new { id = Model.ProjectId}));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                                                                  
  }
  else
  {

#line default
#line hidden
            BeginContext(1383, 26, true);
            WriteLiteral("    <h2>Team Crews:</h2>\r\n");
            EndContext();
#line 52 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     foreach(var join in Model.Managers)
    {

#line default
#line hidden
            BeginContext(1458, 10, true);
            WriteLiteral("      <h3>");
            EndContext();
            BeginContext(1469, 118, false);
#line 54 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
     Write(Html.ActionLink(@join.Manager.Name, "Details", "Managers", new { @class = "linkStyle", id = @join.Manager.ManagerId }));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 55 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1606, 93, false);
#line 56 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Assign people to this project", "AssignPeople", new { id = Model.ProjectId}));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
                                                                                                  
  }

#line default
#line hidden
            BeginContext(1706, 21, true);
            WriteLiteral("  \r\n  <hr>\r\n  \r\n  <p>");
            EndContext();
            BeginContext(1728, 69, false);
#line 61 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Edit Product", "Edit", new { id = Model.ProjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(1809, 73, false);
#line 62 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Details.cshtml"
Write(Html.ActionLink("Delete Product", "Delete", new { id = Model.ProjectId }));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 12, true);
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
