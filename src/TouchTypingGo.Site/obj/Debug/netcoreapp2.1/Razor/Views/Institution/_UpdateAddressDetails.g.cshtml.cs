#pragma checksum "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf5d6974ac0e13f73e344d77b4516ffa29de061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institution__UpdateAddressDetails), @"mvc.1.0.view", @"/Views/Institution/_UpdateAddressDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Institution/_UpdateAddressDetails.cshtml", typeof(AspNetCore.Views_Institution__UpdateAddressDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf5d6974ac0e13f73e344d77b4516ffa29de061", @"/Views/Institution/_UpdateAddressDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a915e5db813a230f8f0181c09b9288da8f576a60", @"/Views/_ViewImports.cshtml")]
    public class Views_Institution__UpdateAddressDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TouchTypingGo.Application.ViewModels.InstitutionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Model.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 130, true);
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"page-header\">\r\n        <strong>Endereço da Instituição</strong>\r\n    </div>\r\n");
            EndContext();
#line 7 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
     if (Model.Address != null)
    {

#line default
#line hidden
            BeginContext(236, 103, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(340, 50, false);
#line 12 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address.County));

#line default
#line hidden
            EndContext();
            BeginContext(390, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(458, 48, false);
#line 15 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address.City));

#line default
#line hidden
            EndContext();
            BeginContext(506, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(574, 50, false);
#line 18 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address.Street));

#line default
#line hidden
            EndContext();
            BeginContext(624, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(692, 50, false);
#line 21 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address.Number));

#line default
#line hidden
            EndContext();
            BeginContext(742, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(810, 51, false);
#line 24 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(861, 131, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(993, 46, false);
#line 30 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address.County));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1107, 44, false);
#line 33 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address.City));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1219, 46, false);
#line 36 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1333, 46, false);
#line 39 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1447, 47, false);
#line 42 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 98, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1592, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1568e7c9ad4e44ffab902b219f18485b", async() => {
                BeginContext(1681, 95, true);
                WriteLiteral("\r\n                            <span title=\"Edit\"></span> Edit Address\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-model", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1780, 115, true);
            WriteLiteral("\r\n                       \r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 54 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1919, 91, true);
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2010, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee7748f5053e486680c2d57ddb1edf5a", async() => {
                BeginContext(2100, 93, true);
                WriteLiteral("\r\n                        <span title=\"Add Address\"></span> Add Address\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
                                                 WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-model", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2197, 62, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 66 "C:\Users\marco\Source\Repos\TouchTypingGo2\src\TouchTypingGo.Site\Views\Institution\_UpdateAddressDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(2266, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TouchTypingGo.Application.ViewModels.InstitutionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
