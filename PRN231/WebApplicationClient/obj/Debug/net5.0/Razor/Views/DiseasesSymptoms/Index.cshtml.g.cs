#pragma checksum "C:\Users\asus\Downloads\Git118\prn231_fa22\PRN231\WebApplicationClient\Views\DiseasesSymptoms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fb6f45de9570d5f6d83559b5086b91a8329714e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiseasesSymptoms_Index), @"mvc.1.0.view", @"/Views/DiseasesSymptoms/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fb6f45de9570d5f6d83559b5086b91a8329714e", @"/Views/DiseasesSymptoms/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0102d1ddfaf2ed240c70f7ce09a6435cd8f20b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DiseasesSymptoms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/diseasesymptom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSymptomByDisease", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DiseasesSymptoms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fb6f45de9570d5f6d83559b5086b91a8329714e5403", async() => {
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
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 87, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h2 class=\"btn-pink mb-5 py-2\" style=\"width:40%\"> <i class=\"fa-sharp fa-solid fa-bug\" style=\"color:greenyellow\"></i> Diseases with symptom</h2>\r\n    <hr/>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fb6f45de9570d5f6d83559b5086b91a8329714e6933", async() => {
                WriteLiteral("Add More Symptoms");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomOne</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 456
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 2.4k
                            </div>
         ");
            WriteLiteral(@"                   <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 99
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomTwo</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 1.9k
                 ");
            WriteLiteral(@"           </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 2k
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 306
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomThree</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">");
            WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 1.1k
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 108
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 629
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomThree</h2>
                        <p class=""c");
            WriteLiteral(@"ard-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 1.1k
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 108
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 629
                            </div>
                        </div>
                    </div>
                </div>
            </div><div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class");
            WriteLiteral(@"=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomOne</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 456
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 2.4k
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 99
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-xs-12 ");
            WriteLiteral(@"col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomTwo</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 1.9k
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 2k
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""");
            WriteLiteral(@"></i> 306
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomThree</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-comments""></i> 1.1k
                            </div>
                            <div class=""col col-xs-4 "">
                       ");
            WriteLiteral(@"         <i class=""far fa-heart""></i> 108
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 629
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                <div class=""card shadow"">
                    <img src=""https://drive.google.com/uc?export=view&id=1aj_vT5zjJlkdEQ_VcCsdnvpVBi-Fjwyb"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                        <h2 class=""card-title"">SymptomThree</h2>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    </div>
                    <div class=""card-body card-p"">
                        <div class=""row"">
                            <div class=""col col-xs-4 "">");
            WriteLiteral(@"
                                <i class=""far fa-comments""></i> 1.1k
                            </div>
                            <div class=""col col-xs-4 "">
                                <i class=""far fa-heart""></i> 108
                            </div>
                            <div class=""col col-xs-4"">
                                <i class=""fas fa-share""></i> 629
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
