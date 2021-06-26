#pragma checksum "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\6. ASP.Net Core + Vue.js CRUD\Fuentes\ASP.Net Core + Vue CRUD\Layer.Aplication\Views\Home\Nuevo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84e54fd91699d466ebd20bdf45bad4adffe8ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Nuevo), @"mvc.1.0.view", @"/Views/Home/Nuevo.cshtml")]
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
#line 1 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\6. ASP.Net Core + Vue.js CRUD\Fuentes\ASP.Net Core + Vue CRUD\Layer.Aplication\Views\_ViewImports.cshtml"
using Layer.Aplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\6. ASP.Net Core + Vue.js CRUD\Fuentes\ASP.Net Core + Vue CRUD\Layer.Aplication\Views\_ViewImports.cshtml"
using Layer.Aplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84e54fd91699d466ebd20bdf45bad4adffe8ace", @"/Views/Home/Nuevo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a9ca51cb6c1f4e1ab8196c9b97f2434ac2c78a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Nuevo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n<div id=\"appVueNuevo\"  class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84e54fd91699d466ebd20bdf45bad4adffe8ace3504", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""producto"">Producto:</label>
            <input type=""text"" class=""form-control"" v-model=""DescripcionProducto"" id=""producto"">
        </div>
        <div class=""form-group"">
            <label for=""cantidad"">Cantidad:</label>
            <input type=""text"" class=""form-control"" v-model=""CantidadProducto"" id=""cantidad"">
        </div>
        <div class=""form-group"">
            <label for=""precio"">Precio:</label>
            <input type=""text"" class=""form-control"" v-model=""PrecioProducto"" id=""precio"">
        </div>
        <div class=""checkbox"">
            <label><input type=""checkbox""v-model=""Activo""> Activo</label>
        </div>
        <button type=""button"" class=""btn btn-success"" ");
                WriteLiteral("@click=\"postGrabaProducto\">Grabar</button>\r\n        <a href=\"/Home\" class=\"btn btn-primary\">Regresar</a>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script>
    var appVueNuevo = new Vue({
        el: ""#appVueNuevo"",
        name: ""appVueNuevo"",
        data: {
            DescripcionProducto: null,//Variable de nombre producto
            CantidadProducto: null,//Variable de cantidad producto
            PrecioProducto: null,//Variable de precio producto
            Activo: false,//Variable de estado producto
        },
        methods: {
            postGrabaProducto: function () {
                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y métodos del tag ""methods""
                let _this = this;

                //Se crea el objeto con los parametros de registro de producto
                var request = {};

                //Se asigna a las propiedades ""DescripcionProducto"", 
                //""CantidadProducto"", ""PrecioProducto"" y ""Activo"" del objeto request
                //deben ser igual en objeto ""JavaScript"" y "".Net Core""
                //Los valores asi");
            WriteLiteral(@"gnados al objeto request provienen del objeto parametro ""item""
                request.DescripcionProducto = _this.DescripcionProducto;
                request.CantidadProducto = parseInt(_this.CantidadProducto);
                request.PrecioProducto = parseFloat(_this.PrecioProducto);
                request.Activo = _this.Activo;

                //Se emplea la libreria ""AXIOS"" con metodo Http ""POST"" para consumir 
                //un servicio igual de tipo ""POST"". Se ingresa como parametro la URL
                //y el objeto con valores request. La URL es la concatenacion de 
                //window.location.origin obtiene la URL principal(http://localhost:[Numero Puerto)
                //y se concatena con el nombre de la accion tipo POST (Grabar) que realiza
                //el registro de un producto con el objeto request
                axios.post(window.location.origin + ""/Grabar"", request).then(response => {

                    //Muestra un mensaje de registro satisfactorio
    ");
            WriteLiteral("                alert(response.data);\r\n                });\r\n            },\r\n\r\n        },\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
