#pragma checksum "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce915c649ce92004a6f791644489e4eaecf3e79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Registrar), @"mvc.1.0.view", @"/Views/Emprestimo/Registrar.cshtml")]
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
#line 1 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\_ViewImports.cshtml"
using GestaoDocumentos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\_ViewImports.cshtml"
using GestaoDocumentos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce915c649ce92004a6f791644489e4eaecf3e79e", @"/Views/Emprestimo/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ce00fa7c1bdb7be5168c41ad3c39253fa80822", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmprestimoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Digite o apelido para o empréstimo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Emprestimo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
  
    ViewData["Title"] = "Adicionar Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Registrar Empréstimos</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e7038", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"nomeUserView\">Cliente</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e7393", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
              
                foreach (var cliente in (List<ClienteModel>)ViewBag.ListaClientes_EmEmprestimo)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e8012", async() => {
#nullable restore
#line 17 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                                           Write(cliente.Nome);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                       WriteLiteral(cliente.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 13 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdClienteCH);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"nomeUserView\">Bibliotecário</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e11666", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
              
                foreach (var bibliotecario in (List<BibliotecarioModel>)ViewBag.ListaBibliotecarios_EmEmprestimo)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e12304", async() => {
#nullable restore
#line 29 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                                                 Write(bibliotecario.Nome);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                       WriteLiteral(bibliotecario.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 25 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdBibliotecarioCH);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <label for=\"nomeUserView\">Adicionar Livros</label>\r\n    <div class=\"form-group\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-4\">\r\n                <select class=\"form-control\" id=\"sltLivro\">\r\n");
#nullable restore
#line 40 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                      
                        foreach (var livro in (List<LivroModel>)ViewBag.ListaLivros_EmEmprestimo)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e16485", async() => {
#nullable restore
#line 43 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                                                 Write(livro.Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                               WriteLiteral(livro.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""col-lg-1"">
                <input type=""text"" class=""form-control"" value=""1"" id=""txtQuantidade""/>
            </div>
            <div class=""col-lg-3"">
                <button type=""button"" class=""btn btn-block btn-primary"" onclick=""AdicionarLivro()"">Adicionar</button>
            </div>
        </div>        
    </div>

    <br />

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>Id</td>
                <td>Nome</td>
                <td>Quantidade</td>
                <td>Preço Unitário</td>
                <td>Total</td>
            </tr>
        </thead>
        <tbody id=""listaLivros"">
        </tbody>
    </table>

    <div class=""form-group"">
        <label for=""nomeUserView"">Nome Personalizado</label>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ce915c649ce92004a6f791644489e4eaecf3e79e19499", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 75 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NomePersonalizado);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 76 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
   Write(Html.ValidationMessageFor(x => x.NomePersonalizado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-success btn-block\">Registrar</button>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce915c649ce92004a6f791644489e4eaecf3e79e21765", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    alert(""Iniciando"");
    var Itens = new Object();
    Itens.Livros = new Array();

    var codigoLivro = document.getElementById(""sltLivro"");
    var QtdeLivro = document.getElementById(""txtQuantidade"");
    var ListaLivro = document.getElementById(""listaLivros"");
    var PrecoUnitarioView = 0;

    function AdicionarLivro() {
        alert('AdicionarLivro - PrecoUnitarioView: ' + PrecoUnitarioView);

        var DescricaoLivro = codigoLivro.options[codigoLivro.selectedIndex].text;

        alert(""Preço Unitário igual "" + PrecoUnitarioView);
        var total = (PrecoUnitarioView * QtdeLivro.value);

        Itens.Livros.push({
            ""CodigoLivro"": codigoLivro.value,
            ""DescricaoLivro"": DescricaoLivro,
            ""QtDeProduto"": QtdeLivro.value,
            ""PrecoUnitario"": PrecoUnitarioView,
            ""Total"": total
        });

        var produto = ""<tr>"" +
            ""<td>"" + codigoLivro.value + ""</td>"" +
            ""<td>"" + DescricaoLivro +");
            WriteLiteral(@" ""</td>"" +
            ""<td>"" + QtdeLivro.value + ""</td>"" +
            ""<td>"" + PrecoUnitarioView + ""</td>"" +
            ""<td>"" + total + ""</td>"" +
            ""<tr>"";

        ListaLivro.innerHTML += produto;

    }

    function BuscarPrecoUnitario(idLivro) {

        alert(""Olá - Estamos em BuscarPrecoUnitario - Id Livro: "" + idLivro);

        if (idLivro > 0) {

            $.ajax({
                url: '");
#nullable restore
#line 128 "D:\apps\C#\GestaoDocumentos\GestaoDocumentos\Views\Emprestimo\Registrar.cshtml"
                 Write(Url.Action("LocalizarPrecoUnitario", "Emprestimo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'GET',
                dataType: 'json',
                cache: false,
                data: { 'id': idLivro },
                success: function (precoUnitario) {
                    var preco = precoUnitario;
                    PrecoUnitarioView = preco;
                    alert(""PrecoUnitarioView V2: "" + PrecoUnitarioView);
                    return preco;
                },
                error: function () {
                    alert('Ocorreu um erro ao buscar o Preço Unitário');
                }
            });
        }
        else {
            return 0.99;
        }
    }

    (function () {
        document.getElementById('sltLivro').addEventListener('change', function () {

            alert(""clicou nessa porra"");

            var idLivro = document.getElementById(""sltLivro"");

            PrecoUnitarioView = BuscarPrecoUnitario(idLivro.value);

            alert(""Preço: "" + PrecoUnitarioView);

        })
    })();

    document.onl");
            WriteLiteral(@"oad(funcaoPaginaCarregada())

    function funcaoPaginaCarregada() {
        alert(""página totalmente carregada!"");

        var idLivro = document.getElementById(""sltLivro"");

        PrecoUnitarioView = BuscarPrecoUnitario(idLivro.value);

        alert(""Preço - funcaoPaginaCarregada: "" + PrecoUnitarioView);
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmprestimoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
