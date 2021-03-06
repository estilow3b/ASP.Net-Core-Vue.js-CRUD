#pragma checksum "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\6. ASP.Net Core + Vue.js CRUD\Fuentes\ASP.Net Core + Vue CRUD\Layer.Aplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490ee5575f561381e4c8a2220f104f7a471075e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490ee5575f561381e4c8a2220f104f7a471075e7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a9ca51cb6c1f4e1ab8196c9b97f2434ac2c78a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\6. ASP.Net Core + Vue.js CRUD\Fuentes\ASP.Net Core + Vue CRUD\Layer.Aplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"appVue\" class=\"container\">\r\n    <div class=\"col-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "490ee5575f561381e4c8a2220f104f7a471075e74159", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""Producto"">Producto:</label>
                <input type=""text"" class=""form-control"" id=""Producto"" v-model=""Filtro"">
            </div>
            <button type=""button"" class=""btn btn-success my-2"" ");
                WriteLiteral("@click=\"postFiltroProductos\">Buscar</button>\r\n            <a href=\"/Home/Nuevo\" class=\"btn btn-primary\">Nuevo</a>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""col-12 mt-4"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">C??digo</th>
                    <th scope=""col"">Producto</th>
                    <th scope=""col"">Cantidad</th>
                    <th scope=""col"">Precio</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""item in ListaProducto"">
                    <template v-if=""item.Editar==true"">
                        <td scope=""row"">{{item.codiProducto}}</td>
                        <td scope=""row""><input v-model=""item.descripcionProducto"" /></td>
                        <td scope=""row""><input v-model=""item.cantidadProducto"" /></td>
                        <td scope=""row""><input v-model=""item.precioProducto"" /></td>
                        <td>
                            <button type=""button"" class=""btn btn-primary"" ");
            WriteLiteral("@click=\"putModificaProducto(item)\">Actualizar</button>\r\n                            <button type=\"button\" class=\"btn btn-danger\" ");
            WriteLiteral(@"@click=""cancelar"">Cancelar</button>
                        </td>
                    </template>
                    <template v-else>
                        <td scope=""row"">{{item.codiProducto}}</td>
                        <td scope=""row"">{{item.descripcionProducto}}</td>
                        <td scope=""row"">{{item.cantidadProducto}}</td>
                        <td scope=""row"">{{item.precioProducto}}</td>
                        <td>
                            <button type=""button"" class=""btn btn-success"" ");
            WriteLiteral("@click=\"editar(item.codiProducto)\">Editar</button>\r\n                            <button type=\"button\" class=\"btn btn-danger\" ");
            WriteLiteral(@"@click=""deleteEliminaProducto(item.codiProducto)"">Eliminar</button>
                        </td>
                    </template>
                </tr>
            </tbody>
        </table>
    </div>
</div>

<script>
    var appVue = new Vue({
        el: ""#appVue"",
        name: ""appVue"",
        data: {
            Filtro: '',
            ListaProducto: [],
        },
        mounted: function () {
            //Se crea esta variable ""_this"" para acceder a las variables 
            //del tag ""data"" y m??todos del tag ""methods""
            let _this = this;

            //Se llama al metodo de listado de producto
            _this.getListaProductos();
        },
        methods: {
            getListaProductos: function () {

                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Se emplea la libreria AXIOS con metodo Http GET para consumir ");
            WriteLiteral(@"
                //un servicio igual de tipo GET. Se ingresa como parametro la URL.
                //La URL es la concatenacion de window.location.origin que obtiene la 
                //URL principal(http://localhost:[Numero Puerto) y con el nombre 
                //de la accion tipo GET (Listar) que realiza el listado de productos
                axios.get(window.location.origin + ""/Listar"").then(response => {

                    //La variable ListaProducto recibe los resultado de la accion GET
                    //con el objeto response.data
                    _this.ListaProducto = response.data;


                    //Ahora se declara un array sin elementos para pasar 
                    //los elementos de la variable ""ListaProducto"" con una 
                    //propiedad adicional ""Editar"" de tipo Booleno(True / False)
                    //La propiedad ""Editar"" se empleara para validar en HTML 
                    //si un registro pasa a estado de edici??n para su luego 
      ");
            WriteLiteral(@"              //actualizaci??n de datos o solo lectura
                    var ListaDetalle = [];

                    //Se recorre los elementos del array ""ListaProducto""
                    for (var x = 0; x <= _this.ListaProducto.length - 1; x++) {
                        //En cada recorrido se crea un objeto ""item"" vacio
                        var item = {};

                        //Se agrega el contenido del elemento del array 
                        //""ListaProducto"" en el objeto ""item""
                        item = _this.ListaProducto[x];

                        //Se agrega la propiedad ""Editar"" con el valor 
                        //predeterminado ""False"" en el objeto item
                        item.Editar = false;

                        //Se agrega el objeto ""item"" en el array ""ListaDetalle""
                        ListaDetalle.push(item);
                    }

                    //Cuando termina el recorrido se reemplaza los elementos
                    //de la vari");
            WriteLiteral(@"able ""ListaProducto"" por el nuevo array ""ListaDetalle""
                    _this.ListaProducto = ListaDetalle;
                });

            },

            postFiltroProductos: async function () {

                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Se crea el objeto con los parametros de filtro de productos
                var request = {};

                //Se asigna a la propiedad DescripcionProducto del objeto request 
                //El valor de filtro de la propiedad DescripcionProducto debe ser 
                //igual en objeto ""JavaScript"" y "".Net Core""
                request.DescripcionProducto = _this.Filtro;

                //Se emplea la libreria ""AXIOS"" con metodo Http ""POST"" para consumir 
                //un servicio igual de tipo POST. Se ingresa como parametro la URL 
                //y el objeto con valores request. La U");
            WriteLiteral(@"RL es la concatenacion de 
                //window.location.origin obtiene la URL principal(http://localhost:[Numero Puerto)
                //y se concatena con el nombre de la accion tipo POST (Filtrar) que realiza 
                //el filtrado de productos con el objeto request
                axios.post(window.location.origin + ""/Filtrar"", request).then(response => {

                    //La variable ListaProducto recibe los resultado de la accion GET
                    //con el objeto response.data
                    _this.ListaProducto = response.data;

                    //Ahora se declara un array sin elementos para pasar 
                    //los elementos de la variable ""ListaProducto"" con una 
                    //propiedad adicional ""Editar"" de tipo Booleno(True / False)
                    //La propiedad ""Editar"" se empleara para validar en HTML 
                    //si un registro pasa a estado de edici??n para su luego 
                    //actualizaci??n de datos o lectu");
            WriteLiteral(@"ra
                    var ListaDetalle = [];

                    //Se recorre los elementos del array ""ListaProducto""
                    for (var x = 0; x <= _this.ListaProducto.length - 1; x++) {

                        //En cada recorrido se crea un objeto vacio
                        var item = {};

                        //Se agrega el contenido del elemento del array 
                        //""ListaProducto"" en el objeto ""item""
                        item = _this.ListaProducto[x];

                        //Se agrega la propiedad ""Editar"" con el valor 
                        //predeterminado ""False"" en el objeto item
                        item.Editar = false;

                        //Se agrega el objeto ""item"" en el array ""ListaDetalle""
                        ListaDetalle.push(item);
                    }

                    //Cuando termina el recorrido se reemplaza los elementos
                    //de la variable ListaProducto por el nuevo array ListaDetalle
    ");
            WriteLiteral(@"                _this.ListaProducto = ListaDetalle;
                });
            },

            putModificaProducto: function (item) {

                //Recibe de parametro el objeto ""item"" con los valores
                //de un producto

                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Se crea el objeto con los parametros de modificacion de producto
                var request = {};

                //Se asigna a las propiedades ""CodiProducto"", ""DescripcionProducto"", 
                //""CantidadProducto"", ""PrecioProducto"" y ""Activo"" del objeto request
                //deben ser igual en objeto ""JavaScript"" y "".Net Core""
                //Los valores asignados al objeto request provienen del objeto parametro ""item""
                request.CodiProducto = parseInt(item.codiProducto);
                request.DescripcionProducto = item.descripci");
            WriteLiteral(@"onProducto;
                request.CantidadProducto = parseInt(item.cantidadProducto);
                request.PrecioProducto = parseFloat(item.precioProducto);
                request.Activo = item.activo;

                //Se emplea la libreria ""AXIOS"" con metodo Http ""PUT"" para consumir 
                //un servicio igual de tipo ""PUT"". Se ingresa como parametro la URL 
                //y el objeto con valores request. La URL es la concatenacion de 
                //window.location.origin obtiene la URL principal(http://localhost:[Numero Puerto)
                //y se concatena con el nombre de la accion tipo PUT (Actualizar) que realiza 
                //la modificaci??n de un producto con el objeto request
                axios.put(window.location.origin + ""/Actualizar"", request).then(response => {

                    //Muestra un mensaje de modificaci??n satisfactoria
                    alert(response.data);

                    //Llama al metodo de filtrado de productos creado ant");
            WriteLiteral(@"eriormente
                    _this.postFiltroProductos();

                    //Llama al metodo que cambia el registro de producto de estado
                    //de edici??n a solo lectura
                    _this.cancelar()
                });
            },

            deleteEliminaProducto: function (Codi_Producto) {
                //Se recibe de parametro el codigo de producto
                //con la variable ""Codi_Producto""

                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Se emplea la libreria ""AXIOS"" con metodo Http ""DELETE"" para consumir 
                //un servicio igual de tipo DELETE. Se ingresa como parametro la URL. 
                //La URL es la concatenacion de window.location.origin obtiene 
                //la URL principal(http://localhost:[Numero Puerto), se concatena con el 
                //nombre de la accion tipo ");
            WriteLiteral(@"DELETE que realiza y el c??digo de producto 
                //(Codi_Producto) para la eliminaci??n de un producto.
                axios.delete(window.location.origin + ""/Eliminar/"" + Codi_Producto).then(response => {

                    //Muestra un mensaje de eliminaci??n satisfactoria
                    alert(response.data);

                    //Llama al metodo de listado de productos creado anteriormente
                    _this.getListaProductos();
                });
            },

            editar: function (Codi_Producto) {
                //Se recibe de parametro el c??digo de producto
                //con la variable ""Codi_Producto""

                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Ahora se declara un array sin elementos para pasar 
                //los elementos de la variable ""ListaProducto"" con una 
                //propiedad ");
            WriteLiteral(@"adicional ""Editar"" de tipo Booleno(True / False)
                //La propiedad ""Editar"" se empleara para validar en HTML 
                //si un registro pasa a estado de edici??n para su luego 
                //actualizaci??n de datos o solo lectura
                var ListaDetalle = [];

                //Se recorre los elementos del array ""ListaProducto""
                for (var x = 0; x <= _this.ListaProducto.length - 1; x++) {

                    //En cada recorrido se crea un objeto vacio
                    var item = {};


                    //Se agrega el contenido del elemento del array 
                    //""ListaProducto"" en el objeto ""item""
                    item = _this.ListaProducto[x];

                    //Se compara seg??n el c??digo de producto (Codi_Producto)
                    //recibido de parametro con el codigo de producto de elemanto 
                    //del array ""ListaProducto"" y cambiar la vista HTML a estado 
                    //de edici??n de datos pa");
            WriteLiteral(@"ra su actualizacion, modificando su 
                    //respectiva propiedad ""Editar"" a ""True""
                    if (Codi_Producto == _this.ListaProducto[x].codiProducto) {
                        item.Editar = true;
                    } else {
                        item.Editar = false;
                    }

                    //Se agrega el objeto ""item"" en el array ""ListaDetalle""
                    ListaDetalle.push(item);
                }

                //Cuando termina el recorrido se reemplaza los elementos
                //de la variable ListaProducto por el nuevo array ListaDetalle
                _this.ListaProducto = ListaDetalle;
            },

            cancelar: function () {
                //Se crea esta variable ""_this"" para acceder a las variables 
                //del tag ""data"" y m??todos del tag ""methods""
                let _this = this;

                //Ahora se declara un array sin elementos para pasar 
                //los elementos de la vari");
            WriteLiteral(@"able ""ListaProducto"" con una 
                //propiedad adicional ""Editar"" de tipo Booleno(True / False)
                //La propiedad ""Editar"" se empleara para validar en HTML 
                //si un registro pasa a estado de edici??n para su luego 
                //actualizaci??n de datos o lectura
                var ListaDetalle = [];

                //Se recorre los elementos del array ""ListaProducto""
                for (var x = 0; x <= _this.ListaProducto.length - 1; x++) {

                    //En cada recorrido se crea un objeto vacio
                    var item = {};

                    //Se agrega el contenido del elemento del array 
                    //""ListaProducto"" en el objeto ""item""
                    item = _this.ListaProducto[x];

                    //Cada propiedad ""Editar"" del elemento del array
                    //recibe el valor ""False""; para que su registro 
                    //producto vuelva a estado de solo lectura
                    item.Editar =");
            WriteLiteral(@" false;

                    //Se agrega el objeto ""item"" en el array ""ListaDetalle""
                    ListaDetalle.push(item);
                }

                //Cuando termina el recorrido se reemplaza los elementos
                //de la variable ListaProducto por el nuevo array ListaDetalle
                _this.ListaProducto = ListaDetalle;
            }
        }
    });
</script>
");
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
