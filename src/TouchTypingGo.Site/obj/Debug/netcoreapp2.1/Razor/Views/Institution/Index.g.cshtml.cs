#pragma checksum "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cc23044661bde326158bc79aae074b8ee7d452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institution_Index), @"mvc.1.0.view", @"/Views/Institution/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Institution/Index.cshtml", typeof(AspNetCore.Views_Institution_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cc23044661bde326158bc79aae074b8ee7d452", @"/Views/Institution/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a915e5db813a230f8f0181c09b9288da8f576a60", @"/Views/_ViewImports.cshtml")]
    public class Views_Institution_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TouchTypingGo.Application.ViewModels.InstitutionViewModel>>
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
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(122, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(151, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2d12999bb0445dab5b1f8401a6915c4", async() => {
                BeginContext(174, 10, true);
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
            BeginContext(188, 100, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(289, 40, false);
#line 16 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(329, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(397, 41, false);
#line 19 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(438, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(506, 41, false);
#line 22 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(547, 90, true);
            WriteLiteral("\r\n                </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(669, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(718, 39, false);
#line 31 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(813, 40, false);
#line 34 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(853, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(909, 40, false);
#line 37 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(949, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1005, 89, false);
#line 40 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 79, true);
            WriteLiteral(" |\r\n                <a href=\"#\" class=\"btn btn-default btnDetails\" data-value=\"");
            EndContext();
            BeginContext(1174, 7, false);
#line 41 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 33, true);
            WriteLiteral("\">Details</a> |\r\n                ");
            EndContext();
            BeginContext(1215, 88, false);
#line 42 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new {@class="btn btn-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1342, 380, true);
            WriteLiteral(@"    </tbody>
</table>


<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div id=""myModalContent""></div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TouchTypingGo.Application.ViewModels.InstitutionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
