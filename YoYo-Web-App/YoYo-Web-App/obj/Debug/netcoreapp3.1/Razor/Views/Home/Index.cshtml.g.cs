#pragma checksum "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684a483ba6aebe018b01c9e6474bb5509806e8b5"
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
#line 1 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\_ViewImports.cshtml"
using YoYo_Web_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\_ViewImports.cshtml"
using YoYo_Web_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684a483ba6aebe018b01c9e6474bb5509806e8b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251bec0c4eca2814e5a8cc32b766599366070b64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YoYo_Web_App.ViewModel.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""text-center"">
                <h1 class=""display-4"">WELCOME TO <br /> YO-YO-Test-Web App</h1>
            </div>
        </div>
    </div>
    <br />
    <div class=""row justify-content-center"">
        <div class=""card"" style=""width: 30rem;"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <div id=""controls"" class=""text-center"" hidden>
                            <button id=""playBtn"" onclick=""start();"" type=""button"" class=""btn btn-primary btn-lg rounded-pill mainBtn""><i class=""fa fa-play"" aria-hidden=""true""></i></button>
                            <button id=""pauseBtn"" onclick=""stop();"" type=""button"" class=""btn btn-primary btn-lg rounded-pill mainBtn""><i class=""fa fa-pause"" aria-hidden=""true""></i></button>
                            <button id=""restartBtn"" onclick=""restart();"" type=""button"" class=""btn btn-primary btn-lg rounded-");
            WriteLiteral(@"pill mainBtn""><i class=""fa fa-refresh"" aria-hidden=""true""></i></button>
                        </div>
                    </div>
                    <div class=""col text-center"">
                        <p>Level <span id=""currentShuttleLevelNumber""> 0</span> </p>
                        <p>Shuttle <span id=""currentShuttleNumber""> 0</span> </p>
                        <p><span id=""currentShuttleSpeed"">0</span> km/hr</p>

                    </div>

                </div>
                <p>
                    <div class=""progress"" style=""height: 10px;"">
                        <div id=""speed-level-progress-bar"" class=""progress-bar progress-bar-striped progress-bar-animated"" role=""progressbar"" style=""width: 0%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </p>
            </div>
        </div>
    </div>

    <br />
    <div id=""finishTestBtn"" class=""text-center"" hidden><button onclick='finishTest();' id=""finishTestBtnEle"" type=""button"" class=""btn");
            WriteLiteral(@" btn-outline-success btn-sm rounded-pill"">Finish Test</button></div>
    <br />
    <div class=""row justify-content-center text-center"">
        <div class=""card"" style=""width: 30rem;"">
            <div class=""card-body"">
                <div class=""row "">

                    <div class=""col"">
                        <p>Next <br /> Shuttle</p>
                        <p id=""cdTimer"">__:__</p>

                    </div>
                    <div class=""col"">
                        <p>Total <br /> Time</p>
                        <p id=""timer""");
            BeginWriteAttribute("class", " class=\"", 2684, "\"", 2692, 0);
            EndWriteAttribute();
            WriteLiteral(@">__:__</p>

                    </div>
                    <div class=""col"">
                        <p>Total <br /> Distance</p>
                        <p><span id=""currentTotalDistance"">__</span> m</p>

                    </div>
                </div>
            </div>
        </div>
    </div>

");
            WriteLiteral("\n    <br />\n    <div class=\"row justify-content-center\">\n        <div class=\"card\" style=\"width: 30rem;\">\n            <div class=\"card-header\">\n                Track\n            </div>\n            <div class=\"card-body\">\n");
#nullable restore
#line 81 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
                  
                    int sNo = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
                 foreach (var item in Model.players)
                {
                    sNo++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\"");
            BeginWriteAttribute("id", " id=\"", 3436, "\"", 3456, 2);
            WriteAttributeValue("", 3441, "player-", 3441, 7, true);
#nullable restore
#line 88 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 3448, item.id, 3448, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"col-8\">\n                            ");
#nullable restore
#line 90 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
                       Write(sNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(".   ");
#nullable restore
#line 90 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div");
            BeginWriteAttribute("class", " class=\"", 3609, "\"", 3651, 4);
            WriteAttributeValue("", 3617, "col-2", 3617, 5, true);
            WriteAttributeValue(" ", 3622, "btnPlayer-", 3623, 11, true);
#nullable restore
#line 92 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 3633, item.id, 3633, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3641, "btnPlayer", 3642, 10, true);
            EndWriteAttribute();
            WriteLiteral(" hidden>\n                            <button");
            BeginWriteAttribute("id", " id=\"", 3696, "\"", 3723, 2);
            WriteAttributeValue("", 3701, "warnBtnPlayer-", 3701, 14, true);
#nullable restore
#line 93 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 3715, item.id, 3715, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\'", 3724, "\'", 3774, 5);
            WriteAttributeValue("", 3734, "warnPlayer(\"Player-", 3734, 19, true);
#nullable restore
#line 93 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 3753, item.id, 3753, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3761, "\",", 3761, 2, true);
#nullable restore
#line 93 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3763, item.id, 3764, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3772, ");", 3772, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-warning btn-sm rounded-pill\">Warn</button>\n                        </div>\n                        <div");
            BeginWriteAttribute("class", " class=\"", 3915, "\"", 3957, 4);
            WriteAttributeValue("", 3923, "col-2", 3923, 5, true);
            WriteAttributeValue(" ", 3928, "btnPlayer-", 3929, 11, true);
#nullable restore
#line 95 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 3939, item.id, 3939, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3947, "btnPlayer", 3948, 10, true);
            EndWriteAttribute();
            WriteLiteral(" hidden>\n                            <button");
            BeginWriteAttribute("id", " id=\"", 4002, "\"", 4029, 2);
            WriteAttributeValue("", 4007, "stopBtnPlayer-", 4007, 14, true);
#nullable restore
#line 96 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4021, item.id, 4021, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\"");
            BeginWriteAttribute("onclick", " onclick=\'", 4050, "\'", 4100, 5);
            WriteAttributeValue("", 4060, "stopPlayer(\"Player-", 4060, 19, true);
#nullable restore
#line 96 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4079, item.id, 4079, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4087, "\",", 4087, 2, true);
#nullable restore
#line 96 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4089, item.id, 4090, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4098, ");", 4098, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-danger btn-sm rounded-pill\">Stop</button>\n                        </div>\n                        <div");
            BeginWriteAttribute("class", " class=\"", 4240, "\"", 4277, 3);
            WriteAttributeValue("", 4248, "col-4", 4248, 5, true);
            WriteAttributeValue(" ", 4253, "finishedPlayer-", 4254, 16, true);
#nullable restore
#line 98 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4269, item.id, 4269, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden> <select");
            BeginWriteAttribute("id", " id=\"", 4294, "\"", 4322, 2);
            WriteAttributeValue("", 4299, "finishedPlayer-", 4299, 15, true);
#nullable restore
#line 98 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4314, item.id, 4314, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\'", 4323, "\'", 4391, 6);
            WriteAttributeValue("", 4334, "playerResultChanged(", 4334, 20, true);
#nullable restore
#line 98 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4354, item.id, 4354, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4362, ",", 4362, 1, true);
            WriteAttributeValue(" ", 4363, "\"finishedPlayer-\"+", 4364, 19, true);
#nullable restore
#line 98 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"
WriteAttributeValue("", 4382, item.id, 4382, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4390, ")", 4390, 1, true);
            EndWriteAttribute();
            WriteLiteral("></select></div>\n                    </div>\n                    <br />\n");
#nullable restore
#line 101 "G:\Practices\YoYo-Web-App\YoYo-Web-App\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n");
            WriteLiteral("\n\n\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YoYo_Web_App.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591