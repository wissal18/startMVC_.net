#pragma checksum "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf7b70535a1b7d98d3ed673c79d1da23237447d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Concert_Index), @"mvc.1.0.view", @"/Views/Concert/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Concert/Index.cshtml", typeof(AspNetCore.Views_Concert_Index))]
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
#line 1 "C:\Users\Walid\Downloads\TP3\TP3\Views\_ViewImports.cshtml"
using TP3;

#line default
#line hidden
#line 2 "C:\Users\Walid\Downloads\TP3\TP3\Views\_ViewImports.cshtml"
using TP3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf7b70535a1b7d98d3ed673c79d1da23237447d", @"/Views/Concert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805290efd515f623b80b9e3b7371ea4fe94a1859", @"/Views/_ViewImports.cshtml")]
    public class Views_Concert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TP3.Models.ConcertViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createEditConcertModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddConcert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            BeginContext(49, 200, true);
            WriteLiteral("<div class=\"top-buffer\"></div>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading panel-head\">Concerts</div>\r\n    <div class=\"panel-body\">\r\n        <div class=\"btn-group\">\r\n            ");
            EndContext();
            BeginContext(249, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf7b70535a1b7d98d3ed673c79d1da23237447d4458", async() => {
                BeginContext(328, 85, true);
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-plus\"></i>  Add Concert\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 393, true);
            WriteLiteral(@"
        </div>
        <div class=""top-buffer""></div>
        <table class=""table table-bordered table-striped table-condensed"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Date</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(875, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(930, 46, false);
#line 25 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ConcertName));

#line default
#line hidden
            EndContext();
            BeginContext(976, 36, true);
            WriteLiteral(" </td>\r\n                        <td>");
            EndContext();
            BeginContext(1013, 53, false);
#line 26 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ConcertDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1102, 39, false);
#line 27 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 137, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            \r\n                            <i class=\"glyphicon glyphicon-pencil\"></i>");
            EndContext();
            BeginContext(1279, 58, false);
#line 30 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                                                                 Write(Html.ActionLink("Edit", "Edit", new { id=item.ConcertId }));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 72, true);
            WriteLiteral(" |\r\n                            <i class=\"glyphicon glyphicon-book\"></i>");
            EndContext();
            BeginContext(1410, 64, false);
#line 31 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                                                               Write(Html.ActionLink("Details", "Details", new { id=item.ConcertId }));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 78, true);
            WriteLiteral(" |\r\n                            <i class=\"glyphicon glyphicon-minus-sign\"></i>");
            EndContext();
            BeginContext(1553, 62, false);
#line 32 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                                                                     Write(Html.ActionLink("Delete", "Delete", new { id=item.ConcertId }));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Walid\Downloads\TP3\TP3\Views\Concert\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1694, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TP3.Models.ConcertViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591