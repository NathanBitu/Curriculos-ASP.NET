#pragma checksum "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fa17dd54c18b71d1ab78d81ff9e6e8ac026cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo_Index), @"mvc.1.0.view", @"/Views/Curriculo/Index.cshtml")]
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
#line 1 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\_ViewImports.cshtml"
using Curriculos_ASP.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\_ViewImports.cshtml"
using Curriculos_ASP.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99fa17dd54c18b71d1ab78d81ff9e6e8ac026cc7", @"/Views/Curriculo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527ebb2bb7c6b7e745f6615220fdd9fef4e8cafe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Curriculo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CurriculoViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Listagem de Currículos</h2>
<br />

<a href=""/curriculo/create"" class=""btn btn-success"">Novo Registro</a>
<br />
<br />

<table class=""table table-striped table-responsive"">
    <tr>
        <th>Nome</th>
        <th>CPF</th>
        <th>Edição</th>
        <th>Deletar</th>
        <th>Vizualização</th>
    </tr>

");
#nullable restore
#line 19 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
     foreach (var curriculo in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
#line 22 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
            Write(curriculo.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 23 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
            Write(curriculo.cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 568, 2);
            WriteAttributeValue("", 534, "/curriculo/Edit?cpf=", 534, 20, true);
#nullable restore
#line 24 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
WriteAttributeValue("", 554, curriculo.cpf, 554, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 605, "\"", 648, 2);
            WriteAttributeValue("", 612, "/curriculo/Delete?cpf=", 612, 22, true);
#nullable restore
#line 25 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
WriteAttributeValue("", 634, curriculo.cpf, 634, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 728, 2);
            WriteAttributeValue("", 692, "/curriculo/Resume?cpf=", 692, 22, true);
#nullable restore
#line 26 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
WriteAttributeValue("", 714, curriculo.cpf, 714, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Currículo</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Leonardo\OneDrive\Área de Trabalho\FTT\EC5\Linguagem de Programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CurriculoViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
