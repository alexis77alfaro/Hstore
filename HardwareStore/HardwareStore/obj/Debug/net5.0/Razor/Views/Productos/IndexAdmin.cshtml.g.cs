#pragma checksum "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c40392ad4dc66a5a303b4cd579f37780d82abddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_IndexAdmin), @"mvc.1.0.view", @"/Views/Productos/IndexAdmin.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\_ViewImports.cshtml"
using HardwareStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\_ViewImports.cshtml"
using HardwareStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c40392ad4dc66a5a303b4cd579f37780d82abddb", @"/Views/Productos/IndexAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e0356389c518fc87386ff85a4537b6a8a19ffa", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_IndexAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Productos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h3>Lista de Productos</h3>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40392ad4dc66a5a303b4cd579f37780d82abddb5051", async() => {
                WriteLiteral("Agregar Nuevo Producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                   Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 21 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                   Write(Html.DisplayNameFor(m => m.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 22 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                   Write(Html.DisplayNameFor(m => m.PrecioInicial));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 23 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                   Write(Html.DisplayNameFor(m => m.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 24 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                   Write(Html.DisplayNameFor(m => m.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">Opciones</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                           Write(item.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                           Write(item.PrecioInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                           Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c40392ad4dc66a5a303b4cd579f37780d82abddb10722", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <!--<a asp-controller=\"Productos\" asp-action=\"EliminarProducto\" asp-route-id=\"");
#nullable restore
#line 39 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger\">Eliminar</a>-->\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 45 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen productos registrados!</p>\r\n");
#nullable restore
#line 49 "C:\Users\pc\Desktop\Ferreteria\Hstore\HardwareStore\HardwareStore\Views\Productos\IndexAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
