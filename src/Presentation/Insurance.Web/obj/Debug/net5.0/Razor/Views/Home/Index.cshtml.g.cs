#pragma checksum "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d6da57d7b0d0d7958016e3b06f78455cb3100e"
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
#line 1 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\_ViewImports.cshtml"
using Insurance.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\_ViewImports.cshtml"
using Insurance.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d6da57d7b0d0d7958016e3b06f78455cb3100e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf498e6711399c53a2b1e2428da234d442fe3f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""home-container"">
    <div class=""row row-cols-1 row-cols-md-3 g-4"">
    <div class=""col"">
        <div class=""card h-100"">
            <img src=""https://www.bupaacibadem.com.tr/media/4656/genc_hasta.jpg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Yatarak Tedavi Teminatı</h5>
                <p class=""card-text"">Yüksek maliyetli risklere karşı korunmak ve güvende hissetmek için.</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                        <button");
            BeginWriteAttribute("href", " href=", 623, "", 660, 1);
#nullable restore
#line 11 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 629, Url.Action("Index","Checkout"), 629, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-sm btn-outline-secondary"">Satın Al</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card h-100"">
            <img src=""https://www.bupaacibadem.com.tr/media/4657/efor.jpg"" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Ayakta Tedavi Teminatı</h5>
                <p class=""card-text"">Yatış gerektirmeyen tedavilerde doktor ziyaretleri ve tetkikler<br />için</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                        <button");
            BeginWriteAttribute("href", " href=", 1378, "", 1415, 1);
#nullable restore
#line 25 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1384, Url.Action("Index","Checkout"), 1384, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-outline-secondary\">Satın Al</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n");
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
