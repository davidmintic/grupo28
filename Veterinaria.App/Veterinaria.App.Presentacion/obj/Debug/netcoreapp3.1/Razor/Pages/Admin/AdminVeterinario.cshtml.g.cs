#pragma checksum "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d144abb9db6b6eb0286a8050b0daf9c1ef499a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Admin.Pages_Admin_AdminVeterinario), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminVeterinario.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Admin
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
#line 1 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d144abb9db6b6eb0286a8050b0daf9c1ef499a5", @"/Pages/Admin/AdminVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_AdminVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n<h1 style=\"margin: 25px 0px; color: gray; font-size: 21px;\">");
#nullable restore
#line 6 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                                                       Write(Model.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""accordion"" id=""accordionExample"">


    <div class=""card"">
        <div class=""card-header"" id=""headingTwo"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseListaVeterinarios"" aria-expanded=""true""
                    aria-controls=""collapseListaVeterinarios"">
                    Lista veterinarios
                </button>
            </h2>
        </div>

        <div id=""collapseListaVeterinarios"" class=""collapse show"" aria-labelledby=""headingOne""
            data-parent=""#accordionExample"">
            <div class=""card-body"">




                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Telefono</th>
                            <th scope=""");
            WriteLiteral("col\">Correo</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                         foreach(Veterinario v in Model.listaVeterinarios ){


#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tr>\r\n                                <th scope=\"row\">1</th>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                               Write(v.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                               Write(v.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                               Write(v.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\SIGMA\Desktop\Código Mintic Ciclo 3\ProyectoMinticCiclo3G28\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Admin\AdminVeterinario.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>


            </div>
        </div>

    </div>


    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseCrudVeterinario"" aria-expanded=""true"" aria-controls=""collapseCrudVeterinario"">
                    Crud Veterinario
                </button>
            </h2>
        </div>

        <div id=""collapseCrudVeterinario"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
            <div class=""card-body"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d144abb9db6b6eb0286a8050b0daf9c1ef499a57523", async() => {
                WriteLiteral(@"

                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-admin-veterinario-nombre"">Nombre</label>
                                    <input type=""email"" class=""form-control"" id=""id-admin-veterinario-nombre""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with
                                        anyone
                                        else.</small>
                                </div>
                            </div>
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-admin-veterinario-telefono"">Teléfono</label>
                                    <input ");
                WriteLiteral(@"type=""tel"" class=""form-control"" id=""id-admin-veterinario-telefono""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with
                                        anyone
                                        else.</small>
                                </div>
                            </div>
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-admin-veterinario-edad"">Edad</label>
                                    <input type=""number"" class=""form-control"" id=""id-admin-veterinario-edad""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with
                                        anyone
                                    ");
                WriteLiteral(@"    else.</small>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-admin-veterinario-direccion"">Dirección</label>
                                    <input type=""text"" class=""form-control"" id=""id-admin-veterinario-direccion""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with
                                        anyone
                                        else.</small>
                                </div>
                            </div>
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-a");
                WriteLiteral(@"dmin-veterinario-correo"">Correo</label>
                                    <input type=""email"" class=""form-control"" id=""id-admin-veterinario-correo""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with
                                        anyone
                                        else.</small>
                                </div>
                            </div>
                            <div class=""col-sm"">
                                <div class=""form-group"">
                                    <label for=""id-admin-veterinario-contrasenia"">Contraseña</label>
                                    <input type=""password"" class=""form-control"" id=""id-admin-veterinario-contrasenia""
                                        aria-describedby=""emailHelp"">
                                    <small id=""emailHelp"" class=""form-text text-muted"">We'll never s");
                WriteLiteral(@"hare your email with
                                        anyone
                                        else.</small>
                                </div>
                            </div>
                        </div>
                    </div>

                    <button class=""btn btn-primary"">Agregar</button>
                ");
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
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.AdminVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.AdminVeterinarioModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.AdminVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591