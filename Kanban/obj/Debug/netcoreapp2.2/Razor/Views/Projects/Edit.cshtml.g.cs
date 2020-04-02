#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa250239280327fac8a701825ad8fc670391c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Edit.cshtml", typeof(AspNetCore.Views_Projects_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa250239280327fac8a701825ad8fc670391c74", @"/Views/Projects/Edit.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 80, true);
            WriteLiteral("\r\n<div class=\"projectEdit\">\r\n\r\n  <h1><strong>Edit this project</strong></h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
            BeginContext(181, 40, false);
#line 13 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.HiddenFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(230, 26, false);
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Project Name"));

#line default
#line hidden
            EndContext();
            BeginContext(263, 112, false);
#line 16 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.EditorFor(model => model.ProjectName, new { htmlAttributes = new { @type="text", @class="form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(384, 25, false);
#line 18 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
            EndContext();
            BeginContext(416, 84, false);
#line 19 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.TextAreaFor(model => model.Content, new { @type="text", @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(509, 27, false);
#line 21 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Kick Off Date"));

#line default
#line hidden
            EndContext();
            BeginContext(543, 93, false);
#line 22 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.TextBoxFor(model => model.KickOffDate, "{0:MM-dd-yyyy}", new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(645, 22, false);
#line 24 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Due Date"));

#line default
#line hidden
            EndContext();
            BeginContext(674, 89, false);
#line 25 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.TextBoxFor(model => model.DueDate, "{0:MM-dd-yyyy}", new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(776, 37, false);
#line 27 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Is this Project Active?"));

#line default
#line hidden
            EndContext();
            BeginContext(820, 116, false);
#line 28 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.CheckBoxFor(model => model.ActiveStatus, new { htmlAttributes = new { @value=true, @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(938, 92, true);
            WriteLiteral("    <br>\r\n    <input type=\"submit\" value=\"Save\" class=\"w3-button w3-green w3-round-large\">\r\n");
            EndContext();
#line 31 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
  }

#line default
#line hidden
            BeginContext(1035, 7, true);
            WriteLiteral("\r\n  <p>");
            EndContext();
            BeginContext(1043, 48, false);
#line 33 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.ActionLink("Back to project list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
