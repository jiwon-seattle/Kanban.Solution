#pragma checksum "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e9dfd0149122edbb8c41574a962f9381bd51d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
using Kanban.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e9dfd0149122edbb8c41574a962f9381bd51d8", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 40, true);
            WriteLiteral("\r\n<h2>Register a new user</h2>\r\n<hr />\r\n");
            EndContext();
#line 11 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(199, 33, false);
#line 13 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(239, 34, false);
#line 14 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(282, 35, false);
#line 16 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(324, 38, false);
#line 17 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(371, 42, false);
#line 19 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(420, 45, false);
#line 20 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(469, 46, true);
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\r\n");
            EndContext();
#line 23 "C:\Users\Jiwon Han\Desktop\coding\c#-project\Kanban.Solution\Kanban\Views\Account\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591