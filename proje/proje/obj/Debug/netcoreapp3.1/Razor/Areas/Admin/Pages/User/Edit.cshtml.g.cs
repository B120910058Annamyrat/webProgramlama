#pragma checksum "C:\Users\mmuha\source\repos\webProgramlama\proje\proje\Areas\Admin\Pages\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2421db465e31d97e6341b6e1d7ce3080ea8b8e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_User_Edit), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/User/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2421db465e31d97e6341b6e1d7ce3080ea8b8e8f", @"/Areas/Admin/Pages/User/Edit.cshtml")]
    public class Areas_Admin_Pages_User_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mmuha\source\repos\webProgramlama\proje\proje\Areas\Admin\Pages\User\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Pages/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Kullanici</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Kullanici.Id"" />
            <div class=""form-group"">
                <label asp-for=""Kullanici.Ad"" class=""control-label""></label>
                <input asp-for=""Kullanici.Ad"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.Ad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.Soyad"" class=""control-label""></label>
                <input asp-for=""Kullanici.Soyad"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.Soyad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.Email"" class=""control-label""></label>
                <input asp-for=""Kullanici.Email""");
            WriteLiteral(@" class=""form-control"" />
                <span asp-validation-for=""Kullanici.Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.TelNo"" class=""control-label""></label>
                <input asp-for=""Kullanici.TelNo"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.TelNo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.Password"" class=""control-label""></label>
                <input asp-for=""Kullanici.Password"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.DogumTarih"" class=""control-label""></label>
                <input asp-for=""Kullanici.DogumTarih"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.DogumTarih"" class=""text-");
            WriteLiteral(@"danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.KimlikNo"" class=""control-label""></label>
                <input asp-for=""Kullanici.KimlikNo"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.KimlikNo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.KullaniciTuru"" class=""control-label""></label>
                <input asp-for=""Kullanici.KullaniciTuru"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.KullaniciTuru"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Kullanici.Cinsiyet"" class=""control-label""></label>
                <input asp-for=""Kullanici.Cinsiyet"" class=""form-control"" />
                <span asp-validation-for=""Kullanici.Cinsiyet"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
    ");
            WriteLiteral("            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<proje.Areas.Admin.Pages.User.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<proje.Areas.Admin.Pages.User.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<proje.Areas.Admin.Pages.User.EditModel>)PageContext?.ViewData;
        public proje.Areas.Admin.Pages.User.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591