#pragma checksum "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f690a5c2d181f622a3c68b32c85c0685fecd8830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LessonResult_Index), @"mvc.1.0.view", @"/Views/LessonResult/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LessonResult/Index.cshtml", typeof(AspNetCore.Views_LessonResult_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 6 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using TouchTypingGo.Site;

#line default
#line hidden
#line 3 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using TouchTypingGo.Infra.CrossCutting.Identity.Models;

#line default
#line hidden
#line 4 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using TouchTypingGo.Infra.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using TouchTypingGo.Infra.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
#line 7 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 10 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 11 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 13 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 14 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\_ViewImports.cshtml"
using TouchTypingGo.Site.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f690a5c2d181f622a3c68b32c85c0685fecd8830", @"/Views/LessonResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a915e5db813a230f8f0181c09b9288da8f576a60", @"/Views/_ViewImports.cshtml")]
    public class Views_LessonResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TouchTypingGo.Application.ViewModels.LessonResultViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(123, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(152, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a9b4ef991de46e6918331455ff49e16", async() => {
                BeginContext(175, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 100, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(290, 39, false);
#line 16 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Try));

#line default
#line hidden
            EndContext();
            BeginContext(329, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(397, 39, false);
#line 19 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Wpm));

#line default
#line hidden
            EndContext();
            BeginContext(436, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(504, 40, false);
#line 22 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
            EndContext();
            BeginContext(544, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(612, 42, false);
#line 25 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Errors));

#line default
#line hidden
            EndContext();
            BeginContext(654, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(722, 51, false);
#line 28 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EhAuthenticated));

#line default
#line hidden
            EndContext();
            BeginContext(773, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(841, 44, false);
#line 31 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ErrorKey));

#line default
#line hidden
            EndContext();
            BeginContext(885, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(953, 42, false);
#line 34 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(995, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1063, 56, false);
#line 37 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LessonPresentationId));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 90, true);
            WriteLiteral("\r\n                </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1241, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1290, 38, false);
#line 46 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Try));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 38, false);
#line 49 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wpm));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1478, 39, false);
#line 52 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1573, 41, false);
#line 55 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Errors));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1670, 50, false);
#line 58 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EhAuthenticated));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1776, 43, false);
#line 61 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ErrorKey));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1877, 41, false);
#line 65 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1974, 55, false);
#line 68 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LessonPresentationId));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2085, 65, false);
#line 71 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2171, 71, false);
#line 72 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2263, 69, false);
#line 73 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonResult\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2371, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<BaseController> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TouchTypingGo.Application.ViewModels.LessonResultViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
