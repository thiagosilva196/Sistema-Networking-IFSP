#pragma checksum "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5a30abca5f22188cec89552cf91c1eb74e0fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PedidoAmizade_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PedidoAmizade/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PedidoAmizade/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PedidoAmizade_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5a30abca5f22188cec89552cf91c1eb74e0fcf", @"/Views/Shared/Components/PedidoAmizade/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PedidoAmizade_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.PostModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(101, 514, true);
            WriteLiteral(@"


<div class=""card gedf-card mt-2"">
    <div class=""card-body"">
        <h5 class=""card-title"">Pedido de Amizade</h5>
        <p class=""card-text"">
            <div class=""mr-2"">
                <img class=""rounded-circle"" width=""100"" src=""https://picsum.photos/50/50"" alt="""">
            </div>
        </p>
        <h6 class=""card-subtitle mb-2 text-muted"">Nome usuario</h6>
        <a href=""#"" class=""card-link"">Aceitar</a>
        <a href=""#"" class=""card-link"">Recuser</a>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.PostModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591