#pragma checksum "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23dbabc203d73f8cdc0380abf637d284d207a840"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23dbabc203d73f8cdc0380abf637d284d207a840", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515599754656d7c7b5946e8eeb61be2ba9152c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PVP.ViewModels.LoginDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Mail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Prisijungimo vardas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Slaptažodis"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("loginform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Prisijungimas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23dbabc203d73f8cdc0380abf637d284d207a8407388", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23dbabc203d73f8cdc0380abf637d284d207a8409385", async() => {
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("    <div class=\"wrap-login100 p-l-55 p-r-55 p-t-50 p-b-30\">\r\n        ");
#nullable restore
#line 26 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23dbabc203d73f8cdc0380abf637d284d207a8409984", async() => {
                    WriteLiteral("\r\n            <span class=\"login100-form-title p-b-40\">\r\n                Prisijungimas\r\n            </span>\r\n\r\n            <div class=\"wrap-input100 m-b-15\">\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23dbabc203d73f8cdc0380abf637d284d207a84010437", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mail);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                <span class=\"focus-input100\"></span>\r\n            </div>\r\n\r\n            <div class=\"wrap-input100 m-b-10\">\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23dbabc203d73f8cdc0380abf637d284d207a84012727", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                <span class=""focus-input100""></span>
            </div>
            <div class=""text-center"" style=""margin-bottom: 5px;"">
                <a href=""#"" class=""txt2 hov1"" style=""font-size:12px;"">
                    Pamiršote slaptažodį?
                </a>
            </div>
            <div class=""container-login100-form-btn m-t-15"" type=""submit"" onclick=""validateLogin(event)"">
                <button class=""login100-form-btn"">
                    Prisijungti
                </button>
            </div>

");
                    WriteLiteral("\r\n            <div class=\"text-center-small m-t-35\">\r\n                <p>Neturite paskyros?</p>\r\n            </div>\r\n            <div class=\"container-login100-form-btn\">\r\n                <a class=\"login100-form-btn\"");
                    BeginWriteAttribute("href", " href=\"", 2760, "\"", 2798, 1);
#nullable restore
#line 60 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
WriteAttributeValue("", 2767, Url.Action("Register", "Home"), 2767, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    Užsiregistruoti\r\n                </a>\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n");
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
    <script>
        function validateLogin(event) {
            event.preventDefault();

            let field1 = document.forms[""loginform""][""Mail""].value;
            let field2 = document.forms[""loginform""][""Password""].value;
            if (field1 == """" || field2 == """") {
                Swal.fire({
                    icon: 'error',
                    buttonsStyling: false,
                    title: 'Užpildykite visus laukus!',
                    showConfirmButton: false,
                    confirmButtonColor: '#bd59d4',
                    html: '<br><div class=\""container-login100-form-btn\""><button class= \""login100-form-btn\"" id=\""swal-custom-button\"">Gerai</button></div><br><br><br");
                WriteLiteral(">\'\r\n                })\r\n                return false;\r\n            }\r\n            else\r\n                document.getElementById(\"loginform\").submit();\r\n        }\r\n        $(document).ready(function () {\r\n            var errorPrompt = \'");
#nullable restore
#line 109 "C:\Users\gladi\Desktop\PVP3\PVP\Views\Home\Login.cshtml"
                          Write(ViewBag.PromptMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            if (errorPrompt == 'invalidCredentials') {
                Swal.fire({
                    icon: 'error',
                    buttonsStyling: false,
                    title: 'Blogas prisijungimo vardas arba slaptažodis!',
                    showConfirmButton: false,
                    confirmButtonColor: '#bd59d4',
                    html: '<br><div class=\""container-login100-form-btn\""><button class= \""login100-form-btn\"" id=\""swal-custom-button\"">Gerai</button></div><br><br><br>'
                })
            }
        });
        $(document).on('click', '#swal-custom-button', function () {
            swal.clickConfirm();
        });
    </script>
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PVP.ViewModels.LoginDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
