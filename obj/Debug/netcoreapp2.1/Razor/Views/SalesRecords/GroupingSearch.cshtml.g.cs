#pragma checksum "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c92357d29b4a3553ef17f3752f96e91f1c1a3f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c92357d29b4a3553ef17f3752f96e91f1c1a3f2f", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(251, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(258, 17, false);
#line 9 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(275, 85, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar bg-primary\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(360, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c92357d29b4a3553ef17f3752f96e91f1c1a3f2f5083", async() => {
                BeginContext(412, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 627, "", 654, 1);
#line 17 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 634, ViewData["minDate"], 634, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(654, 202, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 856, "", 883, 1);
#line 21 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 863, ViewData["maxDate"], 863, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(883, 130, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1020, 22, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n");
            EndContext();
#line 29 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1132, 123, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1256, 24, false);
#line 33 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1297, 63, false);
#line 33 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                   Write(departmentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 650, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Data
                        </th>
                        <th>
                            Valor
                        </th>
                        <th>
                            Vendedor
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 55 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
            BeginContext(2170, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2267, 39, false);
#line 59 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2410, 41, false);
#line 62 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2555, 46, false);
#line 65 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2705, 41, false);
#line 68 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2746, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 71 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                    }

#line default
#line hidden
            BeginContext(2837, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 76 "D:\Thieres\Documents\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
