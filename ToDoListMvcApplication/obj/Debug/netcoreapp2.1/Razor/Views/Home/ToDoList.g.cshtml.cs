#pragma checksum "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7640c421817ade9482a3bbceb90f6c53f31512b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ToDoList), @"mvc.1.0.view", @"/Views/Home/ToDoList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ToDoList.cshtml", typeof(AspNetCore.Views_Home_ToDoList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7640c421817ade9482a3bbceb90f6c53f31512b1", @"/Views/Home/ToDoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f00bc0866ef9c9493d59c63c539f3b92fba2db05", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ToDoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoListMvcApplication.Models.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
  
    ViewData["Title"] = "ToDoList";

#line default
#line hidden
            BeginContext(98, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(134, 23, false);
#line 8 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
Write(ViewBag.UserInformation);

#line default
#line hidden
            EndContext();
            BeginContext(157, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
            BeginContext(167, 68, false);
#line 10 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
Write(Html.ActionLink("Add", "Add", "Todo", new { userId = Model.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(235, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(322, 38, false);
#line 15 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
           Write(Html.HiddenFor(Model => Model.ToDo.Id));

#line default
#line hidden
            EndContext();
            BeginContext(360, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(416, 52, false);
#line 18 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
           Write(Html.DisplayNameFor(Model => Model.ToDo.IsCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(468, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(524, 46, false);
#line 21 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
           Write(Html.DisplayNameFor(Model => Model.ToDo.Title));

#line default
#line hidden
            EndContext();
            BeginContext(570, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(626, 56, false);
#line 24 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
           Write(Html.DisplayNameFor(Model => Model.ToDo.DateTimeCreated));

#line default
#line hidden
            EndContext();
            BeginContext(682, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(738, 58, false);
#line 27 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
           Write(Html.DisplayNameFor(Model => Model.ToDo.DateTimeCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(796, 125, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
         foreach (var item in Model.ToDos)
        {

#line default
#line hidden
            BeginContext(976, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1037, 36, false);
#line 39 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1096, 40, false);
#line 40 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.HiddenFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1204, 46, false);
#line 43 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1318, 40, false);
#line 46 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1426, 50, false);
#line 49 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateTimeCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1544, 52, false);
#line 52 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateTimeCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1664, 177, false);
#line 55 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.ActionLink("Update/View", "Update", "ToDo", new {  Id = item.Id, UserId = item.UserId, Title = item.Title, Description = item.Description, IsCompleted = item.IsCompleted }));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1866, 87, false);
#line 56 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "ToDo", new { Id = item.Id, UserId = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\PengG\Documents\Visual Studio 2017\Projects\ToDoListMvcApplication\ToDoListMvcApplication\Views\Home\ToDoList.cshtml"
        }

#line default
#line hidden
            BeginContext(2008, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2034, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ee35168b3d4501b0a643e6a7646694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2085, 231, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'a:contains(\"Delete\")\').click(function (e) {\r\n            e.preventDefault;\r\n\r\n            confirm(\"Are you sure to delete the task?\");\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoListMvcApplication.Models.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591