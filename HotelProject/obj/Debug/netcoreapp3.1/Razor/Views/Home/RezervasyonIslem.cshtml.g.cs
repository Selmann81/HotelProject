#pragma checksum "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\RezervasyonIslem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d780a2cc80b6fce0f8a31fc3460d5c43153768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RezervasyonIslem), @"mvc.1.0.view", @"/Views/Home/RezervasyonIslem.cshtml")]
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
#line 1 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\_ViewImports.cshtml"
using HotelProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\_ViewImports.cshtml"
using HotelProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d780a2cc80b6fce0f8a31fc3460d5c43153768", @"/Views/Home/RezervasyonIslem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09db0503d14a9b78c0ad36cf07abe732643c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RezervasyonIslem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezervasyon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\RezervasyonIslem.cshtml"
  
    ViewData["Title"] = "RezervasyonIslem";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section-padding gray-bg"">
    <div class=""auto-container"">
        <div class=""section_heading text-center mb_55"">
            <h2 class=""section_heading_title_big"">
                Rezervasyon İşlemi
            </h2>
        </div>
        <div class=""row"">
            <div class=""col-lg-8 offset-lg-2"">
                <div class=""form-alt form-alt2 center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d780a2cc80b6fce0f8a31fc3460d5c431537685011", async() => {
                WriteLiteral("\r\n                        <div class=\"row clearfix\">\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"OdaTipId\"");
                BeginWriteAttribute("value", " value=\"", 763, "\"", 771, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Oda Tipi\" required>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"cıkısTarihi\"");
                BeginWriteAttribute("value", " value=\"", 977, "\"", 985, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Çıkış Tarihi\" required autocomplete=\"off\">\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"form_name\"");
                BeginWriteAttribute("value", " value=\"", 1212, "\"", 1220, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numaranız\" required>\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"form_name\"");
                BeginWriteAttribute("value", " value=\"", 1431, "\"", 1439, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Telefon Numaranız"" required>
                            </div>

                            <div class=""form-group col-md-12"">
                                <textarea name=""form_message"" placeholder=""Mesajınız""></textarea>
                            </div>

                            <div class=""form-group col-md-12"">
                                <p><input type=""checkbox"" id=""vehicle1"" name=""vehicle1"" value=""Bike""> Oda Kahvaltısı</p>
                            </div>

                            <div class=""form-group col-md-12"">
                                <input id=""form_botcheck"" name=""form_botcheck"" class=""form-control"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2124, "\"", 2132, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <button class=""btn-1"" type=""submit"" data-loading-text=""Please wait..."">Rezervasyon Onayla <i class=""flaticon-right-arrow-1""></i><span></span></button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
