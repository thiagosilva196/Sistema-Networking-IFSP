#pragma checksum "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b328c9f91d57b9bed8c1345691cddb39a5989cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Details), @"mvc.1.0.view", @"/Views/Aluno/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aluno/Details.cshtml", typeof(AspNetCore.Views_Aluno_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b328c9f91d57b9bed8c1345691cddb39a5989cfa", @"/Views/Aluno/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Aluno</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 41, false);
#line 14 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 37, false);
#line 17 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(373, 47, false);
#line 20 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AnoIngresso));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 43, false);
#line 23 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.AnoIngresso));

#line default
#line hidden
            EndContext();
            BeginContext(507, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(551, 47, false);
#line 26 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Habilidades));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(642, 43, false);
#line 29 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Habilidades));

#line default
#line hidden
            EndContext();
            BeginContext(685, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(729, 45, false);
#line 32 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Curriculo));

#line default
#line hidden
            EndContext();
            BeginContext(774, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(818, 41, false);
#line 35 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curriculo));

#line default
#line hidden
            EndContext();
            BeginContext(859, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(903, 40, false);
#line 38 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(987, 36, false);
#line 41 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1067, 45, false);
#line 44 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1156, 41, false);
#line 47 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1241, 41, false);
#line 50 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1326, 37, false);
#line 53 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1407, 50, false);
#line 56 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1501, 46, false);
#line 59 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1591, 41, false);
#line 62 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1676, 37, false);
#line 65 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1757, 44, false);
#line 68 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1845, 40, false);
#line 71 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1929, 53, false);
#line 74 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2026, 49, false);
#line 77 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2122, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "319a91a64b44424cb7e0e852c5addd27", async() => {
                BeginContext(2168, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\lucas\Desktop\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2176, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2184, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56501f0ed39648d5bd51c6017a29c136", async() => {
                BeginContext(2206, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2222, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
