#pragma checksum "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca9b0b593fe9bcb483d8a02ff0c35b93fb1a212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaUsuarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca9b0b593fe9bcb483d8a02ff0c35b93fb1a212", @"/Views/Usuario/ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Usuários cadastrados no sistema</h1>
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped""> 
            <thead>
                <th>Nome</th>
                <th>Login</th>
                <th>Tipo</th>
                <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                 foreach(Usuario usr in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                   Write(usr.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                   Write(usr.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                     if(usr.Tipo == Usuario.ADMIN){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Administrador</td>\r\n");
#nullable restore
#line 24 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Padrão</td>\r\n");
#nullable restore
#line 26 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 811, "\"", 847, 2);
            WriteAttributeValue("", 818, "/Usuario/AtualizaUser/", 818, 22, true);
#nullable restore
#line 27 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 840, usr.Id, 840, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 892, "\"", 927, 2);
            WriteAttributeValue("", 899, "/Usuario/ExcluirUser/", 899, 21, true);
#nullable restore
#line 28 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 920, usr.Id, 920, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\gusta\OneDrive\Área de Trabalho\Gustavo_ATv01B\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>        \r\n        <a href=\"InserirUser\">Cadastrar novo usuário</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591