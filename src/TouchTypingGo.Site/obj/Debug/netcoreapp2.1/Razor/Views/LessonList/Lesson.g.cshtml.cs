#pragma checksum "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6896666c6a0aacc9a16cef96d7837c3b14b648"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LessonList_Lesson), @"mvc.1.0.view", @"/Views/LessonList/Lesson.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LessonList/Lesson.cshtml", typeof(AspNetCore.Views_LessonList_Lesson))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6896666c6a0aacc9a16cef96d7837c3b14b648", @"/Views/LessonList/Lesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a915e5db813a230f8f0181c09b9288da8f576a60", @"/Views/_ViewImports.cshtml")]
    public class Views_LessonList_Lesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TouchTypingGo.Application.ViewModels.AppViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
  
    ViewData["Title"] = "Lesson";

#line default
#line hidden
            BeginContext(102, 135, true);
            WriteLiteral("\r\n<h2>Lesson</h2>\r\n\r\n<div>\r\n    <h4>PreviewLessonViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 38, false);
#line 14 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(320, 34, false);
#line 17 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 40, false);
#line 20 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(438, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(482, 36, false);
#line 23 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(562, 40, false);
#line 26 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 36, false);
#line 29 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(682, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(726, 43, false);
#line 32 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.MinTime));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 39, false);
#line 35 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.MinTime));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 45, false);
#line 38 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.MinErrors));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(985, 41, false);
#line 41 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.MinErrors));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1070, 44, false);
#line 44 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1158, 40, false);
#line 47 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1242, 43, false);
#line 50 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayNameFor(model => model.Started));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1329, 39, false);
#line 53 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
       Write(Html.DisplayFor(model => model.Started));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1416, 68, false);
#line 58 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\LessonList\Lesson.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1492, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77269ad44d64cf6a3004a0feb2b2921", async() => {
                BeginContext(1514, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1530, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TouchTypingGo.Application.ViewModels.AppViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
