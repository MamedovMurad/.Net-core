#pragma checksum "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a16c2d1699d151f9d90c111c2dfefdb74eb05d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderBasket_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderBasket/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a16c2d1699d151f9d90c111c2dfefdb74eb05d3", @"/Views/Shared/Components/HeaderBasket/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d8bd0cd41a50434f6b98d3960b225c1490f631", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderBasket_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart_bt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1 outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
  
        decimal total = 0M;
   

#line default
#line hidden
#nullable disable
            WriteLiteral("<\r\n\r\n        ul class=\"top_tools\">\r\n    <li>\r\n        <div class=\"dropdown dropdown-cart\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a16c2d1699d151f9d90c111c2dfefdb74eb05d36081", async() => {
                WriteLiteral("<strong>");
#nullable restore
#line 13 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                                                           Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"dropdown-menu\">\r\n                <ul>\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                     foreach (var item in Model)
                    {
                        decimal price = item.Product.Price;
                        if (item.Product.Discount != null)
                        {
                            price = item.Product.Price - (item.Product.Price * item.Product.Discount.Percentage / 100);
                        }
                        total += (price * item.Count);


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a16c2d1699d151f9d90c111c2dfefdb74eb05d38594", async() => {
                WriteLiteral("\r\n                                <figure><img src=\"img/products/product_placeholder_square_small.jpg\" data-src=\"img/products/shoes/thumb/1.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1056, "\"", 1062, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"50\" height=\"50\" class=\"lazy\"></figure>\r\n                                <strong><span>");
#nullable restore
#line 28 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                         Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 28 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>");
#nullable restore
#line 28 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                                                                 Write(price.ToString("#.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("₼</strong>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                                                               WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"#0\" class=\"action\"><i class=\"ti-trash\"></i></a>\r\n                        </li>\r\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <li>\r\n                        <a href=\"product-detail-1.html\">\r\n                            <figure><img src=\"img/products/product_placeholder_square_small.jpg\" data-src=\"img/products/shoes/thumb/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1630, "\"", 1636, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""50"" height=""50"" class=""lazy""></figure>
                            <strong><span>1x Armor Okwahn II</span>$110.00</strong>
                        </a>
                        <a href=""0"" class=""action""><i class=""ti-trash""></i></a>
                    </li>
                </ul>

                <div class=""total_drop"">
                    <div class=""clearfix""><strong>Toplam</strong><span>");
#nullable restore
#line 44 "C:\Users\User\Desktop\Allaia\Allaia\Views\Shared\Components\HeaderBasket\Default.cshtml"
                                                                  Write(total.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</span></div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a16c2d1699d151f9d90c111c2dfefdb74eb05d313808", async() => {
                WriteLiteral("Səbətə göz at");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a16c2d1699d151f9d90c111c2dfefdb74eb05d315280", async() => {
                WriteLiteral("Tamamla");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <!-- /dropdown-cart-->
    </li>
    <li>
        <a href=""#0"" class=""wishlist""><span>Wishlist</span></a>
    </li>
    <li>
        <div class=""dropdown dropdown-access"">
            <a href=""account.html"" class=""access_link""><span>Account</span></a>
            <div class=""dropdown-menu"">
                <a href=""account.html"" class=""btn_1"">Sign In or Sign Up</a>
                <ul>
                    <li>
                        <a href=""track-order.html""><i class=""ti-truck""></i>Track your Order</a>
                    </li>
                    <li>
                        <a href=""account.html""><i class=""ti-package""></i>My Orders</a>
                    </li>
                    <li>
                        <a href=""account.html""><i class=""ti-user""></i>My Profile</a>
                    </li>
                    <li>
                        <a href=""help.html""><i class=""ti-help-alt""></i>Help and Faq</a>
         ");
            WriteLiteral(@"           </li>
                </ul>
            </div>
        </div>
        <!-- /dropdown-access-->
    </li>
    <li>
        <a href=""javascript:void(0);"" class=""btn_search_mob""><span>Search</span></a>
    </li>
    <li>
        <a href=""#menu"" class=""btn_cat_mob"">
            <div class=""hamburger hamburger--spin"" id=""hamburger"">
                <div class=""hamburger-box"">
                    <div class=""hamburger-inner""></div>
                </div>
            </div>
            Categories
        </a>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
