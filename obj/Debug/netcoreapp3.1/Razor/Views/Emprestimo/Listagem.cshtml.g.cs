#pragma checksum "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a2f8946b0e4c1b1348c7e6ec4a1ba7d83c8f99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a2f8946b0e4c1b1348c7e6ec4a1ba7d83c8f99", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    
    int FiltroP = Int32.Parse( ViewData["usuarioP"].ToString());
    int pAtual = Int32.Parse(ViewData["pAtual"].ToString());
    int NumUserP = (Model.Count<FiltroP ?  Model.Count : FiltroP);
    int NumTotalP = Model.Count/NumUserP + (Model.Count%NumUserP == 0 ? 0 : 1);
    string Classe = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a2f8946b0e4c1b1348c7e6ec4a1ba7d83c8f995278", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a2f8946b0e4c1b1348c7e6ec4a1ba7d83c8f995662", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a2f8946b0e4c1b1348c7e6ec4a1ba7d83c8f996902", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>
        <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 32 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
         if(Model.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Usuario</th>
                <th>Data Empréstimo</th>
                <th>Data Devolução</th>
                <th>Livro</th>
                <th>Autor</th>
                <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    for(int i = (pAtual-1)*NumUserP; i<(NumUserP*pAtual<Model.Count?NumUserP*pAtual:Model.Count); i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     if((System.DateTime.Compare(System.DateTime.Now, @Model[i].DataDevolucao)>0))
                    {
                        Classe = "text-danger";
                    }else{
                        Classe="";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 1887, "\"", 1902, 1);
#nullable restore
#line 53 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1895, Classe, 1895, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2287, "\"", 2325, 2);
            WriteAttributeValue("", 2294, "/Emprestimo/Edicao/", 2294, 19, true);
#nullable restore
#line 60 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2313, Model[i].Id, 2313, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 65 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Nenhum registro encontrado</span>\r\n");
#nullable restore
#line 67 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"pag\">\r\n            <ul class=\"pagination\">\r\n                 <li class=\"page-item\"><a class=\"page-link\">Página</a></li>\r\n");
#nullable restore
#line 71 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             for(int i=1; i<=NumTotalP; i++)
            {
               

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2783, "\"", 2820, 2);
            WriteAttributeValue("", 2790, "/Emprestimo/Listagem?pAtual=", 2790, 28, true);
#nullable restore
#line 74 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2818, i, 2818, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 75 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
