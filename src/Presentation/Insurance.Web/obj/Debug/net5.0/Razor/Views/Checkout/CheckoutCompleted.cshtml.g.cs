#pragma checksum "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\CheckoutCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b4e4e28930a1abf297d308b75601daf3c534d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_CheckoutCompleted), @"mvc.1.0.view", @"/Views/Checkout/CheckoutCompleted.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b4e4e28930a1abf297d308b75601daf3c534d1", @"/Views/Checkout/CheckoutCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf498e6711399c53a2b1e2428da234d442fe3f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_CheckoutCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal modal-sheet position-static d-block bg-secondary py-5"" tabindex=""-1"" role=""dialog"" id=""modalSheet"" style=""backgroundcolor:white!important"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content rounded-6 shadow"">
            <div class=""modal-header border-bottom-0"">
                <h5 class=""modal-title"">Sigorta işlemleri</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body py-0"">
                <p>Tebrikler işlem tamamlandı</p>
            </div>
            <div class=""modal-footer flex-column border-top-0"">
                ");
#nullable restore
#line 12 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\CheckoutCompleted.cshtml"
           Write(Html.ActionLink("Ana Sayfa","Index","Home",null,new {@class="btn btn-lg btn-primary w-100 mx-0 mb-2",@text="Ana sayfa"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
