#pragma checksum "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f06b064058173208f62952b0fbf8a2af0f76d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pansiyonlar_Pansiyonlar), @"mvc.1.0.view", @"/Areas/Admin/Views/Pansiyonlar/Pansiyonlar.cshtml")]
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
#line 1 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\_ViewImports.cshtml"
using HotelProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\_ViewImports.cshtml"
using HotelProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f06b064058173208f62952b0fbf8a2af0f76d25", @"/Areas/Admin/Views/Pansiyonlar/Pansiyonlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09db0503d14a9b78c0ad36cf07abe732643c82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pansiyonlar_Pansiyonlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.Models.Pansiyonlar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
  
    ViewData["Title"] = "Pansiyonlar";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Pansiyonlar</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->

        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->

            <div class=""card"">
                <div class=""card-header"">
                    <a href=""/Admin/Pansiyonlar/YeniPansiyon"" type=""button"" class=""btn btn-success"">Pansiyon Ekle</a>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                ");
            WriteLiteral(@"                <th>#</th>
                                <th>Başlık</th>
                                <th>Ücret</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
                               Write(item.Idno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
                               Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
                               Write(item.Ucret.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
            WriteLiteral("                                    <a style=\"margin-right: 4px;\"");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2101, 2);
            WriteAttributeValue("", 2059, "/Admin/Pansiyonlar/YeniPansiyon/", 2059, 32, true);
#nullable restore
#line 49 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
WriteAttributeValue("", 2091, item.Idno, 2091, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-tbl-edit btn-xs btn-secondary\" title=\"Düzenle\"><i class=\"fa-solid fa-pencil\"></i></a>\r\n                                    <a style=\"margin-right: 4px;\"");
            BeginWriteAttribute("href", " href=\"", 2270, "\"", 2318, 2);
            WriteAttributeValue("", 2277, "/Admin/Pansiyonlar/PansiyonSil/", 2277, 31, true);
#nullable restore
#line 50 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
WriteAttributeValue("", 2308, item.Idno, 2308, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-tbl-edit btn-xs btn-danger\" title=\"Sil\"><i class=\"fa-solid fa-trash\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Pansiyonlar\Pansiyonlar.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /.content-wrapper -->
            <!-- Control Sidebar -->
            <aside class=""control-sidebar control-sidebar-dark"">
                <!-- Control sidebar content goes here -->
            </aside>
            <!-- /.control-sidebar -->
        </div>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.Models.Pansiyonlar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
