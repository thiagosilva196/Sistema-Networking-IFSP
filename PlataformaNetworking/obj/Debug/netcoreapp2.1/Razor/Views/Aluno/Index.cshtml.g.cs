#pragma checksum "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d987e58d036de9db463f5c633089314a8a75992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aluno/Index.cshtml", typeof(AspNetCore.Views_Aluno_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d987e58d036de9db463f5c633089314a8a75992", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaNetworking.Models.Aluno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a753096a9501475dafdb3ffb6ad495e4", async() => {
                BeginContext(141, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(155, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(242, 41, false);
#line 16 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(283, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(336, 47, false);
#line 19 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnoIngresso));

#line default
#line hidden
            EndContext();
            BeginContext(383, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(436, 47, false);
#line 22 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Habilidades));

#line default
#line hidden
            EndContext();
            BeginContext(483, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(536, 45, false);
#line 25 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Curriculo));

#line default
#line hidden
            EndContext();
            BeginContext(581, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(634, 40, false);
#line 28 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(674, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(727, 45, false);
#line 31 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(772, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(825, 41, false);
#line 34 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(866, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(919, 50, false);
#line 37 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(969, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1022, 41, false);
#line 40 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1116, 44, false);
#line 43 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1213, 53, false);
#line 46 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 52 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1377, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1424, 40, false);
#line 55 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Curso));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1517, 46, false);
#line 58 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnoIngresso));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1616, 46, false);
#line 61 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilidades));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1715, 44, false);
#line 64 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Curriculo));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1812, 39, false);
#line 67 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1904, 44, false);
#line 70 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2001, 40, false);
#line 73 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2094, 49, false);
#line 76 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2196, 40, false);
#line 79 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2289, 43, false);
#line 82 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2385, 52, false);
#line 85 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProfilePictureUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2489, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ac5872f21f44e5b32ef466b5ea9530", async() => {
                BeginContext(2534, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2542, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2561, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db57d7067acf4808930e994e36f72191", async() => {
                BeginContext(2609, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2620, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2639, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "991631b7841d49fa84df6dcf46ab43d7", async() => {
                BeginContext(2686, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2696, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 93 "C:\Users\lucas\source\repos\Sistema-Networking-IFSP\PlataformaNetworking\Views\Aluno\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2731, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaNetworking.Models.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
