#pragma checksum "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56ec2f9058d84ea2c456ce66059b38b19ba8b97"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56ec2f9058d84ea2c456ce66059b38b19ba8b97", @"/Views/Usuarios/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
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
#line 2 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Nome + " " + Model.Sobrenome;
    ///string curso = Model.Curso;
    string email = Model.Email;
    string nascimento = Model.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(394, 165, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\r\n    <div class=\"w3-container\">\r\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(560, 7, false);
#line 15 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(567, 136, true);
            WriteLiteral("</b></h3></div>\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 703, "\"", 722, 1);
#line 18 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 709, imagemPerfil, 709, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(723, 516, true);
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
            BeginContext(1239, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4f165e951964c4d9f20bdd6df79dc65", async() => {
                BeginContext(1282, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1369, "\"", 1401, 1);
#line 29 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 1377, Model.ProfilePictureUrl, 1377, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1402, 17, true);
                WriteLiteral(" />\r\n            ");
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
            BeginContext(1426, 244, true);
            WriteLiteral("\r\n        </div>\r\n        <hr>\r\n        <p>\r\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de \r\n        </p>\r\n\r\n        <p>\r\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1671, 5, false);
#line 38 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1676, 113, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1790, 10, false);
#line 41 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                               Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 280, true);
            WriteLiteral(@"
        </p>
        
    </div><br />
    <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">Editar</button>
</div>

<!-- The Modal -->
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

");
            EndContext();
#line 53 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2152, 261, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(2432, 23, false);
#line 61 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2457, 186, true);
            WriteLiteral("                <!-- Modal body -->\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-horizontal\">\r\n                        <hr />\r\n                        ");
            EndContext();
            BeginContext(2644, 64, false);
#line 66 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2708, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2735, 33, false);
#line 67 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 82, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2851, 93, false);
#line 70 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2944, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3032, 93, false);
#line 72 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3125, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3160, 82, false);
#line 73 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3393, 98, false);
#line 78 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3491, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3579, 98, false);
#line 80 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3677, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3712, 87, false);
#line 81 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3799, 72, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n");
            EndContext();
            BeginContext(4418, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4499, 94, false);
#line 94 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4593, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4681, 94, false);
#line 96 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4775, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4810, 83, false);
#line 97 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4893, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5044, 103, false);
#line 102 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5147, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(5235, 103, false);
#line 104 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5338, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5373, 92, false);
#line 105 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5465, 445, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <!-- Modal footer -->
                    <div class=""modal-footer"">
                        <input type=""submit"" value=""Salvar"" class=""btn btn-primary"" />
                        <input type=""button"" value=""Cancelar"" class=""btn btn-danger"" data-dismiss=""modal"" />

                    </div>

                </div>
");
            EndContext();
#line 118 "C:\Users\lele\Desktop\LinkedIF\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
            }

#line default
#line hidden
            BeginContext(5925, 30, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5976, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5986, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51fdfa44c989416d8b576c9bcaceb4c1", async() => {
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
                BeginContext(6030, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            BeginContext(6039, 10, true);
            WriteLiteral("    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
