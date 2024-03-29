#pragma checksum "C:\Users\Oregomoditse Makinta\Documents\CODE\Dr CC Khan\Pages\InWebPages\FindUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3889142b601c52f11c20ae8a3cb8921b02141d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Dr_CC_Khan.Pages.InWebPages.Pages_InWebPages_FindUs), @"mvc.1.0.razor-page", @"/Pages/InWebPages/FindUs.cshtml")]
namespace Dr_CC_Khan.Pages.InWebPages
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
#line 1 "C:\Users\Oregomoditse Makinta\Documents\CODE\Dr CC Khan\Pages\_ViewImports.cshtml"
using Dr_CC_Khan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3889142b601c52f11c20ae8a3cb8921b02141d47", @"/Pages/InWebPages/FindUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b60a61572d01521364b40abaf0638a05c1e3a78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_InWebPages_FindUs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Oregomoditse Makinta\Documents\CODE\Dr CC Khan\Pages\InWebPages\FindUs.cshtml"
  
    ViewData["Title"] = "Find Us page";
    ViewData["API"] = "AIzaSyDAmItCiVujZFYAjTu-uQgMspGIs5gte-4";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .mail{
        grid-area: mail;
    }
    .email{
        grid-area: email; 
    }
    .number{
        grid-area: phone;
    }
    .map{
        grid-area: map;
    }
    .grid-template{
        display: grid;
        grid-template-areas:
            'mail mail mail map'
            'email email email map'
            'phone phone phone map';
        grid-gap: 25px;
    }
    #map {
        height: 400px;
        width: 600px; 
    }
</style>

<div class=""grid-template"">
    <div class=""mail"">
        <h3 style="" color: #016FA0;"">Mail Address</h3>
        <br />
        <p>
            327 St Joseph Ave <br />
            Eersterust <br />
            Pretoria <br />
            0022
        </p>
    </div>
    <div class=""email"">
        <h3 style=""color: #63A103; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;"">Email Address</h3>
        <br />
        <p>surgery@drcckhan.co.za<br />Chriskhan@honeyfax.co.za</p>
    </div>
    <div class=");
            WriteLiteral(@"""number"">
        <h3 style=""color: #00AAAA; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;"">Phone Number</h3>
        <br />
        <p>(012) 065 0489</p>
    </div>
    <div class=""map"">
        <h3 style=""color: #555555; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; "">Locate Dr Khan on Map</h3>
        <br />
        <!--AIzaSyDAmItCiVujZFYAjTu-uQgMspGIs5gte-4-->
        <script async");
            BeginWriteAttribute("src", "\r\n                src=\"", 1623, "\"", 1725, 3);
            WriteAttributeValue("", 1646, "https://maps.googleapis.com/maps/api/js?key=", 1646, 44, true);
#nullable restore
#line 61 "C:\Users\Oregomoditse Makinta\Documents\CODE\Dr CC Khan\Pages\InWebPages\FindUs.cshtml"
WriteAttributeValue("", 1690, ViewData["API"], 1690, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1708, "&callback=initMap", 1708, 17, true);
            EndWriteAttribute();
            WriteLiteral(@">
        </script>
        <div id=""map""></div>
        <script>
            var map;
            function initMap() {
                map = new google.maps.Map(document.getElementById('map'), {
                    center: {
                        lat: -25.71543, lng: 28.31404},
                    zoom: 8
                });
            }
        </script>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dr_CC_Khan.Pages.InWebPages.FindUsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Dr_CC_Khan.Pages.InWebPages.FindUsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Dr_CC_Khan.Pages.InWebPages.FindUsModel>)PageContext?.ViewData;
        public Dr_CC_Khan.Pages.InWebPages.FindUsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
