#pragma checksum "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f8aca8277f688d05341025d658d64465fad11f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Banner_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Banner/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Allaia\Allaia\Views\_ViewImports.cshtml"
using Allaia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Allaia\Allaia\Views\_ViewImports.cshtml"
using Allaia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f8aca8277f688d05341025d658d64465fad11f", @"/Views/Shared/Components/Banner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d8bd0cd41a50434f6b98d3960b225c1490f631", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Banner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopCollectionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <ul id=\"banners_grid\" class=\"clearfix\">\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 177, "\"", 198, 1);
#nullable restore
#line 7 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
WriteAttributeValue("", 184, item.EndPoint, 184, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img_container\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 248, "\"", 273, 2);
            WriteAttributeValue("", 254, "Uploads/", 254, 8, true);
#nullable restore
#line 8 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
WriteAttributeValue("", 262, item.Image, 262, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-src=\"Uploads/");
#nullable restore
#line 8 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
                                                                Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 305, "\"", 311, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"lazy\">\r\n                    <div class=\"short_info opacity-mask\" data-opacity-mask=\"rgba(0, 0, 0, 0.5)\">\r\n                        <h3>");
#nullable restore
#line 10 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div><span class=\"btn_1\">Etrafli</span></div>\r\n                    </div>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 15 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\Banner\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n    </ul>\r\n<!--/banners_grid -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopCollectionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
