#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0bb0d16928922e8f996a7a9827d99865e78c1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Details), @"mvc.1.0.view", @"/Views/Usuarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Details.cshtml", typeof(AspNetCore.Views_Usuarios_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bb0d16928922e8f996a7a9827d99865e78c1e1", @"/Views/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlataformaNetworking.Models.Usuario>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 40, false);
#line 14 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 36, false);
#line 17 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 45, false);
#line 20 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 41, false);
#line 23 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(549, 41, false);
#line 26 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(590, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 37, false);
#line 29 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(671, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(715, 50, false);
#line 32 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 46, false);
#line 35 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(855, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1572, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(1599, 41, false);
#line 63 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1684, 37, false);
#line 66 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1765, 44, false);
#line 69 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1853, 40, false);
#line 72 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1937, 53, false);
#line 75 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2034, 49, false);
#line 78 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2130, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c377ac4377d54765867c1207e8b284a6", async() => {
                BeginContext(2176, 4, true);
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
#line 83 "C:\Users\thiag\Desktop\FACULDADE\Sistema-Networking-IFSP\Sistema-Networking-IFSP\PlataformaNetworking\Views\Usuarios\Details.cshtml"
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
            BeginContext(2184, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2192, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "074c2d4f0ea242ef8662c79f66c2054b", async() => {
                BeginContext(2214, 12, true);
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
            BeginContext(2230, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlataformaNetworking.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
