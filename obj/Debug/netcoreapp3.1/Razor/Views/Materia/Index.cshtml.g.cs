#pragma checksum "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57207b5b69daad16c23269485edc25f9df6da20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materia_Index), @"mvc.1.0.view", @"/Views/Materia/Index.cshtml")]
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
#line 1 "C:\Users\rafae\Desktop\N2B2V2\Views\_ViewImports.cshtml"
using ProjetoN2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafae\Desktop\N2B2V2\Views\_ViewImports.cshtml"
using ProjetoN2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57207b5b69daad16c23269485edc25f9df6da20", @"/Views/Materia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6aa26658f4f225c49b9585c40585cc84aa51b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Materia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoN2.Models.MateriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3>Materias</h3>
    <a class=""btn btn-striped btn-outline-dark"" href=""/materia/Create"">Adicionar</a>
    <br><br><br>

    <table class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Curso</th>
                <th>Professor</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
             foreach (var materia in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
                   Write(materia.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
                   Write(materia.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
                   Write(materia.CursoNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
                   Write(materia.ProfessorNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 904, "\"", 941, 2);
            WriteAttributeValue("", 911, "/materia/Update?id=", 911, 19, true);
#nullable restore
#line 30 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
WriteAttributeValue("", 930, materia.Id, 930, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Atualizar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1053, 2);
            WriteAttributeValue("", 1023, "/materia/Delete?id=", 1023, 19, true);
#nullable restore
#line 31 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
WriteAttributeValue("", 1042, materia.Id, 1042, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\rafae\Desktop\N2B2V2\Views\Materia\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoN2.Models.MateriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
