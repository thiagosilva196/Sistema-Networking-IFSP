#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b78671d5ad39a97cc0f718a1eaa2a7d2f454bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_MeuPerfil), @"mvc.1.0.view", @"/Views/Usuarios/MeuPerfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/MeuPerfil.cshtml", typeof(AspNetCore.Views_Usuarios_MeuPerfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b78671d5ad39a97cc0f718a1eaa2a7d2f454bc", @"/Views/Usuarios/MeuPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MeuPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadCurriculo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Aluno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Usuario.Nome + " " + Model.Usuario.Sobrenome;
    string curso = Model.Usuario.Curso;
    string email = Model.Usuario.Email;
    string nascimento = Model.Usuario.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.Usuario.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.Usuario.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(464, 77, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n<div class=\"col-md-3\">\r\n    <div class=\"card\">\r\n        ");
            EndContext();
            BeginContext(542, 37, false);
#line 15 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
   Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 168, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\r\n    <div class=\"w3-container\">\r\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(748, 7, false);
#line 21 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(755, 136, true);
            WriteLiteral("</b></h3></div>\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 891, "\"", 910, 1);
#line 24 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 897, imagemPerfil, 897, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(911, 516, true);
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
            BeginContext(1427, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f27d6686404407cb1b67dbef3090a5b", async() => {
                BeginContext(1470, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1557, "\"", 1597, 1);
#line 35 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
WriteAttributeValue("", 1565, Model.Usuario.ProfilePictureUrl, 1565, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1598, 17, true);
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
            BeginContext(1622, 134, true);
            WriteLiteral("\r\n        </div>\r\n        <hr>\r\n        <p>\r\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de ");
            EndContext();
            BeginContext(1757, 5, false);
#line 40 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                    Write(curso);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 112, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <p>\r\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\">Email: ");
            EndContext();
            BeginContext(1875, 5, false);
#line 44 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                            Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1880, 132, true);
            WriteLiteral("</i>\r\n        </p>\r\n        <p>\r\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\">Data de nascimento: ");
            EndContext();
            BeginContext(2013, 10, false);
#line 47 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                              Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 36, true);
            WriteLiteral(" </i>\r\n        </p>\r\n        <p>\r\n\r\n");
            EndContext();
#line 51 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
              
                if (Model.Usuario.GetType().Name == "Aluno")
                {
                    

#line default
#line hidden
            BeginContext(2177, 71, false);
#line 54 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
               Write(await Component.InvokeAsync("Curriculo", new { id = Model.Usuario.Id }));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                                                                                            ;
                }
            

#line default
#line hidden
            BeginContext(2285, 138, true);
            WriteLiteral("\r\n        </p>\r\n\r\n    </div><br />\r\n    <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">Editar</button><br />\r\n");
            EndContext();
#line 62 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
      
        if (Model.Usuario.GetType().Name == "Aluno")
        {

#line default
#line hidden
            BeginContext(2496, 128, true);
            WriteLiteral("            <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCurriculo\">Adicionar Curriculo</button><br />\r\n");
            EndContext();
#line 66 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
        }
    

#line default
#line hidden
            BeginContext(2642, 134, true);
            WriteLiteral("\r\n\r\n<!-- The Modal -->\r\n<div class=\"modal fade\" id=\"myModal\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n\r\n");
            EndContext();
#line 75 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2848, 261, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(3128, 23, false);
#line 83 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3153, 186, true);
            WriteLiteral("                <!-- Modal body -->\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-horizontal\">\r\n                        <hr />\r\n                        ");
            EndContext();
            BeginContext(3340, 64, false);
#line 88 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3404, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3431, 41, false);
#line 89 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                   Write(Html.HiddenFor(model => model.Usuario.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3472, 82, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3555, 101, false);
#line 92 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3656, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3744, 101, false);
#line 94 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3845, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3880, 90, false);
#line 95 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3970, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4121, 106, false);
#line 100 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4227, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4315, 106, false);
#line 102 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4421, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4456, 95, false);
#line 103 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4551, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4702, 102, false);
#line 108 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Curso, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4804, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4892, 102, false);
#line 110 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Curso, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4994, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5029, 91, false);
#line 111 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Curso, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5120, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5271, 102, false);
#line 116 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5373, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(5461, 102, false);
#line 118 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5563, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5598, 91, false);
#line 119 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5689, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5840, 111, false);
#line 124 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                       Write(Html.LabelFor(model => model.Usuario.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5951, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(6039, 111, false);
#line 126 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.EditorFor(model => model.Usuario.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6150, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6185, 100, false);
#line 127 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Usuario.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6285, 445, true);
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
#line 140 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\MeuPerfil.cshtml"
            }

#line default
#line hidden
            BeginContext(6745, 534, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""modal fade"" id=""addCurriculo"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Editar Usuário</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <div class=""form-horizontal"">
                    ");
            EndContext();
            BeginContext(7279, 341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90afe70139ab4e2d9979fe9e69a0e159", async() => {
                BeginContext(7381, 97, true);
                WriteLiteral("\r\n                        <input type=\"file\" name=\"arquivo\" required />\r\n                        ");
                EndContext();
                BeginContext(7478, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "787b662ff751417eadfaebdc9278f6c4", async() => {
                    BeginContext(7576, 6, true);
                    WriteLiteral("Salvar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7591, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7620, 131, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <!-- Modal footer -->\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7768, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7774, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d2fc0b2c264a758dfb41f917e2cc68", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7818, 520, true);
                WriteLiteral(@"
    <script>
        function SolicitaAmizade() {
            $('body').on('submit', '#formAmizade', function (evt) {
                evt.preventDefault();
                $.ajax({
                    url: '/Usuarios/SolicitaAmizade',
                    type: 'post',
                    data: $('#formAmizade').serialize(),
                    success: function () {
                        document.location.reload();
                    }
                });
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(8341, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
