#pragma checksum "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\Rezervasyon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c28aea6b93f0d84690412935d29dd0e9f1ded3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rezervasyon), @"mvc.1.0.view", @"/Views/Home/Rezervasyon.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c28aea6b93f0d84690412935d29dd0e9f1ded3", @"/Views/Home/Rezervasyon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb09db0503d14a9b78c0ad36cf07abe732643c82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rezervasyon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rezervasyon>
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
#nullable restore
#line 2 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\Rezervasyon.cshtml"
  
    ViewData["Title"] = "Rezervasyon";
    Layout = "~/Views/Shared/_Layout.cshtml";

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
                <div class=""-alt form-alt2 center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c28aea6b93f0d84690412935d29dd0e9f1ded34940", async() => {
                WriteLiteral("\r\n                        <div class=\"row clearfix\">\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"girisTarih\"");
                BeginWriteAttribute("value", " value=\"", 773, "\"", 781, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 782, "\"", 814, 1);
#nullable restore
#line 22 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\Rezervasyon.cshtml"
WriteAttributeValue("", 796, Model.GirisTarihi, 796, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"cikisTarih\"");
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1004, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1005, "\"", 1037, 1);
#nullable restore
#line 26 "C:\Users\Lenovo 3020\Desktop\Stajyer\Selman\HotelProject\HotelProject\Views\Home\Rezervasyon.cshtml"
WriteAttributeValue("", 1019, Model.CikisTarihi, 1019, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required autocomplete=\"off\">\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"telefon\"");
                BeginWriteAttribute("value", " value=\"", 1233, "\"", 1241, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"telefon\" required>\r\n                            </div><div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"pansiyon\"");
                BeginWriteAttribute("value", " value=\"", 1411, "\"", 1419, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1420, "\"", 1434, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"odatip\"");
                BeginWriteAttribute("value", " value=\"", 1610, "\"", 1618, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numaranız\" required>\r\n                            </div>\r\n\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"Yetiskin\"");
                BeginWriteAttribute("value", " value=\"", 1830, "\"", 1838, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numaranız\" required>\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"cocuk\"");
                BeginWriteAttribute("value", " value=\"", 2045, "\"", 2053, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numaranız\" required>\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input type=\"text\" name=\"cocuk\"");
                BeginWriteAttribute("value", " value=\"", 2260, "\"", 2268, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numaranız\" required>\r\n                            </div>\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n                            <div class=\"form-group col-md-6\">\r\n                                <input id=\"form_botcheck\" name=\"form_botcheck\" class=\"form-control\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2744, "\"", 2752, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <button class=""btn-1"" type=""submit"" data-loading-text=""Please wait..."">Rezervasyon Onayla <i class=""flaticon-right-arrow-1""></i><span></span></button>
                            </div>
                            <div class=""form-group col-md-6"">
                                <input id=""form_botcheck"" name=""form_botcheck"" class=""form-control"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3152, "\"", 3160, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <button class=""btn-1"" type=""submit"" data-loading-text=""Please wait..."">Rezervasyon İptal Et <i class=""flaticon-right-arrow-1""></i><span></span></button>
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rezervasyon> Html { get; private set; }
    }
}
#pragma warning restore 1591
