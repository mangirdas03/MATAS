#pragma checksum "C:\Users\gladi\Desktop\PVP\PVP\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463a0dace6d36862ab06505e84693e89f230c64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463a0dace6d36862ab06505e84693e89f230c64c", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463a0dace6d36862ab06505e84693e89f230c64c3858", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""icon"" type=""image/png"" href=""/images/icons/favicon.ico"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/fonts/iconic/css/material-design-iconic-font.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/vendor/animate/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/vendor/css-hamburgers/hamburgers.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/vendor/animsition/css/animsition.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/vendor/select2/select2.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/vendor/daterangepicker/daterangepicker.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/main.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463a0dace6d36862ab06505e84693e89f230c64c5855", async() => {
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("        <div class=\"wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463a0dace6d36862ab06505e84693e89f230c64c6237", async() => {
                    WriteLiteral(@"
                <span class=""login100-form-title p-b-37"">
                    Prisijungimas
                </span>

                <div class=""wrap-input100 validate-input m-b-20"" data-validate=""Enter username or email"">
                    <input class=""input100"" type=""text"" name=""username"" placeholder=""Prisijungimo vardas"">
                    <span class=""focus-input100""></span>
                </div>

                <div class=""wrap-input100 validate-input m-b-25"" data-validate=""Enter password"">
                    <input class=""input100"" type=""password"" name=""pass"" placeholder=""Slaptažodis"">
                    <span class=""focus-input100""></span>
                </div>
                <div class=""text-center"">
                    <a href=""#"" class=""txt2 hov1"">
                        Pamiršote slaptažodį?
                    </a>
                </div>
                <div class=""container-login100-form-btn"">
                    <button class=""login100-form-btn"">
               ");
                    WriteLiteral(@"         Prisijungti
                    </button>
                </div>
                <div class=""container-login100-form-btn"" style=""margin-top:40px;"">
                    <button class=""login100-form-btn"">
                        Neturite paskyros?<br>Užsiregistruoti
                    </button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n        </div>\r\n");
                WriteLiteral(@"


    <!--===============================================================================================-->
    <script src=""/vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/vendor/bootstrap/js/popper.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/vendor/daterangepicker/moment.min.js""></script>
    <script src=""/vendor/daterangepicker/daterangepicker.js""></script>
    <!--===========");
                WriteLiteral(@"====================================================================================-->
    <script src=""/vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->
    <script src=""/js/main.js""></script>

");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
