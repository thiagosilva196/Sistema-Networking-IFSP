#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31d0346d01973899e5522553ac27215596cbc9f9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d0346d01973899e5522553ac27215596cbc9f9", @"/Views/Shared/Components/PedidoAmizade/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PedidoAmizade_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.ViewModels.HomeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(116, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
  
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(164, 285, true);
            WriteLiteral(@"        <div class=""card gedf-card mt-2"">
            <div class=""card-body"">
                <h5 class=""card-title"">Pedido de Amizade</h5>
                <p class=""card-text"">
                    <div class=""mr-2"">
                        <img class=""rounded-circle"" width=""100""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 449, "\"", 486, 1);
#line 16 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
WriteAttributeValue("", 455, item.Usuario.ProfilePictureUrl, 455, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(487, 118, true);
            WriteLiteral(" alt=\"\">\r\n                    </div>\r\n                </p>\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(606, 17, false);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
                                                     Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(623, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(625, 22, false);
#line 19 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
                                                                        Write(item.Usuario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(647, 25, true);
            WriteLiteral("</h6>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 672, "\"", 759, 1);
#line 20 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
WriteAttributeValue("", 679, Url.Action("AceitaSolicitacaoAmizade", "Usuarios", new { id = item.Amizade.Id}), 679, 80, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(760, 127, true);
            WriteLiteral(" class=\"card-link\">Aceitar</a>\r\n                <a href=\"#\" class=\"card-link\">Recusar</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\PedidoAmizade\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(897, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.ViewModels.HomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
