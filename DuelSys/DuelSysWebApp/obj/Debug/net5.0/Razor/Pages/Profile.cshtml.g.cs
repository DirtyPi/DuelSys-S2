#pragma checksum "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ae94181246c9cc6d5a076e33f933e35eb7fa6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DuelSysWebApp.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ae94181246c9cc6d5a076e33f933e35eb7fa6c", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ae54a30684d14ab30a6da654d5fc187d148648", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 9 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
   Write(Model.user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 12 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
   Write(Model.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
 for (int i = 0; i <= Model.participatings.Count() - 1; i++)
{
     var participating = Model.participatings[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n          <td>   <div");
            BeginWriteAttribute("class", " class=\"", 353, "\"", 361, 0);
            EndWriteAttribute();
            WriteLiteral("> Sport type: <h1>");
#nullable restore
#line 18 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                           Write(Html.DisplayFor(Par => participating.tournament.SportType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n           <td>    <div");
            BeginWriteAttribute("class", " class=\"", 480, "\"", 488, 0);
            EndWriteAttribute();
            WriteLiteral("> Location: <h1>");
#nullable restore
#line 19 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                           Write(Html.DisplayFor(Par => participating.tournament.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n           <td>    <div");
            BeginWriteAttribute("class", " class=\"", 604, "\"", 612, 0);
            EndWriteAttribute();
            WriteLiteral("> Start time: <h1>");
#nullable restore
#line 20 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                             Write(Html.DisplayFor(Par => participating.tournament.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n             <td>    <div");
            BeginWriteAttribute("class", " class=\"", 733, "\"", 741, 0);
            EndWriteAttribute();
            WriteLiteral("> Wins: <h1>");
#nullable restore
#line 21 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                         Write(Html.DisplayFor(Par => participating.Won));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n               <td>    <div");
            BeginWriteAttribute("class", " class=\"", 841, "\"", 849, 0);
            EndWriteAttribute();
            WriteLiteral(">  Lost:<h1>");
#nullable restore
#line 22 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                           Write(Html.DisplayFor(Par => participating.Los));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n                 <td>   <div");
            BeginWriteAttribute("class", " class=\"", 950, "\"", 958, 0);
            EndWriteAttribute();
            WriteLiteral("> Rank: <h1>");
#nullable restore
#line 23 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                            Write(Html.DisplayFor(Par => participating.Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div></td>\r\n     </tr>\r\n");
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 1056, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h2>Matches:</h2>\r\n");
#nullable restore
#line 28 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
         foreach(var m in Model.matches)
        {
            if(participating.Rank !=0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">Match ID:  <h4>");
#nullable restore
#line 32 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                                   Write(Html.DisplayFor(M => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                <div class=\"text-center\">  <h4>");
#nullable restore
#line 33 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                          Write(Html.DisplayFor(M => m.Player1.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> |<h4>");
#nullable restore
#line 33 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                                                                              Write(Html.DisplayFor(M => m.ResultPlayer1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>| vs.|<h4>");
#nullable restore
#line 33 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                                                                                                                                   Write(Html.DisplayFor(M => m.ResultPlayer2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>| <h4>");
#nullable restore
#line 33 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
                                                                                                                                                                                                    Write(Html.DisplayFor(M => m.Player2.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n");
#nullable restore
#line 34 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
            }
           

           
                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 41 "C:\HRISTO TANCHEV\Fontaka\Sem2 T3\synthesisassignment-hristotanchev\DuelSys\DuelSysWebApp\Pages\Profile.cshtml"
       


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuelSysWebApp.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebApp.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebApp.Pages.ProfileModel>)PageContext?.ViewData;
        public DuelSysWebApp.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591