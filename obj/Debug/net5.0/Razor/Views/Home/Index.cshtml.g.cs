#pragma checksum "D:\apps\asp_net\GestaoDocumentos\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "476e101714ea711eb011b2bc2deae56270d22e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\apps\asp_net\GestaoDocumentos\Views\_ViewImports.cshtml"
using GestaoDocumentos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\apps\asp_net\GestaoDocumentos\Views\_ViewImports.cshtml"
using GestaoDocumentos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476e101714ea711eb011b2bc2deae56270d22e34", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ce00fa7c1bdb7be5168c41ad3c39253fa80822", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\apps\asp_net\GestaoDocumentos\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem-vindo, ");
#nullable restore
#line 7 "D:\apps\asp_net\GestaoDocumentos\Views\Home\Index.cshtml"
                                Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Site de Gestão de Documentos.</p>\r\n    <span>Seu e-mail é: ");
#nullable restore
#line 9 "D:\apps\asp_net\GestaoDocumentos\Views\Home\Index.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
