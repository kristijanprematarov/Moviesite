#pragma checksum "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6615b85839da369543518a706708c5d526ff880e"
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
#line 1 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\_ViewImports.cshtml"
using Moviesite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\_ViewImports.cshtml"
using Moviesite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6615b85839da369543518a706708c5d526ff880e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe197e3fc0c4547393d651667b83072c750b9a17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Moviesite.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:450px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Search Section -->\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6615b85839da369543518a706708c5d526ff880e5393", async() => {
                WriteLiteral(@"
        <div class=""p-3 search-main"">
            <button class=""btn search-btn-icon"">
                <i class=""fa fa-search""></i>
            </button>
            <input type=""text"" class=""form-control search-box-style"" id=""searchmovie"" />
            <button class=""btn btn-success search-btn"" id=""searchBtn"">Search</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<!-- Banner Section -->\r\n<div class=\"container-fluid px-0 banner-container text-center text-sm-left\">\r\n");
            WriteLiteral("    <div class=\"moviesite-background\"></div>\r\n");
            WriteLiteral("</div>\r\n\r\n<!-- All Movies Section -->\r\n<div class=\"container-fluid\">\r\n    <h2>All Movies</h2>\r\n    <h6><em>List of all movies</em></h6>\r\n    <div class=\"row pb-5\">\r\n");
#nullable restore
#line 46 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
         foreach (var movie in Model.AllMoviesList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-6 col-lg-4 col-xl-3 mt-5\">\r\n                <div class=\"card h-100 mx-auto\" style=\"max-width: 350px;\">\r\n                    <div class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6615b85839da369543518a706708c5d526ff880e8085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2229, "~/photos/", 2229, 9, true);
#nullable restore
#line 51 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2238, movie.PhotoURL, 2238, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <div class=""text-center d-flex flex-column justify-content-center"" style=""height:120px"">
                            <h5 class=""card-title w-100""><a class=""text-dark""");
            BeginWriteAttribute("href", " href=\"", 2586, "\"", 2617, 2);
            WriteAttributeValue("", 2593, "/Movie/Details/", 2593, 15, true);
#nullable restore
#line 55 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2608, movie.Id, 2608, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <h6");
            BeginWriteAttribute("class", " class=\"", 2703, "\"", 2711, 0);
            EndWriteAttribute();
            WriteLiteral("><em>Directed by <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 2749, "\"", 2791, 2);
            WriteAttributeValue("", 2756, "/Director/Details/", 2756, 18, true);
#nullable restore
#line 56 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2774, movie.DirectorID, 2774, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                                                                                                    Write(Html.DisplayFor(modelItem => movie.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></em></h6>\r\n                            <h6");
            BeginWriteAttribute("class", " class=\"", 2889, "\"", 2897, 0);
            EndWriteAttribute();
            WriteLiteral("><em>Produced by <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 2935, "\"", 2977, 2);
            WriteAttributeValue("", 2942, "/Producer/Details/", 2942, 18, true);
#nullable restore
#line 57 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2960, movie.ProducerID, 2960, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                                                                                                    Write(Html.DisplayFor(modelItem => movie.ProducerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></em></h6>\r\n                        </div>\r\n                        <hr />\r\n                        <p class=\"card-text\">Genre: ");
#nullable restore
#line 60 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => movie.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Movie Rating: ");
#nullable restore
#line 61 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => movie.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/5.0</p>
                        <button class=""btn btn-secondary btn-block""><i class=""fas fa-plus-circle""></i> Add to Wishlist</button>
                        <button class=""btn btn-success btn-block""><i class=""fas fa-cart-plus""></i> Add to Cart</button>
");
            WriteLiteral(@"                    </div>
                    <div class=""price text-center"">
                        <p class=""w-75 mx-auto card-text bg-light text-success font-weight-bold rounded-pill animate__animated animate__heartBeat animate__infinite animate__faster"">");
#nullable restore
#line 77 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
                                                                                                                                                                                Write(Html.DisplayFor(modelItem => movie.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("&euro;</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 81 "C:\Users\Kristijan\source\repos\Moviesite\Moviesite\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6615b85839da369543518a706708c5d526ff880e15134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Moviesite.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
