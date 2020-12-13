#pragma checksum "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b358b52519c4512329aa7be2d51833af5c259d27"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b358b52519c4512329aa7be2d51833af5c259d27", @"/Views/Usuarios/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAlterarImagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAmizade"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    string usuario = Model.Nome + " " + Model.Sobrenome;
    string curso = Model.Curso;
    string email = Model.Email;
    string nascimento = Model.DataNascimento.ToString("MM/dd/yyyy");
    string imagemPerfil = Model.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.ProfilePictureUrl;

#line default
#line hidden
            BeginContext(391, 165, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n<div class=\"w3-card w3-round w3-white col-lg-6\" style=\"padding: 20px;\">\r\n    <div class=\"w3-container\">\r\n        <div class=\"w3-content\"><h3><b>");
            EndContext();
            BeginContext(557, 7, false);
#line 15 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                  Write(usuario);

#line default
#line hidden
            EndContext();
            BeginContext(564, 136, true);
            WriteLiteral("</b></h3></div>\r\n        <p class=\"w3-center\">\r\n            <div class=\" containerPerfil\" id=\"triggerUploadClick\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 700, "\"", 719, 1);
#line 18 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 706, imagemPerfil, 706, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(720, 516, true);
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
            BeginContext(1236, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e9da6fd5b9b4c9fa3ce9b8db03580a8", async() => {
                BeginContext(1279, 87, true);
                WriteLiteral("\r\n                <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1366, "\"", 1398, 1);
#line 29 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 1374, Model.ProfilePictureUrl, 1374, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1399, 17, true);
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
            BeginContext(1423, 134, true);
            WriteLiteral("\r\n        </div>\r\n        <hr>\r\n        <p>\r\n            <i class=\"fa fa-pencil fa-fw w3-margin-right w3-text-theme\"></i>Estudante de ");
            EndContext();
            BeginContext(1558, 5, false);
#line 34 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                                    Write(curso);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 110, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <p>\r\n            <i class=\"fa fa-envelope fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1674, 5, false);
#line 38 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                          Write(email);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 113, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <i class=\"fa fa-birthday-cake fa-fw w3-margin-right w3-text-theme\"></i> ");
            EndContext();
            BeginContext(1793, 10, false);
#line 41 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                                                                               Write(nascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 40, true);
            WriteLiteral("\r\n        </p>\r\n\r\n    </div><br />\r\n    ");
            EndContext();
            BeginContext(1843, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e680e28e7098404f99bcede60fcf1b6f", async() => {
                BeginContext(1880, 64, true);
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"IdUsuario2\" name=\"IdUsuario2\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1944, "\"", 1961, 1);
#line 46 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
WriteAttributeValue("", 1952, Model.Id, 1952, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1962, 119, true);
                WriteLiteral(" />\r\n        <button onclick=\"SolicitaAmizade()\" type=\"submit\" class=\"btn btn-primary\">Solicitar Amizade</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2088, 29, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Amigos</h2>\r\n");
            EndContext();
            BeginContext(2118, 48, false);
#line 52 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
Write(await Component.InvokeAsync("Amizade", Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 134, true);
            WriteLiteral("\r\n\r\n<!-- The Modal -->\r\n<div class=\"modal fade\" id=\"myModal\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n\r\n");
            EndContext();
#line 59 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
             using (Html.BeginForm("Edit", "Usuarios"))
            {

#line default
#line hidden
            BeginContext(2372, 261, true);
            WriteLiteral(@"                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Editar Usuário</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                </div>
");
            EndContext();
            BeginContext(2652, 23, false);
#line 67 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2677, 186, true);
            WriteLiteral("                <!-- Modal body -->\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-horizontal\">\r\n                        <hr />\r\n                        ");
            EndContext();
            BeginContext(2864, 64, false);
#line 72 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2928, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2955, 33, false);
#line 73 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2988, 82, true);
            WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3071, 93, false);
#line 76 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3164, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3252, 93, false);
#line 78 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3345, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3380, 82, false);
#line 79 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3462, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3613, 98, false);
#line 84 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Sobrenome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(3799, 98, false);
#line 86 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Sobrenome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3897, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3932, 87, false);
#line 87 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Sobrenome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4019, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4170, 94, false);
#line 92 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Curso, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4264, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4352, 94, false);
#line 94 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Curso, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4446, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4481, 83, false);
#line 95 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Curso, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4564, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4715, 94, false);
#line 100 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4809, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(4897, 94, false);
#line 102 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4991, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5026, 83, false);
#line 103 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5109, 150, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5260, 103, false);
#line 108 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                       Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5363, 87, true);
            WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
            EndContext();
            BeginContext(5451, 103, false);
#line 110 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.EditorFor(model => model.DataNascimento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5554, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5589, 92, false);
#line 111 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
                           Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5681, 445, true);
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
#line 124 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Perfil.cshtml"
            }

#line default
#line hidden
            BeginContext(6141, 30, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6192, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6202, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3468998209b44d1f94e9fc6fa5010849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6246, 584, true);
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
            BeginContext(6833, 6, true);
            WriteLiteral("</div>");
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
