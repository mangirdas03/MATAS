#pragma checksum "C:\Users\gladi\Desktop\PVP3\PVP\Views\Electricity\Statistics1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8cfb02b21d8ab3d6174f2e6fcc36823340fade"
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
#line 1 "C:\Users\gladi\Desktop\PVP3\PVP\Views\_ViewImports.cshtml"
using PVP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\PVP3\PVP\Views\_ViewImports.cshtml"
using PVP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8cfb02b21d8ab3d6174f2e6fcc36823340fade", @"/Views/Electricity/Statistics1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Electricity_Statistics1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Electricity\Statistics1.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">

    <p style=""font-size: 40px; color: white; font-weight: bold;"">Live/manual update test</p>
    <br />
    <br />
    <p style=""font-size: 30px; color: white; font-weight: bold;"">Auto: (kas 5s.)</p>

    <p id=""live-text"" style=""font-size: 30px; color: white; font-weight: bold;"">0</p>
    <br />
    <p style=""font-size: 30px; color: white; font-weight: bold;"">Manual:</p>
    <p id=""manual-text"" style=""font-size: 30px; color: white; font-weight: bold;"">0</p>

    <div class=""container-login100-form-btn m-t-20"" onclick=""fetchDataManual()"">
        <button class=""login100-form-btn"">
            Atnaujinti
        </button>
    </div>
</div>





<script type=""text/javascript"">
   
    setInterval(function fetchDataAuto() {
        $.ajax({
            url: ""https://localhost:5001/api/wattage/1"",
            //data: JSON.stringify({ device_id: 1 }),
            //contentType: ""application/json; charset=utf-8"",
            //dataType: ""json"",
           ");
            WriteLiteral(@" type: ""GET"",
            success: function (result) {
                //Swal.fire({
                //    icon: 'success',
                //    title: result,
                //    showConfirmButton: true,
                //});
                document.getElementById(""live-text"").innerHTML = result;
            }
        });
    }, 5000); // ms

    function fetchDataManual() {
        $.ajax({
            url: ""https://localhost:5001/api/wattage/1"",
            type: ""GET"",
            success: function (result) {
                document.getElementById(""manual-text"").innerHTML = result;
            }
        });
    }

    window.onload = function fetchDataInitial() {
            $.ajax({
                url: ""https://localhost:5001/api/wattage/1"",
                type: ""GET"",
                success: function (result) {
                    document.getElementById(""manual-text"").innerHTML = result;
                    document.getElementById(""live-text"").innerHTML = result;
  ");
            WriteLiteral("              }\r\n            });\r\n        }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
