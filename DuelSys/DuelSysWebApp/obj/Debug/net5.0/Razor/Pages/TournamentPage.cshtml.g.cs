#pragma checksum "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4456ea186aab93521899538b148bee64e46c9651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DuelSysWebApp.Pages.Pages_TournamentPage), @"mvc.1.0.razor-page", @"/Pages/TournamentPage.cshtml")]
namespace DuelSysWebApp.Pages
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
#line 1 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\_ViewImports.cshtml"
using DuelSysWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4456ea186aab93521899538b148bee64e46c9651", @"/Pages/TournamentPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ae54a30684d14ab30a6da654d5fc187d148648", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TournamentPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
  
    ViewData["Title"] = "Tournament page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n      <tr>\r\n                \r\n                <td class=\"col\"> Type:\"");
#nullable restore
#line 10 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                  Write(Model.tournament.SportType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" |</td>\r\n                 <td class=\"col\"> Minimum Players: ");
#nullable restore
#line 11 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                              Write(Model.tournament.MinPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n                  <td class=\"col\"> Max Players: ");
#nullable restore
#line 12 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                           Write(Model.tournament.MaxPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n                   <td class=\"col\"> Current Players: ");
#nullable restore
#line 13 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                                Write(Model.participatinglist.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("|</td>\r\n                    <td class=\"col\">Start: ");
#nullable restore
#line 14 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                      Write(Model.tournament.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n                     <td class=\"col\">Ends: ");
#nullable restore
#line 15 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                      Write(Model.tournament.EndGame);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n                      <td class=\"col\">Location: ");
#nullable restore
#line 16 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                           Write(Model.tournament.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n                       <td class=\"col\">Description: ");
#nullable restore
#line 17 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                                               Write(Model.tournament.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</td>\r\n          <td class=\"col\"> \r\n              \r\n           \r\n          \r\n            \r\n");
#nullable restore
#line 23 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                 if(Model.isPlayerInTour == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4456ea186aab93521899538b148bee64e46c96518293", async() => {
                WriteLiteral("\r\n             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4456ea186aab93521899538b148bee64e46c96518564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 26 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.tournament.id);

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
                WriteLiteral("\r\n                  <button class=\"btn-add\">Leave tournament</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4456ea186aab93521899538b148bee64e46c965112175", async() => {
                WriteLiteral("\r\n             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4456ea186aab93521899538b148bee64e46c965112447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.tournament.id);

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
                WriteLiteral("\r\n                  <button class=\"btn-add\">Apply for tournament</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n          </td>\r\n            </tr>\r\n     <div>");
#nullable restore
#line 40 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\TournamentPage.cshtml"
     Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuelSysWebApp.Pages.TournamentPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebApp.Pages.TournamentPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebApp.Pages.TournamentPageModel>)PageContext?.ViewData;
        public DuelSysWebApp.Pages.TournamentPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591