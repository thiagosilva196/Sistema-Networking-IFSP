#pragma checksum "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3667e690da0639fce09e490f9374049ee107d3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3667e690da0639fce09e490f9374049ee107d3", @"/Views/Home/Vagas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vagas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/uploadImagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
  
    ViewData["Title"] = "Vagas";
    //string uploadimagem = Model.UploadPictureUrl == null ? "~/images/avatar3.png" : Model.UploadPictureUrl;

#line default
#line hidden
            BeginContext(213, 181, true);
            WriteLiteral("\r\n\r\n<!-- Page Container -->\r\n<div class=\"container-fluid gedf-wrapper mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"card\">\r\n                ");
            EndContext();
            BeginContext(395, 38, false);
#line 13 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
           Write(await Component.InvokeAsync("Usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(433, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(452, 37, false);
#line 14 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
           Write(await Component.InvokeAsync("Painel"));

#line default
#line hidden
            EndContext();
            BeginContext(489, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6 gedf-main\">\r\n\r\n\r\n\r\n");
            EndContext();
#line 21 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              

                if (Model.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(689, 45, false);
#line 25 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("PublicacaoVaga"));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                  
                }
            

#line default
#line hidden
            BeginContext(770, 51, true);
            WriteLiteral("\r\n\r\n            <!--chamar View component aqui-->\r\n");
            EndContext();
#line 31 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
              
                if (Model.GetType().Name == "Empresa")
                {
                    

#line default
#line hidden
            BeginContext(933, 50, false);
#line 34 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaEmpresa"));

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                       
                }

                else if (Model.GetType().Name == "Aluno")
                {
                    

#line default
#line hidden
            BeginContext(1105, 48, false);
#line 39 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
               Write(await Component.InvokeAsync("ConteudoVagaAluno"));

#line default
#line hidden
            EndContext();
#line 39 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
                                                                     
                }
            

#line default
#line hidden
            BeginContext(1189, 116, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3 justify-content\">\r\n            <!--Pedido de Amizade-->\r\n            ");
            EndContext();
            BeginContext(1306, 44, false);
#line 46 "C:\Users\lucas\Source\Repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Home\Vagas.cshtml"
       Write(await Component.InvokeAsync("PedidoAmizade"));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1409, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1415, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a6d19011e08467b83c8a4e943693606", async() => {
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
                EndContext();
                BeginContext(1459, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
