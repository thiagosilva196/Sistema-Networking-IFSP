#pragma checksum "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f85707e96b43a2e2ab073909ea81e5fb77f9bd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Painel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Painel/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Painel/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Painel_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f85707e96b43a2e2ab073909ea81e5fb77f9bd9", @"/Views/Shared/Components/Painel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Painel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formNewHabilidade"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(41, 75, true);
            WriteLiteral("\n<ul class=\"list-group list-group-flush\">\n    <li class=\"list-group-item\">\n");
            EndContext();
#line 8 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
          
            if (Model.Usuario.GetType().Name == "Aluno" || Model.Usuario.GetType().Name == "Empresa")
            {

#line default
#line hidden
            BeginContext(243, 56, true);
            WriteLiteral("                <div class=\"h6 text-muted\">Painel</div>\n");
            EndContext();
            BeginContext(300, 40, true);
            WriteLiteral("                <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 340, "\"", 375, 1);
#line 13 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
WriteAttributeValue("", 347, Url.Action("Vagas", "Home"), 347, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 918, true);
            WriteLiteral(@">
                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-book"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" d=""M1 2.828v9.923c.918-.35 2.107-.692 3.287-.81 1.094-.111 2.278-.039 3.213.492V2.687c-.654-.689-1.782-.886-3.112-.752-1.234.124-2.503.523-3.388.893zm7.5-.141v9.746c.935-.53 2.12-.603 3.213-.493 1.18.12 2.37.461 3.287.811V2.828c-.885-.37-2.154-.769-3.388-.893-1.33-.134-2.458.063-3.112.752zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"" />
                    </svg>
                    Vagas
                </a>
");
            EndContext();
#line 19 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
            }

            if (Model.Usuario.GetType().Name == "Aluno")
            {

#line default
#line hidden
            BeginContext(1380, 40, true);
            WriteLiteral("                <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1462, 1);
#line 23 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
WriteAttributeValue("", 1427, Url.Action("Candidaturas", "Home"), 1427, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1463, 476, true);
            WriteLiteral(@">
                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-bookmark"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" d=""M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z"" />
                    </svg>
                    Candidaturas
                </a>
");
            EndContext();
#line 29 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1963, 26, true);
            WriteLiteral("\n</ul>\n\n\n\n<!--Add aqui-->\n");
            EndContext();
#line 37 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
  
    if (Model.Usuario.GetType().Name == "Aluno")
    {

#line default
#line hidden
            BeginContext(2047, 145, true);
            WriteLiteral("    <li class=\"list-group-item\">\n        <div class=\"h5 text-muted\">Meus Conhecimentos e Recomendações</div>\n\n        \n        <div>\n            ");
            EndContext();
            BeginContext(2193, 42, false);
#line 45 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
       Write(await Component.InvokeAsync("Habilidades"));

#line default
#line hidden
            EndContext();
            BeginContext(2235, 129, true);
            WriteLiteral("\n            <span class=\"badge badge-dark\" id=\"adicionarHabilidade\">+</span>\n            <div class=\"row mt-2\">\n                ");
            EndContext();
            BeginContext(2364, 428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a86a9ebd4492459a97cd6118a81f262d", async() => {
                BeginContext(2428, 357, true);
                WriteLiteral(@"
                    <div class=""col-md-5"">
                        <input type=""text"" class=""form-control"" name=""NomeHabilidade"" id=""NomeHabilidade"" />
                    </div>
                    <div class=""col-md-3"">
                        <button type=""submit"" class=""btn btn-secondary"">Adicionar</button>
                    </div>
                ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2792, 155, true);
            WriteLiteral("\n            </div>\n        </div>\n        <script>\n            $(\"#adicionarHabilidade\").css(\"cursor\", \"pointer\");\n        </script>\n        \n\n\n    </li>\n");
            EndContext();
#line 65 "C:\Users\lucas\Documents\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Painel\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(2955, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
