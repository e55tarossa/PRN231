#pragma checksum "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fe43b4c2fee8df4693527096623fcf7ccb9a2a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prediction_HistoryFarmer), @"mvc.1.0.view", @"/Views/Prediction/HistoryFarmer.cshtml")]
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
#nullable restore
#line 1 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\_ViewImports.cshtml"
using WebApplicationClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\_ViewImports.cshtml"
using WebApplicationClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fe43b4c2fee8df4693527096623fcf7ccb9a2a0", @"/Views/Prediction/HistoryFarmer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0102d1ddfaf2ed240c70f7ce09a6435cd8f20b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Prediction_HistoryFarmer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplicationClient.Models.Prediction>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/symptom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
  
    var index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fe43b4c2fee8df4693527096623fcf7ccb9a2a05239", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"/DataTables/datatables.css\">\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 275, "\"", 283, 0);
            EndWriteAttribute();
            WriteLiteral(@">
 
    <div class=""row py-2"">
        <div class=""col-12"">
            <table id=""example"" class=""table table-hover responsive nowrap"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Disease Result</th>
                        <th>Input Image</th>
                        <th>Created At</th>
");
            WriteLiteral("                        <th>Expert Confirmation</th>\r\n                        <th>Status</th>\r\n                        <th>Percent</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe43b4c2fee8df4693527096623fcf7ccb9a2a07694", async() => {
                WriteLiteral("\r\n                                        <div class=\"d-flex align-items-center\">\r\n                                            <div class=\"avatar avatar-blue mr-3\">");
#nullable restore
#line 35 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                                                            Write(index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div");
                BeginWriteAttribute("class", " class=\"", 1394, "\"", 1402, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <p class=\"font-weight-bold mb-0\">");
#nullable restore
#line 37 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.PredictResult));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                    \r\n                                <td>\r\n                                <img class=\"rounded-circle\" id=\"image\"");
            BeginWriteAttribute("src", " src=\"", 1869, "\"", 1895, 1);
#nullable restore
#line 44 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
WriteAttributeValue("", 1875, item.InputImagePath, 1875, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"120\">\r\n                                </td>  \r\n                                <td>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n");
#nullable restore
#line 56 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                     if (string.IsNullOrEmpty(item.ExpertConfirmation))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Not yet...</div>\r\n");
#nullable restore
#line 59 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                    } else {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ExpertConfirmation));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                                                                          
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 64 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                     if (@item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"badge badge-success badge-success-alt\">  Active </div>\r\n");
#nullable restore
#line 67 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"badge badge-danger badge-danger-alt\">  Inactive </div>\r\n");
#nullable restore
#line 71 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 75 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PredictionPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                            \r\n                        </tr>\r\n");
#nullable restore
#line 84 "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\Prediction\HistoryFarmer.cshtml"
                        index++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""container text-center"">
    <div class=""row py-5"">
        <div class=""col-12"">
            <h6 class=""small text-danger"">.</h6>
        </div>
    </div>
</div>
<script type=""text/javascript"" charset=""utf8"" src=""/DataTables/datatables.js""></script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplicationClient.Models.Prediction>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591