#pragma checksum "C:\TopicosAvancadosEmSistemasDeInformacaoII\SolutionLocacao\ProjLocacaoWebApp\Views\Carros\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c537a307d1f15b26c22d7c7d81ca3179b48b412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Edit), @"mvc.1.0.view", @"/Views/Carros/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c537a307d1f15b26c22d7c7d81ca3179b48b412", @"/Views/Carros/Edit.cshtml")]
    public class Views_Carros_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjCarros.Model.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\TopicosAvancadosEmSistemasDeInformacaoII\SolutionLocacao\ProjLocacaoWebApp\Views\Carros\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Carro</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cor"" class=""control-label""></label>
                <input asp-for=""Cor"" class=""form-control"" />
                <span asp-validation-for=""Cor"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Ano"" class=""control-label""></label>
                <input asp-for=""Ano"" class=""form-control"" />
                <span asp-validation-for=""Ano"" class=""text-danger""><");
            WriteLiteral(@"/span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Modelo"" class=""control-label""></label>
                <input asp-for=""Modelo"" class=""form-control"" />
                <span asp-validation-for=""Modelo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Placa"" class=""control-label""></label>
                <input asp-for=""Placa"" class=""form-control"" />
                <span asp-validation-for=""Placa"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\TopicosAvancadosEmSistemasDeInformacaoII\SolutionLocacao\ProjLocacaoWebApp\Views\Carros\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjCarros.Model.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591
