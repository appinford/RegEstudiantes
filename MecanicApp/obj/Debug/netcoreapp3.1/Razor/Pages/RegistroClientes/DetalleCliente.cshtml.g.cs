#pragma checksum "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5458a0bc767fb7b0514a2276e274e7b628029450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MecanicApp.Pages.RegistroClientes.Pages_RegistroClientes_DetalleCliente), @"mvc.1.0.razor-page", @"/Pages/RegistroClientes/DetalleCliente.cshtml")]
namespace MecanicApp.Pages.RegistroClientes
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
#line 1 "D:\MecanicApp\MecanicApp\Pages\_ViewImports.cshtml"
using MecanicApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5458a0bc767fb7b0514a2276e274e7b628029450", @"/Pages/RegistroClientes/DetalleCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186b3bddfb72eaf750eeb917b95722861d7835f8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroClientes_DetalleCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./RegistroClientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
  
    ViewData["Title"] = "DetalleCliente";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalle Cliente</h1>\r\n\r\n<h2>");
#nullable restore
#line 10 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
Write(Model.Cliente.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
                      Write(Model.Cliente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div>\r\n        <label style=\"font-weight:bold\">Id:</label>\r\n        <br />\r\n        ");
#nullable restore
#line 14 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
   Write(Model.Cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label style=\"font-weight:bold\">Cedula:</label>\r\n        <br />\r\n        ");
#nullable restore
#line 19 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
   Write(Model.Cliente.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label style=\"font-weight:bold\">Dirección:</label>\r\n        <br />\r\n        ");
#nullable restore
#line 24 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
   Write(Model.Cliente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label style=\"font-weight:bold\">Sector: </label>\r\n        <br />\r\n        ");
#nullable restore
#line 29 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
   Write(Model.Cliente.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label style=\"font-weight:bold\">Ciudad: </label>\r\n        <br />\r\n        ");
#nullable restore
#line 34 "D:\MecanicApp\MecanicApp\Pages\RegistroClientes\DetalleCliente.cshtml"
   Write(Model.Cliente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5458a0bc767fb7b0514a2276e274e7b6280294506044", async() => {
                WriteLiteral("Volver a Consulta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MecanicApp.Pages.RegistroClientes.DetalleClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MecanicApp.Pages.RegistroClientes.DetalleClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MecanicApp.Pages.RegistroClientes.DetalleClienteModel>)PageContext?.ViewData;
        public MecanicApp.Pages.RegistroClientes.DetalleClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
