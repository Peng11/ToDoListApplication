#pragma checksum "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be1794461257d3e0d7bfa72adc760dcaae481dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Add), @"mvc.1.0.view", @"/Views/Todo/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Add.cshtml", typeof(AspNetCore.Views_Todo_Add))]
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
#line 1 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\_ViewImports.cshtml"
using ToDoListMvcApplication;

#line default
#line hidden
#line 2 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\_ViewImports.cshtml"
using ToDoListMvcApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1794461257d3e0d7bfa72adc760dcaae481dc2", @"/Views/Todo/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f00bc0866ef9c9493d59c63c539f3b92fba2db05", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoListMvcApplication.Models.ToDoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
  
    ViewData["Title"] = "ToDo";

#line default
#line hidden
            BeginContext(94, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(101, 17, false);
#line 7 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(130, 23, false);
#line 8 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
Write(ViewBag.UserInformation);

#line default
#line hidden
            EndContext();
            BeginContext(153, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
 using (Html.BeginForm("Add", "ToDo", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(222, 31, true);
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(254, 37, false);
#line 14 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.HiddenFor(Model => Model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(291, 65, true);
            WriteLiteral("</td>\r\n        <td><br /></td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(357, 41, false);
#line 18 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(398, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(418, 36, false);
#line 19 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.EditorFor(Model => Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(454, 111, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><br /></td>\r\n        <td><br /></td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(566, 47, false);
#line 26 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(613, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(633, 42, false);
#line 27 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.EditorFor(Model => Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(675, 108, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"submit\" value=\"Save\" id=\"btnSave\" /></td>\r\n        <td>");
            EndContext();
            BeginContext(784, 76, false);
#line 31 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
       Write(Html.ActionLink("ToDoList", "Cancel", "Home", new { userId = Model.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 28, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            EndContext();
#line 34 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Todo\Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoListMvcApplication.Models.ToDoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
