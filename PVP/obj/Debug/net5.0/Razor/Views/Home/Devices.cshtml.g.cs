#pragma checksum "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d23e03c6cb33907a1c9fd536ea10cdbd447b471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Devices), @"mvc.1.0.view", @"/Views/Home/Devices.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d23e03c6cb33907a1c9fd536ea10cdbd447b471", @"/Views/Home/Devices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Devices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PVP.Models.Device>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
  
    ViewData["Title"] = "Devices";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""center-container-wider"">
    <h1 class=""center-text-title"">Jūsų įrenginiai</h1>

    <p class=""container-text"">Šioje puslapio dalyje galite valdyti pridėtus įrenginius: keisti pavadinimą bei limitą, ištrinti įrenginio sukauptus duomenis, pašalinti pasirinktą įrenginį.</p>
");
#nullable restore
#line 10 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
     if (Model.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover"" id=""table-devices"">
            <colgroup>
                <col span=""1"" style=""width: 5%;"">
                <col span=""1"" style=""width: 63%;"">
                <col span=""1"" style=""width: 25%;"">
                <col span=""1"" style=""width: 7%; float: right;"">
            </colgroup>
            <tbody>
                <tr style=""font-size: 18px;"">
                    <th></th>
                    <th>Pavadinimas</th>
                    <th>Limitas</th>
                    <th>Parinktys</th>
                </tr>
");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr class=\"table-main\" style=\"font-size: 17px;\">\r\n                    <td style=\"font-size: 20px;\"><span class=\"glyphicon glyphicon-modal-window\"></span></td>\r\n");
#nullable restore
#line 30 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                 if (item.Tag == null || item.Tag == "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: darkgray\">Įrenginys ");
#nullable restore
#line 32 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                                                     Write(item.SetupString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 36 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tag));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                 if (item.Treshold == null || item.Treshold == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"font-size: 14px;\">&nbsp;Nėra</td>\r\n");
#nullable restore
#line 41 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"font-size: 14px;\">&nbsp;");
#nullable restore
#line 44 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Treshold));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <td>
                        <div class=""dropdown"" style=""float:right;"">
                            <span title=""Parinktys"" class=""glyphicon glyphicon-option-vertical"" style=""font-size: 20px;""></span>
                            <div class=""dropdown-content"">
                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2189, "\"", 2229, 6);
            WriteAttributeValue("", 2199, "editTag(", 2199, 8, true);
#nullable restore
#line 50 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2207, item.Id, 2207, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2215, ",", 2215, 1, true);
            WriteAttributeValue(" ", 2216, "\'", 2217, 2, true);
#nullable restore
#line 50 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2218, item.Tag, 2218, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2227, "\')", 2227, 2, true);
            EndWriteAttribute();
            WriteLiteral("><span title=\"Keisti pavadinimą\" class=\"glyphicon glyphicon-pencil\"></span>&nbsp;&nbsp;Keisti pavadinimą</a>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2374, "\"", 2424, 6);
            WriteAttributeValue("", 2384, "editTreshold(", 2384, 13, true);
#nullable restore
#line 51 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2397, item.Id, 2397, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2405, ",", 2405, 1, true);
            WriteAttributeValue(" ", 2406, "\'", 2407, 2, true);
#nullable restore
#line 51 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2408, item.Treshold, 2408, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2422, "\')", 2422, 2, true);
            EndWriteAttribute();
            WriteLiteral("><span title=\"Keisti limitą\" class=\"glyphicon glyphicon-pencil\"></span>&nbsp;&nbsp;Keisti limitą</a>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2561, "\"", 2596, 3);
            WriteAttributeValue("", 2571, "clearStatistics(", 2571, 16, true);
#nullable restore
#line 52 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2587, item.Id, 2587, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2595, ")", 2595, 1, true);
            EndWriteAttribute();
            WriteLiteral("><span title=\"Ištrinti statistiką\" class=\"glyphicon glyphicon-trash\"></span>&nbsp;&nbsp;Ištrinti statistiką</a>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2744, "\"", 2776, 3);
            WriteAttributeValue("", 2754, "removeDevice(", 2754, 13, true);
#nullable restore
#line 53 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
WriteAttributeValue("", 2767, item.Id, 2767, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2775, ")", 2775, 1, true);
            EndWriteAttribute();
            WriteLiteral("><span title=\"Pašalinti įrenginį\" class=\"glyphicon glyphicon-remove\"></span>&nbsp;&nbsp;Pašalinti</a>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 61 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"error-text\">Neturite pridėtų įrenginių. Pridėti įrenginį galite šio puslapio apačioje.</p>\r\n");
#nullable restore
#line 65 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""center-container"">
    <h1 class=""center-text-title"">Naujo įrenginio pridėjimas</h1>
    <p class=""container-text"">Šioje puslapio dalyje galite pridėti naują įrenginį.<br>
    Įveskite turimo įrenginio unikalų atpažinimo kodą (10 simbolių ilgio kodas esantis ant prietaiso).</p>

    <div class=""device-form"">
        <div class=""wrap-input100 m-b-60"">
            <input class=""input100"" type=""text"" id=""setupInput"" placeholder=""Įrenginio atpažinimo kodas"" style=""font-size: 14px;"">
            <span class=""focus-input100""></span>
        </div>
        <div class=""wrap-input100 m-b-15"" style=""margin-bottom: 25px; margin-top: 25px;"">
            <input class=""input100"" type=""text"" id=""tagInput"" placeholder=""Įrenginio pavadinimas (nebūtina)"" style=""font-size: 14px;"">
            <span class=""focus-input100""></span>
        </div>
        <div class=""container-login100-form-btn m-t-20"" onclick=""newDevice()"">
            <button class=""login100-form-btn"">
                Pridėti");
            WriteLiteral(@"
            </button>
        </div>
    </div>
</div>



<script type=""text/javascript"">

    function editTag(device_id, currentTag) {
        Swal.fire({
            icon: 'question',
            title: 'Įveskite naują įrenginio pavadinimą:',
            input: 'text',
            inputPlaceholder: currentTag,
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            confirmButtonText: 'Išsaugoti',
            cancelButtonText: 'Atšaukti',
            showLoaderOnConfirm: true,
            preConfirm: (tg) => {
                if (tg.length > 50)
                {
                    Swal.showValidationMessage(`Įrenginio pavadinimas negali būti ilgesnis nei 50 simbolių!`)
                }
                else {
                    var tagjson = JSON.stringify({ id: device_id, value: tg });
                    $.ajax({
                        type: ""POST"",
                        url: """);
#nullable restore
#line 116 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                         Write(Url.Action("UpdateTag", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        contentType: ""application/json; charset=utf-8"",
                        data: tagjson,
                        success: function () {
                            Swal.fire({
                                icon: 'success',
                                title: 'Pakeitimai išsaugoti!',
                                confirmButtonText: 'Gerai',
                            }).then((result) => {
                                location.reload();
                            })
                        },
                        error: function () {
                            Swal.fire('Vidinė klaida.')
                        }
                    });
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        })
    }

    function newDevice() {
        var setupInput = document.getElementById('setupInput').value
        var tagInput = document.getElementById('tagInput').value

        var tagjson = JSON.stringify({ setupSt");
            WriteLiteral("ring: setupInput, tag: tagInput });\r\n\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
#nullable restore
#line 146 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
             Write(Url.Action("NewDevice", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            contentType: ""application/json; charset=utf-8"",
            data: tagjson,
            success: function () {
                Swal.fire({
                    icon: 'success',
                    title: 'Įrenginys pridėtas!',
                    showConfirmButton: true,
                    confirmButtonText: 'Gerai',
                }).then((result) => {
                    location.reload();
                })
            },
            error: function (response) {
                Swal.fire({
                    icon: 'warning',
                    title: response.responseText,
                    text: 'Įsitikinkite, jog teisingai įvedėte atpažinimo kodą.',
                    showConfirmButton: true,
                    confirmButtonText: 'Gerai'
                })
            }
        });

    }

    function editTreshold(device_id, currentTreshold) {
        Swal.fire({
            icon: 'question',
            title: 'Įveskite naują limitą:',
            text");
            WriteLiteral(@": 'Jei norite panaikinti limitą, įveskite 0 arba palikite lauką tuščią.',
            input: 'text',
            inputPlaceholder: currentTreshold,
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            confirmButtonText: 'Išsaugoti',
            cancelButtonText: 'Atšaukti',
            showLoaderOnConfirm: true,
            preConfirm: (tr) => {
                if (tr.length > 10)
                {
                    Swal.showValidationMessage(`Įrenginio limitas negali būti ilgesnis nei 10 simbolių!`)
                }
                else if (isNaN(tr) || tr < 0) {
                    Swal.showValidationMessage(`Veskite tik sveikus teigiamus skaičius!`)
                }
                else {
                    if (!tr) {
                        tr = '0';
                    }
                    var tagjson = JSON.stringify({ id: device_id, value: tr });
                    $.ajax({
                    ");
            WriteLiteral("    type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 201 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                         Write(Url.Action("UpdateTreshold", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        contentType: ""application/json; charset=utf-8"",
                        data: tagjson,
                        success: function () {
                            Swal.fire({
                                icon: 'success',
                                title: 'Pakeitimai išsaugoti!',
                                confirmButtonText: 'Gerai',
                            }).then((result) => {
                                location.reload();
                            })
                        },
                        error: function () {
                            Swal.fire('Vidinė klaida.')
                        }
                    });
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        })
    }

    function clearStatistics(device_id) {
        Swal.fire({
            icon: 'warning',
            title: 'Ar tikrai norite ištrinti visus šio įrenginio įrašus?',
            text: 'Ištrintų įrenginio ele");
            WriteLiteral(@"ktros sunaudojimo įrašų atkurti nebus galima.',
            showCancelButton: true,
            confirmButtonText: 'Ištrinti',
            cancelButtonText: 'Atšaukti',
            showLoaderOnConfirm: true,
            preConfirm: (tr) => {
                var tagjson = JSON.stringify({ id: device_id, value: '' });
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 236 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                     Write(Url.Action("ClearStatistics", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    contentType: ""application/json; charset=utf-8"",
                    data: tagjson,
                    success: function () {
                        Swal.fire({
                            icon: 'success',
                            title: 'Įrašai ištrinti.',
                            confirmButtonText: 'Gerai',
                        }).then((result) => {
                            location.reload();
                        })
                    },
                    error: function () {
                        Swal.fire('Klaida.')
                    }
                });

            },
            allowOutsideClick: () => !Swal.isLoading()
        })
    }

    function removeDevice(device_id) {
        Swal.fire({
            icon: 'warning',
            title: 'Ar tikrai norite pašalinti įrenginį ir visus jo sukauptus duomenis?',
            text: 'Jei įrenginį pametėte, jis nepataisomai sugedo, ar norite jį atiduoti kitam naudotojui, galite jį pa");
            WriteLiteral(@"šalinti.',
            showCancelButton: true,
            confirmButtonText: 'Pašalinti',
            cancelButtonText: 'Atšaukti',
            showLoaderOnConfirm: true,
            preConfirm: (tr) => {
                var tagjson = JSON.stringify({ id: device_id, value: '' });
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 271 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Home\Devices.cshtml"
                     Write(Url.Action("RemoveDevice", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    contentType: ""application/json; charset=utf-8"",
                    data: tagjson,
                    success: function () {
                        Swal.fire({
                            icon: 'success',
                            title: 'Įrenginys pašalintas.',
                            confirmButtonText: 'Gerai',
                        }).then((result) => {
                            location.reload();
                        })
                    },
                    error: function () {
                        Swal.fire('Klaida.')
                    }
                });

            },
            allowOutsideClick: () => !Swal.isLoading()
        })
    }

</script>
");
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
