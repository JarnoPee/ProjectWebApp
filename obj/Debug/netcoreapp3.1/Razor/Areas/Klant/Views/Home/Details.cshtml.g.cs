#pragma checksum "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27293b910a05c9ba909ab9326e6202ebcb93121c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Klant_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Klant/Views/Home/Details.cshtml")]
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
#line 1 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\_ViewImports.cshtml"
using ProjectWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\_ViewImports.cshtml"
using ProjectWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27293b910a05c9ba909ab9326e6202ebcb93121c", @"/Areas/Klant/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771972434ccc2479eca7aebeef0a6a25a5d7fa00", @"/Areas/Klant/Views/_ViewImports.cshtml")]
    public class Areas_Klant_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectWebApp.Models.OpgeslagenOpleidingen>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27293b910a05c9ba909ab9326e6202ebcb93121c5319", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27293b910a05c9ba909ab9326e6202ebcb93121c5579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 4 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OpleidingId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <div class=\"container backgroundWhite\">\n        <div class=\"card\">\n            <div class=\"card-header bg-light text-light ml-0 row container\">\n                <div class=\"col-12 col-md-6\">\n                    <h1 class=\"text-primary\">");
#nullable restore
#line 9 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                        Write(Model.Opleiding.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                </div>\n                <div class=\"col-12 col-md-6 text-md-right pt-4\">\n                    <span class=\"badge badge-success pt-2\" style=\"height:30px;\">");
#nullable restore
#line 12 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                                           Write(Model.Opleiding.Categorie.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    <span class=\"badge badge-warning pt-2\" style=\"height:30px;\">");
#nullable restore
#line 13 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                                           Write(Model.Opleiding.Niveau.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-8 col-lg-8"">

                            <div class=""row pl-2"">
                                <h5 class=""text-muted"">Federatie: ");
#nullable restore
#line 22 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                             Write(Model.Opleiding.Federatie.Naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <h5 class=\"text-muted pb-2\">Prijs Opleiding: &euro;");
#nullable restore
#line 25 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                                              Write(Model.Opleiding.Prijs.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <p class=\"text-secondary\">");
#nullable restore
#line 28 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(Model.Opleiding.Omschrijving.Beschrijving));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <p class=\"text-secondary\">");
#nullable restore
#line 31 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(Model.Opleiding.Algemeenheden.Beschrijving));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <p class=\"text-secondary\">");
#nullable restore
#line 34 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(Model.Opleiding.Voorwaarden.Beschrijving));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <p class=\"text-secondary\">");
#nullable restore
#line 37 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(Model.Opleiding.Slot.Beschrijving));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            </div>\n                            <div class=\"row pl-2\">\n                                <div class=\"col-2 text-primary\"><h4>Aantal</h4></div>\n                                <div class=\"col-10\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27293b910a05c9ba909ab9326e6202ebcb93121c12227", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 41 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\n                            </div>\n                        </div>\n                        <div class=\"col-12 col-lg-3 offset-lg-1 text-center\">\n                            <img");
                BeginWriteAttribute("src", " src=\"", 2543, "\"", 2574, 1);
#nullable restore
#line 45 "E:\AA Thomas More\2020 - 2021\Webapplicaties\ProjectWebApp\Areas\Klant\Views\Home\Details.cshtml"
WriteAttributeValue("", 2549, Model.Opleiding.ImageUrl, 2549, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""100%"" class=""rounded"" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 pb-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27293b910a05c9ba909ab9326e6202ebcb93121c14699", async() => {
                    WriteLiteral("Terug naar alle opleidingen");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <!--NOG VERANDEREN NAAR ALLE OPELEIDINGEN-->
                    </div>
                    <div class=""col-12 col-md-6 pb-1"">
                        <button type=""submit"" value=""Add to Cart"" class=""btn btn-primary btn-square btn-lg form-control"" style=""height:50px;"">Toevoegen aan favorietenlijst</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectWebApp.Models.OpgeslagenOpleidingen> Html { get; private set; }
    }
}
#pragma warning restore 1591
