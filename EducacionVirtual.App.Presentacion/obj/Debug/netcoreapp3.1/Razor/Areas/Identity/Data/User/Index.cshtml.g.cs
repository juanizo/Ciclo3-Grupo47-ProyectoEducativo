#pragma checksum "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ec628bebdff9ef8b90bbf5fe1b0b820c74f749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Data_User_Index), @"mvc.1.0.view", @"/Areas/Identity/Data/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ec628bebdff9ef8b90bbf5fe1b0b820c74f749", @"/Areas/Identity/Data/User/Index.cshtml")]
    public class Areas_Identity_Data_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EducacionVirtual.App.Presentacion.Areas.Identity.Data.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodigoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 82 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodigoM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4730, "\"", 4753, 1);
#nullable restore
#line 148 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
WriteAttributeValue("", 4745, item.Id, 4745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4806, "\"", 4829, 1);
#nullable restore
#line 149 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
WriteAttributeValue("", 4821, item.Id, 4821, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4884, "\"", 4907, 1);
#nullable restore
#line 150 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
WriteAttributeValue("", 4899, item.Id, 4899, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 153 "D:\Educativa\EducacionVirtual.App\EducacionVirtual.App.Presentacion\Areas\Identity\Data\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EducacionVirtual.App.Presentacion.Areas.Identity.Data.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
