#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ede87523d70e976f78ab4d4d408bba248feabb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ConteudoVagaAluno_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ConteudoVagaAluno/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ConteudoVagaAluno/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ConteudoVagaAluno_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ede87523d70e976f78ab4d4d408bba248feabb", @"/Views/Shared/Components/ConteudoVagaAluno/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ConteudoVagaAluno_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Vaga>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(96, 622, true);
            WriteLiteral(@"

<script>

    async function Candidatar(id) {
        var parametros = {
            IdVaga: id
        };

        $.ajax({
            datatype: 'json',
            contentType: ""application/json"",
            type: ""POST"",
            url: ""/Vaga/Candidatar"",
            data: JSON.stringify(parametros),
            async: true,
            success: function (data) {
                console.log(""parametros.IdVaga: "" + parametros.IdVaga);
                console.log(""data: "" + data.parametros);
                //document.location.reload();

            }
        });
    }
</script>


");
            EndContext();
#line 33 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
 foreach (var item in Model.Reverse())
{



#line default
#line hidden
            BeginContext(765, 313, true);
            WriteLiteral(@"    <div class=""card gedf-card"">
        <div class=""card-header"">
            <div class=""d-flex justify-content-between align-items-center"">
                <div class=""d-flex justify-content-between align-items-center"">

                    <div class=""ml-2"">
                        <div class=""h5 m-0"">");
            EndContext();
            BeginContext(1079, 11, false);
#line 43 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
                                       Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 1021, true);
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
            BeginContext(2112, 46, false);
#line 63 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
                                                                     Write(item.DataPostagem.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 59, true);
            WriteLiteral("</div>\r\n            <p class=\"card-text\">\r\n                ");
            EndContext();
            BeginContext(2218, 13, false);
#line 65 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
           Write(item.Conteudo);

#line default
#line hidden
            EndContext();
            BeginContext(2231, 161, true);
            WriteLiteral("\r\n            </p>\r\n\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal-");
            EndContext();
            BeginContext(2393, 7, false);
#line 71 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2400, 83, true);
            WriteLiteral("\">Candidatar-se</button>\r\n            <!--<input type=\"button\" onclick=\"Candidatar(");
            EndContext();
            BeginContext(2484, 7, false);
#line 72 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2491, 166, true);
            WriteLiteral(")\" value=\"Confirmar\" class=\"btn btn-primary\" />-->\r\n            <a href=\"#\" class=\"card-link\"><i class=\"fa fa-comment\"></i> Comentar</a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2663, 51, true);
            WriteLiteral("    <!-- The Modal -->\r\n    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2714, "\"", 2735, 2);
            WriteAttributeValue("", 2719, "myModal-", 2719, 8, true);
#line 80 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
WriteAttributeValue("", 2727, item.Id, 2727, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2736, 605, true);
            WriteLiteral(@">
        <div class=""modal-dialog"">
            <div class=""modal-content"">



                <!-- Modal Header -->
    <div class=""modal-header"">
        <h4 class=""modal-title"">Confirmação de candidatura</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
    </div>


    <!-- Modal body -->
    <div class=""modal-body"">
        <div class=""form-horizontal"">
            <hr />
            <p>Deseja realmente se candidatar à vaga?</p>
        </div>
    </div>

    <!-- Modal footer -->
    <div class=""modal-footer"">
        <input type=""button""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3341, "\"", 3371, 3);
            WriteAttributeValue("", 3351, "Candidatar(", 3351, 11, true);
#line 103 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"
WriteAttributeValue("", 3362, item.Id, 3362, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3370, ")", 3370, 1, true);
            EndWriteAttribute();
            BeginContext(3372, 195, true);
            WriteLiteral(" value=\"Confirmar\" class=\"btn btn-primary\" />\r\n        <input type=\"button\" value=\"Cancelar\" class=\"btn btn-danger\" data-dismiss=\"modal\" />\r\n\r\n    </div>\r\n\r\n    </div>\r\n\r\n    </div>\r\n    </div>\r\n");
            EndContext();
#line 112 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVagaAluno\Default.cshtml"



}

#line default
#line hidden
            BeginContext(3576, 6, true);
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
