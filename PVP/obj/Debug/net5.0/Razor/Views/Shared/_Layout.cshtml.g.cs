#pragma checksum "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7525d85bace05b0095ed190118f91b27c4c21bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7525d85bace05b0095ed190118f91b27c4c21bb", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7525d85bace05b0095ed190118f91b27c4c21bb3360", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>PVP K053</title>
    <link rel=""stylesheet"" href=""/css/site.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/css/main.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7525d85bace05b0095ed190118f91b27c4c21bb5099", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"topnav\" id=\"myTopnav\">\r\n\r\n                <a class=\"navbar-header\" style=\"padding: 0px; padding-top: 2px; margin-right: 30px;\"");
                BeginWriteAttribute("href", " href=\"", 1048, "\"", 1083, 1);
#nullable restore
#line 24 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1055, Url.Action("Index", "Home"), 1055, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div style=\"padding:5px; padding-bottom:5px;\">\r\n                        <img src=\"/images/logo.png\" alt=\"Image\" width=\"150\" height=\"45\">\r\n                    </div>\r\n                </a>\r\n\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1319, "\"", 1352, 1);
#nullable restore
#line 30 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1326, Url.Action("FAQ", "Home"), 1326, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-info-sign\"></span>&nbsp;&nbsp;D.U.K</a>\r\n");
#nullable restore
#line 31 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
                      
                        if (Context.Request.Cookies["jwt"] != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 1578, "\"", 1627, 1);
#nullable restore
#line 34 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1585, Url.Action("DeviceSelect", "Electricity"), 1585, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-stats\"></span>&nbsp;&nbsp;Statistika</a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1734, "\"", 1782, 1);
#nullable restore
#line 35 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1741, Url.Action("Statistics1", "Electricity"), 1741, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-time\"></span>&nbsp;&nbsp;Statistika realiu laiku</a>\r\n");
#nullable restore
#line 36 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
                        }
                        if (Context.Request.Cookies["jwt"] != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 2024, "\"", 2061, 1);
#nullable restore
#line 39 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2031, Url.Action("Devices", "Home"), 2031, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-wrench\"></span>&nbsp;&nbsp;Įrenginiai</a>\r\n                            <a class=\"right-item\"");
                BeginWriteAttribute("href", " href=\"", 2188, "\"", 2224, 1);
#nullable restore
#line 40 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2195, Url.Action("Logout", "Home"), 2195, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-log-out\"></span>&nbsp;&nbsp;Atsijungti</a>\r\n");
#nullable restore
#line 41 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"right-item\"");
                BeginWriteAttribute("href", " href=\"", 2436, "\"", 2471, 1);
#nullable restore
#line 44 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2443, Url.Action("Login", "Home"), 2443, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span>&nbsp;&nbsp;Prisijungti</a>\r\n");
#nullable restore
#line 45 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <a href=""javascript:void(0);"" class=""icon"" onclick=""myFunction()"">
                <i class=""fa fa-bars""></i>
            </a>
        </nav>

    </header>

    <div id=""container-main"" class=""container-main"" style=""background-image: url('images/bg-01.jpg');"">
        <div>
            ");
#nullable restore
#line 56 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>

    <div id=""container-footer"" class=""container-footer"" style=""background-image: url('images/bg-01.jpg');"">
        <footer id=""footer"" class=""footer"">
            <div class=""copyright"">
                <p class=""alignleft""><strong></strong></p>
                <p class=""aligncenter""><strong>K053</strong></p>
                <p class=""alignright""><strong>&copy; 2022 KTU</strong></p>
            </div>
        </footer>
    </div>

");
                WriteLiteral("\r\n    ");
#nullable restore
#line 72 "C:\Users\gladi\Desktop\PVP4\PVP\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
        function myFunction() {
            var x = document.getElementById(""myTopnav"");
            if (x.className === ""topnav"") {
                x.className += "" responsive"";
            }
            else {
                        x.className = ""topnav"";
            }
}
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
