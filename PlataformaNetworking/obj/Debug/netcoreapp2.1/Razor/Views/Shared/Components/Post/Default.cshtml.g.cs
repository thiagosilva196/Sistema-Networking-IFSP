#pragma checksum "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d169540239c0104e644603372e850fd688399ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Post/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Post/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Post_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d169540239c0104e644603372e850fd688399ab2", @"/Views/Shared/Components/Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.ViewModels.HomePostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 8 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
 foreach (var item in Model.Reverse())
{


#line default
#line hidden
            BeginContext(159, 324, true);
            WriteLiteral(@"    <div class=""card gedf-card"">
        <div class=""card-header"">
            <div class=""d-flex justify-content-between align-items-center"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""mr-3"">
                        <img class=""rounded-circle"" width=""50""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 483, "\"", 512, 2);
            WriteAttributeValue("", 488, "FotoPerfil-", 488, 11, true);
#line 16 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 499, item.Post.Id, 499, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 513, "\"", 550, 1);
#line 16 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 519, item.Usuario.ProfilePictureUrl, 519, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(551, 116, true);
            WriteLiteral(" alt=\"\">\n                    </div>\n                    <div class=\"ml-2\">\n                        <a class=\"h5 m-0\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 667, "\"", 706, 2);
            WriteAttributeValue("", 674, "Usuarios/Perfil/", 674, 16, true);
#line 19 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 690, item.Usuario.Id, 690, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(709, 17, false);
#line 19 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                             Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(726, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(728, 22, false);
#line 19 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                                                Write(item.Usuario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(750, 999, true);
            WriteLiteral(@"</a>
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
            BeginContext(1750, 47, false);
#line 39 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                     Write(item.Post.PostTime.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 57, true);
            WriteLiteral("</div>\n            <p class=\"card-text\">\n                ");
            EndContext();
            BeginContext(1855, 19, false);
#line 41 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(item.Post.TextoPost);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 34, true);
            WriteLiteral("\n            </p>\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1908, "\"", 1931, 1);
#line 43 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 1914, item.Post.Imagem, 1914, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1932, 185, true);
            WriteLiteral(" style=\"width:100%\" alt=\"Post Image\" class=\"w3-margin-bottom\">\n\n        </div>\n        <div class=\"card-footer\">\n            <span class=\"card-link\" id=\"curtir\" style=\"cursor: pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2117, "\"", 2146, 3);
            WriteAttributeValue("", 2127, "Like(", 2127, 5, true);
#line 47 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2132, item.Post.Id, 2132, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2145, ")", 2145, 1, true);
            EndWriteAttribute();
            BeginContext(2147, 104, true);
            WriteLiteral(">Curtir</span>\n            <span class=\"card-link\" id=\"descurtir\" style=\"cursor: pointer; display: none\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2251, "\"", 2283, 3);
            WriteAttributeValue("", 2261, "Dislike(", 2261, 8, true);
#line 48 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2269, item.Post.Id, 2269, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2282, ")", 2282, 1, true);
            EndWriteAttribute();
            BeginContext(2284, 67, true);
            WriteLiteral(">Descurtir</span>\n            <span class=\"card-link\" id=\"comentar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2351, "\"", 2384, 3);
            WriteAttributeValue("", 2361, "Comentar(", 2361, 9, true);
#line 49 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2370, item.Post.Id, 2370, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2383, ")", 2383, 1, true);
            EndWriteAttribute();
            BeginContext(2385, 203, true);
            WriteLiteral(" style=\"cursor: pointer\"><i class=\"fa fa-comment\"></i> Comentar</span>\n            <span class=\"card-link\" style=\"cursor: pointer;\">Compartilhar</span>\n            <div class=\"row mt-2\">\n                ");
            EndContext();
            BeginContext(2588, 562, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f52ccf73fdd40a4b0029369936b6fb8", async() => {
                BeginContext(2663, 67, true);
                WriteLiteral("\n                    <input type=\"hidden\" id=\"IdPost\" name=\"IdPost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2730, "\"", 2751, 1);
#line 53 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 2738, item.Post.Id, 2738, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2752, 251, true);
                WriteLiteral(" />\n                    <div class=\"col-md-5\">\n                        <input type=\"text\" class=\"form-control\" name=\"CommentText\" id=\"CommentText\" />\n                    </div>\n                    <div class=\"col-md-3\">\n                        <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3003, "\"", 3042, 3);
                WriteAttributeValue("", 3013, "FormComentario(", 3013, 15, true);
#line 58 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3028, item.Post.Id, 3028, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 3041, ")", 3041, 1, true);
                EndWriteAttribute();
                BeginContext(3043, 100, true);
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary\">Comentar</button>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2612, "formComentario-", 2612, 15, true);
#line 52 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
AddHtmlAttributeValue("", 2627, item.Post.Id, 2627, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3150, 115, true);
            WriteLiteral("\n            </div>\n\n            <p>\n                <span class=\"glyphicon glyphicon-thumbs-up card-link\"></span> ");
            EndContext();
            BeginContext(3266, 14, false);
#line 64 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                         Write(item.Post.Like);

#line default
#line hidden
            EndContext();
            BeginContext(3280, 68, true);
            WriteLiteral("\n                <span class=\"glyphicon glyphicon-comment card-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3348, "\"", 3391, 3);
            WriteAttributeValue("", 3358, "MostrarComentarios(", 3358, 19, true);
#line 65 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3377, item.Post.Id, 3377, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3390, ")", 3390, 1, true);
            EndWriteAttribute();
            BeginContext(3392, 57, true);
            WriteLiteral(" id=\"mostrarComentarios\" style=\"cursor: pointer\"></span> ");
            EndContext();
            BeginContext(3450, 21, false);
#line 65 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                                                                                                                                                                   Write(item.Post.Comentarios);

#line default
#line hidden
            EndContext();
            BeginContext(3471, 111, true);
            WriteLiteral("\n                <span class=\"glyphicon glyphicon-share card-link\"></span> 0\n            </p>\n\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3582, "\"", 3612, 2);
            WriteAttributeValue("", 3587, "comentarios-", 3587, 12, true);
#line 69 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 3599, item.Post.Id, 3599, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3613, 40, true);
            WriteLiteral(" style=\"display: none\">\n                ");
            EndContext();
            BeginContext(3654, 55, false);
#line 70 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
           Write(await Component.InvokeAsync("Comentario", item.Post.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3709, 46, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
            EndContext();
            BeginContext(3756, 34, true);
            WriteLiteral("    <script>\n        VerificaLike(");
            EndContext();
            BeginContext(3791, 12, false);
#line 76 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
                Write(item.Post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3803, 600, true);
            WriteLiteral(@");
        
        async function VerificaLike(idPost) {

            $.ajax({
                datatype: 'json',
                contentType: 'application/json',
                type: ""GET"",
                url: ""/Publicacoes/VerificaLike?idPost="" + idPost,
                /*data: {
                    idPost: idPost;
                },*/
                success: function (like) {
                    if (like) {
                        $('#curtir').hide();
                        $('#descurtir').show();
                    }
                }
            })
        }

        

    </script>
");
            EndContext();
#line 100 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Shared\Components\Post\Default.cshtml"
    
}

#line default
#line hidden
            BeginContext(4410, 1722, true);
            WriteLiteral(@"
<script>
    async function Like(idPost) {
        var parametros = {
            IdPost: idPost
        };

        $.ajax({
            datatype: 'json',
            contentType: ""application/json"",
            type: ""POST"",
            url: ""/Publicacoes/Like"",
            data: JSON.stringify(parametros),
            async: true,
            success: function (data) {
                document.location.reload();
            }
        });
    }

    async function Dislike(idPost) {
        var parametros = {
            IdPost: idPost
        };

        $.ajax({
            datatype: 'json',
            contentType: ""application/json"",
            type: ""POST"",
            url: ""/Publicacoes/Dislike"",
            data: JSON.stringify(parametros),
            async: true,
            success: function (data) {
                document.location.reload();
            }
        });
    }

    

    function FormComentario(id) {
        $('body').on('submit', '#formComentario-' + id, function (evt) {
         ");
            WriteLiteral(@"   evt.preventDefault();
            $.ajax({
                url: '/Publicacoes/Comentario',
                type: 'post',
                data: $('#formComentario-' + id).serialize(),
                success: function () {
                    document.location.reload();
                }
            });
        });
    }
    

    function Comentar(id) {
            $(""#formComentario-"" + id).toggle();
    }

    function MostrarComentarios(id) {
        $(""#comentarios-"" + id).toggle();
    }

   /* $(""#comentar"").click(function () {
        $(""#formComentario"").toggle();
    });

    $(""#mostrarComentarios"").click(function () {
        $(""#comentarios"").toggle();
    });*/


</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.ViewModels.HomePostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
