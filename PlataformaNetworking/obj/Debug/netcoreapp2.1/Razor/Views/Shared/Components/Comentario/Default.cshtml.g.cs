#pragma checksum "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7297b5ad062c87b638d47a47b201c04ed4017a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Comentario_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Comentario/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Comentario/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Comentario_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7297b5ad062c87b638d47a47b201c04ed4017a6", @"/Views/Shared/Components/Comentario/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Comentario_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 8 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml"
 foreach (var item in Model.Reverse())
{


#line default
#line hidden
            BeginContext(138, 106, true);
            WriteLiteral("        <div class=\"card-body\">\n            <div class=\"text-muted h7 mb-2\"> <i class=\"fa fa-clock-o\"></i>");
            EndContext();
            BeginContext(245, 45, false);
#line 12 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml"
                                                                     Write(item.CommentTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(290, 57, true);
            WriteLiteral("</div>\n            <p class=\"card-text\">\n                ");
            EndContext();
            BeginContext(348, 16, false);
#line 14 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml"
           Write(item.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(364, 46, true);
            WriteLiteral("            \n            </p>\n\n        </div>\n");
            EndContext();
#line 18 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Comentario\Default.cshtml"
}

#line default
#line hidden
            BeginContext(412, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
