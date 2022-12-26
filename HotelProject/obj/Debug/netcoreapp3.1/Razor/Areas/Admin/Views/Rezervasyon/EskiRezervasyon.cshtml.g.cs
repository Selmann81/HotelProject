#pragma checksum "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e845f01a0dc7d3277355d5804e0552fe18815cd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Rezervasyon_EskiRezervasyon), @"mvc.1.0.view", @"/Areas/Admin/Views/Rezervasyon/EskiRezervasyon.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e845f01a0dc7d3277355d5804e0552fe18815cd3", @"/Areas/Admin/Views/Rezervasyon/EskiRezervasyon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09db0503d14a9b78c0ad36cf07abe732643c82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Rezervasyon_EskiRezervasyon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.Models.Rezervasyon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
  
    ViewData["Title"] = "EskiRezervasyon";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Eski Rezervasyonlar</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->

        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Eski rezervasyonları bu tablodan görebilirsiniz.</h3>
            </div>
            <!-- /.card-header -->
            <div class=""card-body"">
                <table id=""example1"" class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>Oda Tipi</th>
               ");
            WriteLiteral(@"             <th>Müşteri Adı</th>
                            <th>Giriş Tarihi</th>
                            <th>Çıkış Tarihi</th>
                            <th>Pansiyon</th>
                            <th>Durum</th>
                            <th>İşlem</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 44 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                         foreach (var item in Model)
                        {
                            string durum = "";
                            if (item.Act == 1)
                                durum = "Beklemede";
                            else if (item.Act == 2)
                                durum = "Odada";
                            else if (item.Act == 3)
                                durum = "Çıkış Yaptı";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(item.OdaTip.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(item.Musteri.Adisoyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(item.GirisTarihi.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(item.CikisTarihi.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(item.Pansiyonlars.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
                               Write(durum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a style=\"margin-right: 4px;\"");
            BeginWriteAttribute("href", " href=\"", 2538, "\"", 2591, 2);
            WriteAttributeValue("", 2545, "/Admin/Rezervasyon/RezervasyonGetir/", 2545, 36, true);
#nullable restore
#line 61 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
WriteAttributeValue("", 2581, item.Idno, 2581, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-tbl-edit btn-xs btn-secondary\" title=\"Detay\"><i class=\"fa-solid fa-magnifying-glass\"></i></a>\r\n                                    <a style=\"margin-right: 4px;\"");
            BeginWriteAttribute("href", " href=\"", 2768, "\"", 2819, 2);
            WriteAttributeValue("", 2775, "/Admin/Rezervasyon/RezervasyonSil/", 2775, 34, true);
#nullable restore
#line 62 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
WriteAttributeValue("", 2809, item.Idno, 2809, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-tbl-edit btn-xs btn-danger\" title=\"Sil\"><i class=\"fa-solid fa-trash\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\EskiRezervasyon.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.Models.Rezervasyon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
