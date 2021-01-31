#pragma checksum "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3d1d6e8dc6f2ca49143505436c818036a79b07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Perfil), @"mvc.1.0.view", @"/Views/Usuarios/Perfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Perfil.cshtml", typeof(AspNetCore.Views_Usuarios_Perfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3d1d6e8dc6f2ca49143505436c818036a79b07", @"/Views/Usuarios/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Usuario.Nome + " " + Model.Usuario.Sobrenome;
    string curso = Model.Usuario.Curso;
    string email = Model.Usuario.Email;
    string nascimento = Model.Usuario.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.Usuario.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.Usuario.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(455, 162, true);
            WriteLiteral("\n<h2>Perfil</h2>\n\n\n\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\n    <div class=\"w3-container\">\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(618, 7, false);
#line 17 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(625, 133, true);
            WriteLiteral("</b></h3></div>\n        <p class=\"w3-center\">\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 758, "\"", 829, 1);
#line 20 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue(" ", 764, @imagemPerfil == null ? "/images/avatar2.png" : @imagemPerfil, 765, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 506, true);
            WriteLiteral(@" class=""w3-circle imagemPerfil"" alt=""Avatar"" id=""imagemPerfilAlterar"">
                <div class=""overlay"">
                    <a href=""#"" class=""icon"" title=""User Profile"">
                        <i class=""fa fa-camera""></i>
                    </a>
                </div>
                <input type=""file"" name=""uploadFotoPerfil"" class=""d-none"" accept=""image/png, image/jpeg"" id=""campoUploadImagem"" />
            </div>
        </p>
        <div class=""formAlterarImagemUsuario d-none"">
            ");
            EndContext();
            BeginContext(1336, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94fc922845a4a1383ae1c484dc1637e", async() => {
                BeginContext(1379, 86, true);
                WriteLiteral("\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1465, "\"", 1505, 1);
#line 31 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 1473, Model.Usuario.ProfilePictureUrl, 1473, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1506, 16, true);
                WriteLiteral(" />\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1529, 130, true);
            WriteLiteral("\n        </div>\n        <hr>\n        <p>\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de ");
            EndContext();
            BeginContext(1660, 5, false);
#line 36 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                                    Write(curso);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 106, true);
            WriteLiteral("\n        </p>\n\n        <p>\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1772, 5, false);
#line 40 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1777, 110, true);
            WriteLiteral("\n        </p>\n        <p>\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1888, 10, false);
#line 43 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                               Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 22, true);
            WriteLiteral("\n        </p>\n        ");
            EndContext();
            BeginContext(1921, 71, false);
#line 45 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
   Write(await Component.InvokeAsync("Curriculo", new { id = Model.Usuario.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 155, true);
            WriteLiteral("\n    </div><br />\n</div>\n\n</div>\n<br />\n\n<li class=\"list-group-item\">\n    <div class=\"h5 text-muted\">Conhecimentos e Recomendações</div>\n    <div>\n        ");
            EndContext();
            BeginContext(2148, 60, false);
#line 55 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
   Write(await Component.InvokeAsync("Habilidades", Model.Usuario.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 20, true);
            WriteLiteral("\n    </div>\n</li>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2245, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2250, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76fe5b07294348788c9ee7df59d918be", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2294, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
