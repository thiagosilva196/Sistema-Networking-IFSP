#pragma checksum "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a2d9b244552f9da3f79ea269a77b9d75936e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ConteudoVaga_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ConteudoVaga/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ConteudoVaga/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ConteudoVaga_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a2d9b244552f9da3f79ea269a77b9d75936e95", @"/Views/Shared/Components/ConteudoVaga/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ConteudoVaga_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Vaga>>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(115, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(121, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093bca7111ee49418627c9fa3713e076", async() => {
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
                BeginContext(165, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(170, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
 foreach (var item in Model.Reverse())
{

#line default
#line hidden
            BeginContext(217, 298, true);
            WriteLiteral(@" <div class=""card gedf-card"">
    <div class=""card-header"">
        <div class=""d-flex justify-content-between align-items-center"">
            <div class=""d-flex justify-content-between align-items-center"">
        
                <div class=""ml-2"">
                    <div class=""h5 m-0"">");
            EndContext();
            BeginContext(516, 11, false);
#line 20 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(527, 945, true);
            WriteLiteral(@"</div>
                </div>
            </div>
            <div>
                <div class=""dropdown"">
                    <button class=""btn btn-link dropdown-toggle"" type=""button"" id=""gedf-drop1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fa fa-ellipsis-h""></i>
                    </button>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""gedf-drop1"">
                        <div class=""h6 dropdown-header"">Configuration</div>
                        <a class=""dropdown-item"" href=""#"">Save</a>
                        <a class=""dropdown-item"" href=""#"">Hide</a>
                        <a class=""dropdown-item"" href=""#"">Report</a>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class=""card-body"">
        <div class=""text-muted h7 mb-2""> <i class=""fa fa-clock-o""></i>");
            EndContext();
            BeginContext(1473, 46, false);
#line 40 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
                                                                 Write(item.DataPostagem.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 51, true);
            WriteLiteral("</div>\r\n        <p class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(1571, 13, false);
#line 42 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
       Write(item.Conteudo);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 258, true);
            WriteLiteral(@"
        </p>
       

    </div>
    <div class=""card-footer"">
        <a href=""#"" class=""card-link""><i class=""fa fa-gittip""></i> Candidatar-se</a>
        <a href=""#"" class=""card-link""><i class=""fa fa-comment""></i> Comentar</a>
    </div>
</div>
");
            EndContext();
#line 52 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"


}

#line default
#line hidden
            BeginContext(1849, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.Vaga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
