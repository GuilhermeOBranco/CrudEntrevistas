#pragma checksum "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47173368644bd365d9b00688c7755e4416642d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entrevistado_List), @"mvc.1.0.view", @"/Views/Entrevistado/List.cshtml")]
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
#line 1 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\_ViewImports.cshtml"
using ProjetoEstags;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\_ViewImports.cshtml"
using ProjetoEstags.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47173368644bd365d9b00688c7755e4416642d7f", @"/Views/Entrevistado/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d1413856dfaa77b28c2129dfb0bd4bdc00d5f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Entrevistado_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoEstags.Models.Entrevistado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""h1 text-center"" style=""color: #FF7200;"">Página de listagem dos entrevistados</h1>


<table class=""table"">
  <thead class=""thead-primary"" style=""background-color: #FF7200; color: white;"" >
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Nome</th>
      <th scope=""col"">Nascimento</th>
      <th scope=""col"">Endereco</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 16 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
       foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th scope=\"row\">");
#nullable restore
#line 19 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
                 Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 20 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
     Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 21 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
     Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 22 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
     Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>    \r\n");
#nullable restore
#line 24 "C:\Users\Guilherme\Documents\Projetos\ProjetoEstags\Views\Entrevistado\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoEstags.Models.Entrevistado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
