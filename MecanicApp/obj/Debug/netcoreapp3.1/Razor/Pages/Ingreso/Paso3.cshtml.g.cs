#pragma checksum "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ec5d1265fc1b0125ec5ab3e09b7b26551f024a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MecanicApp.Pages.Ingreso.Pages_Ingreso_Paso3), @"mvc.1.0.razor-page", @"/Pages/Ingreso/Paso3.cshtml")]
namespace MecanicApp.Pages.Ingreso
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int?}/{nombre?}/{apellido?}/{idvehiculo:int?}/{matricula?}/{marca?}/{anofab?}/{color?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ec5d1265fc1b0125ec5ab3e09b7b26551f024a", @"/Pages/Ingreso/Paso3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186b3bddfb72eaf750eeb917b95722861d7835f8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ingreso_Paso3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("texto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Ingreso/Paso4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
  
    ViewData["Title"] = "Paso3Model";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ingreso al Taller</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr><th>Datos del Cliente:  ");
#nullable restore
#line 11 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                               Write(Model.Idcliente);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                  Write(Model.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 11 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                  Write(Model.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n        <tr><th>Datos del Vehículo: ");
#nullable restore
#line 12 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                               Write(Model.IdVehiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                   Write(Model.Matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                      Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 12 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                    Write(Model.AnoFab);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 12 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                   Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th></tr>\r\n\r\n    </thead>\r\n</table>\r\n\r\n\r\n<h2>Paso 3 -  ASIGNAR MECANICO</h2>\r\n\r\n\r\n");
#nullable restore
#line 21 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
 if (!string.IsNullOrEmpty(Model.MensajeEliminacion))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"alert-info\">");
#nullable restore
#line 23 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                         Write(Model.MensajeEliminacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 24 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ec5d1265fc1b0125ec5ab3e09b7b26551f024a8865", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-3\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41ec5d1265fc1b0125ec5ab3e09b7b26551f024a9171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 28 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Texto);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <div class=\"input-group-append\">\r\n            <button class=\"input-group-text\" type=\"submit\">Buscar</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nombres</th>\r\n            <th>Apellidos</th>\r\n            <th>Habilidades Reparación</th>\r\n\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 47 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
     foreach (var mecanicos in Model.Mecanicos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> ");
#nullable restore
#line 50 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
    Write(mecanicos.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td>\r\n        ");
#nullable restore
#line 52 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
   Write(mecanicos.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td> ");
#nullable restore
#line 54 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
    Write(mecanicos.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td> ");
#nullable restore
#line 55 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
    Write(mecanicos.HabilidadRep);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ec5d1265fc1b0125ec5ab3e09b7b26551f024a13710", async() => {
                WriteLiteral("Asignar Mecánico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idcliente", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                WriteLiteral(Model.Idcliente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idcliente"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idcliente", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idcliente"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                    WriteLiteral(Model.Nombres);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nombre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nombre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nombre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                        WriteLiteral(Model.Apellidos);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["apellido"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-apellido", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["apellido"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                WriteLiteral(Model.IdVehiculo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idvehiculo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idvehiculo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idvehiculo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                        WriteLiteral(Model.Matricula);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matricula"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-matricula", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matricula"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                           WriteLiteral(Model.Marca);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["marca"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-marca", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["marca"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                                                           WriteLiteral(Model.AnoFab);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["anofab"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-anofab", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["anofab"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                                                                                           WriteLiteral(Model.Color);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["color"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-color", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["color"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                           WriteLiteral(mecanicos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mecid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                WriteLiteral(mecanicos.Nombres);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecnombre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mecnombre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecnombre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            WriteLiteral(mecanicos.Apellidos);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecapellido"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mecapellido", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mecapellido"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 58 "D:\MecanicApp\MecanicApp\Pages\Ingreso\Paso3.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MecanicApp.Pages.Ingreso.Paso3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MecanicApp.Pages.Ingreso.Paso3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MecanicApp.Pages.Ingreso.Paso3Model>)PageContext?.ViewData;
        public MecanicApp.Pages.Ingreso.Paso3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
