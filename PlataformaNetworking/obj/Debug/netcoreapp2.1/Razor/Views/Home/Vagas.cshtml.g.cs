#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e92ac2940f9b7861514dde215738b1f43d3c68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vagas), @"mvc.1.0.view", @"/Views/Home/Vagas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Vagas.cshtml", typeof(AspNetCore.Views_Home_Vagas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e92ac2940f9b7861514dde215738b1f43d3c68", @"/Views/Home/Vagas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vagas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
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
#line 2 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
  
    ViewData["Title"] = "Vagas";
    //string uploadimagem = Model.UploadPictureUrl == null ? "~/images/avatar3.png" : Model.UploadPictureUrl;

#line default
#line hidden
            BeginContext(196, 363, true);
            WriteLiteral(@"

<!-- Page Container -->
<div class=""container-fluid gedf-wrapper mt-3"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""card"">
                <div class=""card-body"">

                    <p class=""w3-center"">
                        <div class="" containerPerfil"" id=""triggerUploadClick"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 559, "\"", 650, 1);
#line 17 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
WriteAttributeValue("", 565, Model.ProfilePictureUrl == null ? "~/images/avatar2.png" : Model.ProfilePictureUrl, 565, 85, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(651, 641, true);
            WriteLiteral(@" class=""rounded-circle imagemPerfil"" alt=""Avatar"" id=""imagemPerfilAlterar"">
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
            BeginContext(1292, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "085d80b8204b4111af091f00f6987ec8", async() => {
                BeginContext(1335, 99, true);
                WriteLiteral("\r\n                            <input name=\"ProfilePictureUrl\" id=\"campoInputNovaImagem\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1434, "\"", 1466, 1);
#line 28 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
WriteAttributeValue("", 1442, Model.ProfilePictureUrl, 1442, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1467, 29, true);
                WriteLiteral(" />\r\n                        ");
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
            BeginContext(1503, 66, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"h5\">");
            EndContext();
            BeginContext(1570, 10, false);
#line 31 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                               Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1582, 15, false);
#line 31 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                           Write(Model.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 55, true);
            WriteLiteral("</div>\r\n                    <div class=\"h7 text-muted\">");
            EndContext();
            BeginContext(1653, 20, false);
#line 32 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                          Write(Model.GetType().Name);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 48, true);
            WriteLiteral("</div>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1722, 37, false);
#line 34 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
           Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6 gedf-main\">\r\n\r\n\r\n\r\n");
            EndContext();
#line 41 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              

                if (Model.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(1959, 45, false);
#line 45 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("PublicacaoVaga"));

#line default
#line hidden
            EndContext();
#line 45 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                  
                }
            

#line default
#line hidden
            BeginContext(2040, 51, true);
            WriteLiteral("\r\n\r\n            <!--chamar View component aqui-->\r\n");
            EndContext();
#line 51 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              
                if (Model.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(2203, 50, false);
#line 54 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaEmpresa"));

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                       
                }

                else if (Model.GetType().Name == "Aluno")
                {
                    

#line default
#line hidden
            BeginContext(2375, 48, false);
#line 59 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaAluno"));

#line default
#line hidden
            EndContext();
#line 59 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                     
                }
            

#line default
#line hidden
            BeginContext(2459, 116, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3 justify-content\">\r\n            <!--Pedido de Amizade-->\r\n            ");
            EndContext();
            BeginContext(2576, 44, false);
#line 66 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
       Write(await Component.InvokeAsync("PedidoAmizade"));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2679, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2685, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3df6d44268794628ba8fb772dd95221b", async() => {
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
                BeginContext(2729, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
