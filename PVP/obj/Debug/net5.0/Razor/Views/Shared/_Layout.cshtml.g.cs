#pragma checksum "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a20d5e00177d1a72eea7a53d19dca4d171ae287"
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
#line 1 "C:\Users\gladi\Desktop\PVP\PVP\Views\_ViewImports.cshtml"
using PVP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gladi\Desktop\PVP\PVP\Views\_ViewImports.cshtml"
using PVP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a20d5e00177d1a72eea7a53d19dca4d171ae287", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a20d5e00177d1a72eea7a53d19dca4d171ae2873883", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>PVP K053</title>
    <link rel=""stylesheet"" href=""/css/site.css"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a20d5e00177d1a72eea7a53d19dca4d171ae2875423", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-default navbar-fixed-top"" style=""margin-bottom: 0px;"">
            <div class=""container-fluid"">
                <div class=""navbar-header"">
                    <a class=""navbar-brand"" href=""#"">K053 Logo</a>
                </div>
                <ul class=""nav navbar-nav navbar-left"">
                    <li><a");
                BeginWriteAttribute("href", " href=\"", 1066, "\"", 1101, 1);
#nullable restore
#line 24 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1073, Url.Action("Index", "Home"), 1073, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Pradžia</a></li>\r\n                    <li><a href=\"#\">Page 1</a></li>\r\n                    <li><a href=\"#\">Page 2</a></li>\r\n                </ul>\r\n");
                WriteLiteral("            <ul class=\"nav navbar-nav navbar-right\">\r\n");
#nullable restore
#line 34 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
                  
                    if (Context.Request.Cookies["jwt"] != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a href=\"#\"><span class=\"glyphicon glyphicon-user\"></span> Nustatymai</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1813, "\"", 1849, 1);
#nullable restore
#line 38 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1820, Url.Action("Logout", "Home"), 1820, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-log-out\"></span> Atsijungti</a></li>\r\n");
#nullable restore
#line 39 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2024, "\"", 2059, 1);
#nullable restore
#line 42 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2031, Url.Action("Login", "Home"), 2031, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-log-in\"></span> Prisijungti</a></li>\r\n");
#nullable restore
#line 43 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    <div id=\"container-main\" class=\"container-main\" style=\"background-image: url(\'images/bg-01.jpg\');\">\r\n        <div>\r\n            ");
#nullable restore
#line 52 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a20d5e00177d1a72eea7a53d19dca4d171ae2879428", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 68 "C:\Users\gladi\Desktop\PVP\PVP\Views\Shared\_Layout.cshtml"
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
            WriteLiteral("\r\n</html>\r\n");
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
