#pragma checksum "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faca2aab1d4acaa3dafaaac98b3437c5d437ac2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\_ViewImports.cshtml"
using WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faca2aab1d4acaa3dafaaac98b3437c5d437ac2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb8c12270e539e0055029ad4c13bfd732235ea6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- MAIN START -->\r\n\r\n<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 15 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
             foreach (var slides in Model.Slides)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> <img");
            BeginWriteAttribute("src", " src=\"", 291, "\"", 312, 2);
            WriteAttributeValue("", 297, "img/", 297, 4, true);
#nullable restore
#line 17 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 301, slides.URL, 301, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 313, "\"", 319, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 18 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Summary.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                       Write(Model.Summary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 839, "\"", 870, 2);
            WriteAttributeValue("", 845, "img/", 845, 4, true);
#nullable restore
#line 32 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 849, Model.Summary.Images, 849, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 871, "\"", 877, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->


    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1346, "\"", 1353, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1591, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 53 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                 foreach (var ct in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1769, "\"", 1776, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 55 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                       Write(ct.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 55 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                                           Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 56 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2065, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 62 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                         foreach (var ct in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2219, "\"", 2226, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 64 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                               Write(ct.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 64 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                                   Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2438, "\"", 2445, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        <div id=\"product-list\" class=\"row\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
            WriteLiteral(@"        </div>
            <div class=""row justify-content-center"">
                <button id=""loadProduct"" class=""btn btn-success"">Load more...</button>
            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "faca2aab1d4acaa3dafaaac98b3437c5d437ac2a12412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3335, "~/img/", 3335, 6, true);
#nullable restore
#line 94 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3341, Model.Video.Image, 3341, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        ");
#nullable restore
#line 102 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.VideoSummary.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"py-3\">\r\n                            ");
#nullable restore
#line 104 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                       Write(Model.VideoSummary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 107 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                             foreach (var item in Model.VideoSummaryList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"mt-3\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 4213, "\"", 4247, 2);
            WriteAttributeValue("", 4219, "img/", 4219, 4, true);
#nullable restore
#line 110 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 4223, Model.VideoSummary.Icon, 4223, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4261, "\"", 4267, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 112 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        ");
#nullable restore
#line 128 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.ExpertsSummary.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 130 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                       Write(Model.ExpertsSummary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 136 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                 foreach (var experts in Model.ExpertsSummaryList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5341, "\"", 5365, 2);
            WriteAttributeValue("", 5347, "img/", 5347, 4, true);
#nullable restore
#line 141 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 5351, experts.Image, 5351, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 5399, "\"", 5405, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                ");
#nullable restore
#line 144 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                           Write(Html.Raw(experts.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 145 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                    Write(experts.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 149 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->
");
            WriteLiteral("\n    <section id=\"blog\">\r\n        <div class=\"container\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"offset-lg-3 col-lg-6\">\r\n                    <div class=\"section-title\">\r\n                        ");
#nullable restore
#line 184 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Blog.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 186 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                       Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 192 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                 foreach (var cards in Model.BlogCards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7527, "\"", 7549, 2);
            WriteAttributeValue("", 7533, "img/", 7533, 4, true);
#nullable restore
#line 197 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 7537, cards.Image, 7537, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7568, "\"", 7574, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                           ");
#nullable restore
#line 203 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                      Write(Html.Raw(@cards.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 205 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                           Write(cards.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 210 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               
            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->
   
    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
               
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
");
#nullable restore
#line 225 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                         foreach (var slider in Model.FloristsSlides)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 8841, "\"", 8864, 2);
            WriteAttributeValue("", 8847, "img/", 8847, 4, true);
#nullable restore
#line 230 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 8851, slider.Image, 8851, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8865, "\"", 8871, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        ");
#nullable restore
#line 233 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                   Write(Html.Raw(slider.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        ");
#nullable restore
#line 236 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                   Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 237 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                                                            Write(slider.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 241 "C:\Users\Emilia\Source\Repos\Fiorello_FronToBack\Fiorello_FronToBack\WebUI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                </div>
                
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
            <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 9785, "\"", 9791, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9865, "\"", 9871, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9945, "\"", 9951, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10025, "\"", 10031, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10105, "\"", 10111, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10185, "\"", 10191, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10265, "\"", 10271, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10345, "\"", 10351, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
