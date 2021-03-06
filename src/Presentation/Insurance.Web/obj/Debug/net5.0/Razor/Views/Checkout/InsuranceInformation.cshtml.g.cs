#pragma checksum "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b667706b6b69bb0976d8bac60f5758327d9372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_InsuranceInformation), @"mvc.1.0.view", @"/Views/Checkout/InsuranceInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b667706b6b69bb0976d8bac60f5758327d9372", @"/Views/Checkout/InsuranceInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf498e6711399c53a2b1e2428da234d442fe3f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_InsuranceInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsuredRegistrationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"checkout-seconder-form\">\r\n    <h3>Sigortalı Kayıt Formu</h3>\r\n");
#nullable restore
#line 7 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
     using (Html.BeginForm("SaveInsurance", "Checkout", FormMethod.Post, new { @id = "frmInsured", @class = "row g-3" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <label class=\"form-label\">Ad</label>\r\n            ");
#nullable restore
#line 11 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.NAME, new{@class = "form-control",@placeholder="Ad",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label class=\"form-label\">Soyad</label>\r\n            ");
#nullable restore
#line 15 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.SURNAME, new{@class = "form-control",@placeholder="Soyad",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row justify-content-md-center\">\r\n            <div class=\"col-md-auto\">\r\n                <label class=\"form-label\">Cinsiyet</label>\r\n                ");
#nullable restore
#line 20 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
           Write(Html.DropDownListFor(x => x.GENDER,new []{new SelectListItem{Text="Erkek",Value="Erkek"},new SelectListItem{Text="Kadın",Value="Kadın"}},new{@class="form-select",@placeholder="Cinsiyet",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-auto\">\r\n                <label class=\"form-label\">Doğum Tarihi</label>\r\n                ");
#nullable restore
#line 24 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
           Write(Html.DropDownListFor(x => x.BIRTHDATE,new []{new SelectListItem{Text="2003",Value="01/01/2003"},new SelectListItem{Text="2002",Value="01/01/2002"},new SelectListItem{Text="2001",Value="01/01/2001"}},new{@class="form-select",@placeholder="Cinsiyet",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-auto\">\r\n                <label class=\"form-label\">Uyruk</label>\r\n                ");
#nullable restore
#line 28 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
           Write(Html.DropDownListFor(x=> x.NATIONALITY, new[]{new SelectListItem{Text="Türkiye",Value="Türkiye"},new SelectListItem{Text="Kıbrıs",Value="Kıbris"}},new{@class="form-select",@placeholder="Uyruk",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-auto\">\r\n                <label class=\"form-label\">Yakınlık</label>\r\n                ");
#nullable restore
#line 32 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
           Write(Html.DropDownListFor(x=> x.PROXIMITYID, new[]{new SelectListItem{Text="Eş",Value="1"},new SelectListItem{Text="Çocuk",Value="2"}},new{@class="form-select",@placeholder="Yakınlık Seçiniz",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label class=\"form-label\">Kimlik Numarası</label>\r\n            ");
#nullable restore
#line 37 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.IDENTIFICATIONNUMBER, new{@class = "form-control",@placeholder="Kimlik Numarası",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label class=\"form-label\">Telefon Numarası</label>\r\n            ");
#nullable restore
#line 41 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.PHONE, new{@class = "form-control",@placeholder="Telefon Numarası",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label class=\"form-label\">Email</label>\r\n            ");
#nullable restore
#line 45 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.EMAIL, new{@class = "form-control",@placeholder="Email",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <label for=\"inputAddress\" class=\"form-label\">Addres</label>\r\n            ");
#nullable restore
#line 49 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.ADRESS, new{@class = "form-control",@placeholder="Adres",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-md-6"">
            <input class=""btn btn-primary"" type=""button"" id=""btnSave"" value=""Kaydet"" onclick=""sendData();"">
        </div>
        <div class=""col-md-6"">
            <label class=""form-label"">Müşteri Numarası</label>
            ");
#nullable restore
#line 56 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
       Write(Html.TextBoxFor(x=> x.CUSTOMERID, new{@class = "form-control",@placeholder =@Model.CUSTOMERID,@readonly="readonly",@required = "required"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 58 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<script>\r\n    function sendData() {\r\n        var sendForm = $(\"#frmInsured\").serialize();\r\n\r\n        $.ajax({\r\n            type: \'POST\',\r\n            url: \'");
#nullable restore
#line 66 "C:\Sandbox\Insurance\src\Presentation\Insurance.Web\Views\Checkout\InsuranceInformation.cshtml"
             Write(Url.Action("SaveInsurance","Checkout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: sendForm,\r\n            success: function(result) {\r\n                 if(result.status === true)\r\n            window.location.href = result.redirectUrl;\r\n            }\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsuredRegistrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
