#pragma checksum "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b03329c55fff3944e343f0f7ff1f0eacc706023f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Rezervasyon_RezervasyonGetir), @"mvc.1.0.view", @"/Areas/Admin/Views/Rezervasyon/RezervasyonGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03329c55fff3944e343f0f7ff1f0eacc706023f", @"/Areas/Admin/Views/Rezervasyon/RezervasyonGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09db0503d14a9b78c0ad36cf07abe732643c82", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Rezervasyon_RezervasyonGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelProject.ViewModels.Site.RezervasyonDetayViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
  
    ViewData["Title"] = "RezervasyonGetir";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">
            Rezervasyon Detay
        </h3>
    </div>
    <div class=""page-content-wrapper"">
        <div class=""page-content"">

            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card card-box"">
                        <div class=""card-head"">
                        </div>
                        <div class=""card-body "">
                            <div id=""biography"">
                                <div class=""row"">
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Oda No</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 26 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.OdaNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Oda Adı</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 31 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.OdaAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Pansiyon</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 36 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.Pansiyon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6"">
                                        <strong>Oda Tipi</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 41 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.OdaTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Giriş Tarihi</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 48 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.GirisTarihi.ToString("dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Çıkış Tarihi</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 53 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.CikisTarihi.ToString("dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Ücret</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 58 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.Ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6"">
                                        <strong>Ek Ücret</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 63 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.EkUcret);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12 col-12 b-r"">
                                        <strong>Açıklama</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 70 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <hr>
                                <div class=""row mt-3"">

                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Uyruk</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 79 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.MusteriViewModel.Uyruk);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Kimlik No</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 84 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.MusteriViewModel.TCNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""col-md-3 col-6 b-r"">
                                        <strong>Adı Soyadı - Telefon</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 89 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.MusteriViewModel.AdiSoyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 89 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                                                             Write(Model.MusteriViewModel.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                    </div>
                                    <div class=""col-md-3 col-6"">
                                        <strong>Dogum Tarihi</strong>
                                        <br>
                                        <p class=""text-muted"">");
#nullable restore
#line 94 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Areas\Admin\Views\Rezervasyon\RezervasyonGetir.cshtml"
                                                         Write(Model.MusteriViewModel.DogumTarihi.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelProject.ViewModels.Site.RezervasyonDetayViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
