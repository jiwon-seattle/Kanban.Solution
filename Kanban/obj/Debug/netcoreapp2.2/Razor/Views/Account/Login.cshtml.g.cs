#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029167f5a7853c830d98434c484d562ff6ceb8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
using Kanban.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029167f5a7853c830d98434c484d562ff6ceb8b8", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 45, true);
            WriteLiteral("\r\n<h2>Log in with your account</h2>\r\n\r\n<hr>\r\n");
            EndContext();
#line 12 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(162, 19, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
Write(Html.Label("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(186, 29, false);
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(222, 22, false);
#line 17 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
Write(Html.Label("Password"));

#line default
#line hidden
            EndContext();
            BeginContext(249, 33, false);
#line 18 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(286, 40, true);
            WriteLiteral("  <input type=\"submit\" value=\"Log in\">\r\n");
            EndContext();
#line 21 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
}

#line default
#line hidden
            BeginContext(329, 39, true);
            WriteLiteral("\r\n<p>Doesn\'t have an account? Register!");
            EndContext();
            BeginContext(369, 39, false);
#line 23 "C:\Users\Jiwon Han\desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Login.cshtml"
                                Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(408, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
