#pragma checksum "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d758cf4e8d99c36e5ac78bb8d8456120707a8842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo_Form), @"mvc.1.0.view", @"/Views/Curriculo/Form.cshtml")]
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
#line 1 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\_ViewImports.cshtml"
using Curriculos_ASP.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\_ViewImports.cshtml"
using Curriculos_ASP.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d758cf4e8d99c36e5ac78bb8d8456120707a8842", @"/Views/Curriculo/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527ebb2bb7c6b7e745f6615220fdd9fef4e8cafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculo_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurriculoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "salvar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d758cf4e8d99c36e5ac78bb8d8456120707a88423727", async() => {
                WriteLiteral("\r\n    <label class=\"form-label\"> Nome </label>\r\n    <input type=\"text\" name=\"nome\"");
                BeginWriteAttribute("value", " value=", 137, "", 155, 1);
#nullable restore
#line 5 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 144, Model.nome, 144, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> CPF </label>\r\n    <input type=\"text\" name=\"cpf\"");
                BeginWriteAttribute("value", " value=", 261, "", 278, 1);
#nullable restore
#line 8 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 268, Model.cpf, 268, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Endereço </label>\r\n    <input type=\"text\" name=\"endereco\"");
                BeginWriteAttribute("value", " value=", 394, "", 416, 1);
#nullable restore
#line 11 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 401, Model.endereco, 401, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Telefone </label>\r\n    <input type=\"text\" name=\"telefone\"");
                BeginWriteAttribute("value", " value=", 532, "", 554, 1);
#nullable restore
#line 14 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 539, Model.telefone, 539, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Pretenção Salarial </label>\r\n    <input type=\"text\" name=\"pretencaoSalarial\"");
                BeginWriteAttribute("value", " value=", 689, "", 720, 1);
#nullable restore
#line 17 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 696, Model.pretencaoSalarial, 696, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Cargo Pretendido </label>\r\n    <input type=\"text\" name=\"cargoPretendido\"");
                BeginWriteAttribute("value", " value=", 855, "", 884, 1);
#nullable restore
#line 20 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 862, Model.cargoPretendido, 862, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Instituição de Formação 1</label>\r\n    <input type=\"text\" name=\"instituicaoFormacao1\"");
                BeginWriteAttribute("value", " value=", 1028, "", 1062, 1);
#nullable restore
#line 23 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1035, Model.instituicaoFormacao1, 1035, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"30\" class=\"form-control\"  />\r\n    \r\n    <label class=\"form-label\"> Tipo de Formação 1</label>\r\n    <input type=\"text\" name=\"tipoFormacao1\"");
                BeginWriteAttribute("value", " value=", 1208, "", 1235, 1);
#nullable restore
#line 26 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1215, Model.tipoFormacao1, 1215, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"30\" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Formação1 </label>\r\n    <input type=\"text\" name=\"formacao1\"");
                BeginWriteAttribute("value", " value=", 1368, "", 1391, 1);
#nullable restore
#line 29 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1375, Model.formacao1, 1375, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Instituição de Formação 2</label>\r\n    <input type=\"text\" name=\"instituicaoFormacao2\"");
                BeginWriteAttribute("value", " value=", 1539, "", 1573, 1);
#nullable restore
#line 32 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1546, Model.instituicaoFormacao2, 1546, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Tipo de Formação 2</label>\r\n    <input type=\"text\" name=\"tipoFormacao2\"");
                BeginWriteAttribute("value", " value=", 1707, "", 1741, 1);
#nullable restore
#line 35 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1714, Model.instituicaoFormacao2, 1714, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Formação 2</label>\r\n    <input type=\"text\" name=\"formacao2\"");
                BeginWriteAttribute("value", " value=", 1863, "", 1886, 1);
#nullable restore
#line 38 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1870, Model.formacao2, 1870, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Instituição de Formação 3</label>\r\n    <input type=\"text\" name=\"instituicaoFormacao3\"");
                BeginWriteAttribute("value", " value=", 2034, "", 2068, 1);
#nullable restore
#line 41 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2041, Model.instituicaoFormacao3, 2041, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Tipo de Formação 3</label>\r\n    <input type=\"text\" name=\"tipoFormacao3\"");
                BeginWriteAttribute("value", " value=", 2202, "", 2229, 1);
#nullable restore
#line 44 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2209, Model.tipoFormacao3, 2209, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Formação 3</label>\r\n    <input type=\"text\" name=\"formacao3\"");
                BeginWriteAttribute("value", " value=", 2351, "", 2374, 1);
#nullable restore
#line 47 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2358, Model.formacao3, 2358, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Instituição de Formação 4</label>\r\n    <input type=\"text\" name=\"instituicaoFormacao4\"");
                BeginWriteAttribute("value", " value=", 2518, "", 2552, 1);
#nullable restore
#line 50 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2525, Model.instituicaoFormacao4, 2525, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Tipo de Formação 4</label>\r\n    <input type=\"text\" name=\"tipoFormacao4\"");
                BeginWriteAttribute("value", " value=", 2686, "", 2713, 1);
#nullable restore
#line 53 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2693, Model.tipoFormacao4, 2693, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Formação 4</label>\r\n    <input type=\"text\" name=\"formacao4\"");
                BeginWriteAttribute("value", " value=", 2835, "", 2858, 1);
#nullable restore
#line 56 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2842, Model.formacao4, 2842, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Instituição de Formação 5</label>\r\n    <input type=\"text\" name=\"instituicaoFormacao5\"");
                BeginWriteAttribute("value", " value=", 3002, "", 3036, 1);
#nullable restore
#line 59 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3009, Model.instituicaoFormacao5, 3009, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Tipo de Formação 5</label>\r\n    <input type=\"text\" name=\"tipoFormacao5\"");
                BeginWriteAttribute("value", " value=", 3170, "", 3197, 1);
#nullable restore
#line 62 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3177, Model.tipoFormacao5, 3177, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Formação 5</label>\r\n    <input type=\"text\" name=\"formacao5\"");
                BeginWriteAttribute("value", " value=", 3319, "", 3342, 1);
#nullable restore
#line 65 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3326, Model.formacao5, 3326, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Empresa Experiência 1</label>\r\n    <input type=\"text\" name=\"empresaExperiencia1\"");
                BeginWriteAttribute("value", " value=", 3481, "", 3514, 1);
#nullable restore
#line 68 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3488, Model.empresaExperiencia1, 3488, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Tipo de Experiência 1</label>\r\n    <input type=\"text\" name=\"tipoExperiencia1\"");
                BeginWriteAttribute("value", " value=", 3650, "", 3680, 1);
#nullable restore
#line 71 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3657, Model.tipoExperiencia1, 3657, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Experência 1</label>\r\n    <input type=\"text\" name=\"experiencia1\"");
                BeginWriteAttribute("value", " value=", 3803, "", 3829, 1);
#nullable restore
#line 74 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3810, Model.experiencia1, 3810, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Empresa Experiência 2</label>\r\n    <input type=\"text\" name=\"empresaExperiencia2\"");
                BeginWriteAttribute("value", " value=", 3968, "", 4001, 1);
#nullable restore
#line 77 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3975, Model.empresaExperiencia2, 3975, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Tipo de Experiência 2</label>\r\n    <input type=\"text\" name=\"tipoExperiencia2\"");
                BeginWriteAttribute("value", " value=", 4137, "", 4167, 1);
#nullable restore
#line 80 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4144, Model.tipoExperiencia2, 4144, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Experência 2</label>\r\n    <input type=\"text\" name=\"experiencia2\"");
                BeginWriteAttribute("value", " value=", 4290, "", 4316, 1);
#nullable restore
#line 83 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4297, Model.experiencia2, 4297, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Empresa Experiência 3</label>\r\n    <input type=\"text\" name=\"empresaExperiencia3\"");
                BeginWriteAttribute("value", " value=", 4455, "", 4488, 1);
#nullable restore
#line 86 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4462, Model.empresaExperiencia3, 4462, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Tipo de Experiência 3</label>\r\n    <input type=\"text\" name=\"tipoExperiencia3\"");
                BeginWriteAttribute("value", " value=", 4624, "", 4654, 1);
#nullable restore
#line 89 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4631, Model.tipoExperiencia3, 4631, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n    <label class=\"form-label\"> Experência 3</label>\r\n    <input type=\"text\" name=\"experiencia3\"");
                BeginWriteAttribute("value", " value=", 4777, "", 4803, 1);
#nullable restore
#line 92 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4784, Model.experiencia3, 4784, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Idioma 1</label>\r\n    <input type=\"text\" name=\"idioma1\"");
                BeginWriteAttribute("value", " value=", 4921, "", 4942, 1);
#nullable restore
#line 95 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4928, Model.idioma1, 4928, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Nível 1</label>\r\n    <input type=\"text\" name=\"nivelIdioma1\"");
                BeginWriteAttribute("value", " value=", 5064, "", 5090, 1);
#nullable restore
#line 98 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 5071, Model.nivelIdioma1, 5071, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Idioma 2</label>\r\n    <input type=\"text\" name=\"idioma2\"");
                BeginWriteAttribute("value", " value=", 5208, "", 5229, 1);
#nullable restore
#line 101 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 5215, Model.idioma2, 5215, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Nível 2</label>\r\n    <input type=\"text\" name=\"nivelIdioma2\"");
                BeginWriteAttribute("value", " value=", 5351, "", 5377, 1);
#nullable restore
#line 104 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 5358, Model.nivelIdioma2, 5358, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Idioma 3</label>\r\n    <input type=\"text\" name=\"idioma3\"");
                BeginWriteAttribute("value", " value=", 5495, "", 5516, 1);
#nullable restore
#line 107 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 5502, Model.idioma3, 5502, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <label class=\"form-label\"> Nível 3</label>\r\n    <input type=\"text\" name=\"nivelIdioma3\"");
                BeginWriteAttribute("value", " value=", 5638, "", 5664, 1);
#nullable restore
#line 110 "D:\Documents\FTT\EC5\Linguagem de programação I\N2B1\Curriculos-ASP.NET\Curriculos-ASP.NET\Curriculos-ASP.NET\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 5645, Model.nivelIdioma3, 5645, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    \r\n    <br />\r\n    <input type=\"submit\" value=\"Salvar\" class=\"btn btn-info\" />\r\n    &nbsp;&nbsp;&nbsp;\r\n    <a href=\"/curriculo/index\" class=\"btn btn-success\">Voltar</a>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurriculoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
