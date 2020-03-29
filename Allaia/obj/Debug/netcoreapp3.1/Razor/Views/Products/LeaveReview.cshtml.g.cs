#pragma checksum "C:\Users\User\Desktop\Allaia\Allaia\Views\Products\LeaveReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d65003fb705d8d092f811f96e645deda80e6bce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_LeaveReview), @"mvc.1.0.view", @"/Views/Products/LeaveReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65003fb705d8d092f811f96e645deda80e6bce2", @"/Views/Products/LeaveReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d8bd0cd41a50434f6b98d3960b225c1490f631", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_LeaveReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/leave_review.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Allaia\Allaia\Views\Products\LeaveReview.cshtml"
  
    ViewData["Title"] = "AddReview";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>


    <div class=""container margin_60_35"">

        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""write_review"">
                    <h1>Write a review for Armor Air X Fear</h1>
                    <div class=""rating_submit"">
                        <div class=""form-group"">
                            <label class=""d-block"">Overall rating</label>
                            <span class=""rating mb-0"">
                                <input type=""radio"" class=""rating-input"" id=""5_star"" name=""rating-input"" value=""5 Stars""><label for=""5_star"" class=""rating-star""></label>
                                <input type=""radio"" class=""rating-input"" id=""4_star"" name=""rating-input"" value=""4 Stars""><label for=""4_star"" class=""rating-star""></label>
                                <input type=""radio"" class=""rating-input"" id=""3_star"" name=""rating-input"" value=""3 Stars""><label for=""3_star"" class=""rating-star""></label>
                           ");
            WriteLiteral(@"     <input type=""radio"" class=""rating-input"" id=""2_star"" name=""rating-input"" value=""2 Stars""><label for=""2_star"" class=""rating-star""></label>
                                <input type=""radio"" class=""rating-input"" id=""1_star"" name=""rating-input"" value=""1 Star""><label for=""1_star"" class=""rating-star""></label>
                            </span>
                        </div>
                    </div>
                    <!-- /rating_submit -->
                    <div class=""form-group"">
                        <label>Title of your review</label>
                        <input class=""form-control"" type=""text"" placeholder=""If you could say it in one sentence, what would you say?"">
                    </div>
                    <div class=""form-group"">
                        <label>Your review</label>
                        <textarea class=""form-control"" style=""height: 180px;"" placeholder=""Write your review to help others learn about this online business""></textarea>
                    </div>");
            WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Add your photo (optional)</label>
                        <div class=""fileupload""><input type=""file"" name=""fileupload"" accept=""image/*""></div>
                    </div>
                    <div class=""form-group"">
                        <div class=""checkboxes float-left add_bottom_15 add_top_15"">
                            <label class=""container_check"">
                                Eos tollit ancillae ea, lorem consulatu qui ne, eu eros eirmod scaevola sea. Et nec tantas accusamus salutatus, sit commodo veritus te, erat legere fabulas has ut. Rebum laudem cum ea, ius essent fuisset ut. Viderer petentium cu his.
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                    </div>
                    <a href=""confirm.html"" class=""btn_1"">Submit review</a>
                <");
            WriteLiteral("/div>\r\n            </div>\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <!-- /container -->\r\n</main>\r\n<!--/main-->\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n\r\n    <!-- SPECIFIC CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d65003fb705d8d092f811f96e645deda80e6bce27571", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
