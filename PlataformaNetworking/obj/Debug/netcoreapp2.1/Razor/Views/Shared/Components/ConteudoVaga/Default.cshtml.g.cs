#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2241bd183541366253bd6b4a4ff8724ce3c952d2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2241bd183541366253bd6b4a4ff8724ce3c952d2", @"/Views/Shared/Components/ConteudoVaga/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ConteudoVaga_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Vaga>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(96, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
 foreach (var item in Model.Reverse())
{

#line default
#line hidden
            BeginContext(147, 103, true);
            WriteLiteral("    <script>\r\n        function Candidatar() {\r\n            var parametros = {\r\n                IdVaga: ");
            EndContext();
            BeginContext(251, 7, false);
#line 15 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(258, 541, true);
            WriteLiteral(@"
            };

            $.ajax({
                datatype: 'json',
                contentType: ""application/json; charset=utf-8"",
                type: ""POST"",
                url: ""/Vaga/Candidatar"",
                data: JSON.stringify(parametros),
                async: true,
                success: function (data) {
                    //console.log(parametros);
                    //console.log(data);
                    document.location.reload();
                }
            });
        }
    </script>
");
            EndContext();
            BeginContext(801, 313, true);
            WriteLiteral(@"    <div class=""card gedf-card"">
        <div class=""card-header"">
            <div class=""d-flex justify-content-between align-items-center"">
                <div class=""d-flex justify-content-between align-items-center"">

                    <div class=""ml-2"">
                        <div class=""h5 m-0"">");
            EndContext();
            BeginContext(1115, 11, false);
#line 40 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
                                       Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 1021, true);
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
            BeginContext(2148, 46, false);
#line 60 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
                                                                     Write(item.DataPostagem.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 59, true);
            WriteLiteral("</div>\r\n            <p class=\"card-text\">\r\n                ");
            EndContext();
            BeginContext(2254, 13, false);
#line 62 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"
           Write(item.Conteudo);

#line default
#line hidden
            EndContext();
            BeginContext(2267, 300, true);
            WriteLiteral(@"
            </p>


        </div>
        <div class=""card-footer"">
            <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">Candidatar-se</button>
            <a href=""#"" class=""card-link""><i class=""fa fa-comment""></i> Comentar</a>
        </div>
    </div>
");
            EndContext();
            BeginContext(2573, 1225, true);
            WriteLiteral(@"        <!-- The Modal -->
        <div class=""modal fade"" id=""myModal"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">


                    {
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
                        <input type=""button"" onclick=""Candidatar()"" value=""Confirmar"" class=""btn btn-primary"" />
                    ");
            WriteLiteral("    <input type=\"button\" value=\"Cancelar\" class=\"btn btn-danger\" data-dismiss=\"modal\" />\r\n\r\n                    </div>\r\n\r\n                </div>\r\n                }\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 108 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\ConteudoVaga\Default.cshtml"

        }

#line default
#line hidden
            BeginContext(3811, 6, true);
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
