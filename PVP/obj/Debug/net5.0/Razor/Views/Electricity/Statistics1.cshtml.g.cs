#pragma checksum "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2621ca9987efc0db3a5aff5acefa80d03468eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Electricity_Statistics1), @"mvc.1.0.view", @"/Views/Electricity/Statistics1.cshtml")]
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
#line 1 "C:\Users\gladi\Desktop\PVP4\PVP\Views\_ViewImports.cshtml"
using PVP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\PVP4\PVP\Views\_ViewImports.cshtml"
using PVP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2621ca9987efc0db3a5aff5acefa80d03468eee", @"/Views/Electricity/Statistics1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Electricity_Statistics1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PVP.Models.Device>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
  
    ViewData["Title"] = "Statistics1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"center-container-wider\">\r\n    <h1 class=\"center-text-title\">Statistika realiu laiku</h1>\r\n\r\n    <p class=\"container-text\">Šioje puslapio dalyje galite stebėti įrenginių pateikiamus elektros sunaudojimo rodmenis realiu laiku.</p>\r\n");
#nullable restore
#line 13 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
     if (Model.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-hover\" id=\"table-realtime\">\r\n            <colgroup>\r\n                <col span=\"1\" style=\"width: 75%;\">\r\n                <col span=\"1\" style=\"width: 25%;\">\r\n            </colgroup>\r\n            <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-main\">\r\n");
#nullable restore
#line 24 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                     if (item.Tag == null || item.Tag == "")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color: darkgray\"><span style=\"color: black\" class=\"glyphicon glyphicon-modal-window\"></span>&nbsp;Įrenginys ");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                                                                                                                                          Write(item.SetupString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"glyphicon glyphicon-modal-window\"></span>&nbsp;");
#nullable restore
#line 30 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.Tag));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td");
            BeginWriteAttribute("id", " id=\"", 1220, "\"", 1240, 2);
            WriteAttributeValue("", 1225, "device-", 1225, 7, true);
#nullable restore
#line 32 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
WriteAttributeValue("", 1232, item.Id, 1232, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Atnaujinama...</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 37 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"error-text\">Neturite pridėtų įrenginių. Pridėti naują įrenginį galite meniu juostoje paspaudus \"Įrenginiai\".</p>\r\n");
#nullable restore
#line 41 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    setInterval(function fetchDataAuto() {\r\n        var device_id_list = ");
#nullable restore
#line 56 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
                        Write(Html.Raw(Json.Serialize(@Model.Select(item => item.Id).ToArray())));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        for (const d_id of device_id_list) {\r\n            fetchData(d_id);\r\n        }\r\n    }, 1500); // ms\r\n\r\n    function fetchData(d_id) {\r\n        $.ajax({\r\n            url: \"");
#nullable restore
#line 64 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Electricity\Statistics1.cshtml"
             Write(Url.Action("LiveWattage", "Electricity"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { device_id: d_id },
            type: ""GET"",
            success: function (result) {
                if (result == -1) {
                    document.getElementById(""device-"" + d_id).innerHTML = ""Įrenginys išjungtas."";
                    document.getElementById(""device-"" + d_id).style.fontWeight = ""bold"";
                }
                else {
                    document.getElementById(""device-"" + d_id).innerHTML = ""<span class=\""glyphicon glyphicon-flash\"" style=\""color: #ffdc5f\""></span>&nbsp;"" + result + "" W"";
                    document.getElementById(""device-"" + d_id).style.fontWeight = ""bold"";
                }
            },
            error: function (result) {
                document.getElementById(""device-"" + d_id).innerHTML = ""Duomenų perdavimo klaida.""
            }
        });
    }

");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PVP.Models.Device>> Html { get; private set; }
    }
}
#pragma warning restore 1591
