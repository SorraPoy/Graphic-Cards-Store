#pragma checksum "D:\Project\logintest\logintest\Views\Image\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32012ee0eaadc6a602a81749196823ab22ed0a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_Details), @"mvc.1.0.view", @"/Views/Image/Details.cshtml")]
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
#line 1 "D:\Project\logintest\logintest\Views\_ViewImports.cshtml"
using logintest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\logintest\logintest\Views\_ViewImports.cshtml"
using logintest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32012ee0eaadc6a602a81749196823ab22ed0a66", @"/Views/Image/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceea1f6c2fdcdb2a2ebe4ec6ae84c7cc20ba0af1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Image_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<logintest.Areas.Identity.Data.ImageModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-mod btn-large btn-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appear-animate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32012ee0eaadc6a602a81749196823ab22ed0a666933", async() => {
                WriteLiteral(@"



    <main id=""main"">


        <!-- Head Section -->
        <section class=""page-section bg-dark-alfa-50 parallax-3"" data-background=""/images/banners/banner.jpg"">

            <div class=""relative container align-left"">

                <div class=""row"">

                    <div class=""col-md-8"">
                        <h1 class=""hs-line-11 font-alt mb-20 mb-xs-0"">Single Product</h1>
                        <div class=""hs-line-4 font-alt"">
                            CHOOSE THE BEST PRODUCTS IN OUR SHOP
                        </div>
                    </div>

                    <div class=""col-md-4 mt-30"">
                        <div class=""mod-breadcrumbs font-alt align-right"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 955, "\"", 962, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a>&nbsp;/&nbsp;<a");
                BeginWriteAttribute("href", " href=\"", 987, "\"", 994, 0);
                EndWriteAttribute();
                WriteLiteral(@">Pages</a>&nbsp;/&nbsp;<span>Products List</span>
                        </div>

                    </div>
                </div>

            </div>
        </section>
        <!-- End Head Section -->
        <!-- Section -->
        <section class=""page-section"">
            <div class=""container relative"">

                <!-- Product Content -->
                <div class=""row mb-60 mb-xs-30"">

                    <!-- Product Images -->
                    <div class=""col-md-4 mb-md-30"">

                        <div class=""post-prev-img"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32012ee0eaadc6a602a81749196823ab22ed0a668898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line (51,41)-(51,70) 13 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
WriteLiteral("~/image/"+Model.ProductImage);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                    <!-- End Product Images -->
                    <!-- Product Description -->
                    <div class=""col-sm-8 col-md-5 mb-xs-40"">

                        <h3 class=""font-alt mb-30 mb-xxs-10"">");
#nullable restore
#line (59,63)-(59,106) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                        <hr class=\"mt-0 mb-30\" />\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6 lead mt-0 mb-20\">\r\n\r\n                                <strong>Price : ");
#nullable restore
#line (66,50)-(66,94) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ฿</strong>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                        <hr class=\"mt-0 mb-30\" />\r\n\r\n                        <div class=\"section-text mb-30\">\r\n                            ");
#nullable restore
#line (75,30)-(75,75) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductDetail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <hr class=\"mt-0 mb-30\" />\r\n\r\n                        <div class=\"mb-30\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32012ee0eaadc6a602a81749196823ab22ed0a6612736", async() => {
                    WriteLiteral("\r\n                                <input type=\"number\" class=\"input-lg round\" min=\"1\" max=\"100\" value=\"1\" />\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32012ee0eaadc6a602a81749196823ab22ed0a6613155", async() => {
                        WriteLiteral("Add to Cart");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line (83,96)-(83,111) 13 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>

                        <hr class=""mt-0 mb-30"" />



                    </div>
                    <!-- End Product Description -->
                    <!-- Features -->
                    <div class=""col-sm-4 col-md-3 mb-xs-40"">

                        <!-- Features Item -->
                        <div class=""alt-service-wrap"">
                            <div class=""alt-service-item"">
                                <div class=""alt-service-icon"">
                                    <i class=""fa fa-paper-plane-o""></i>
                                </div>
                                <h3 class=""alt-services-title font-alt"">Free Shipping</h3>
                                Vivamus neque orci, ultricies blandit ultricies vel, semper..
                            </div>
                        </div>
                        <!-- End Features Item -->
                        <!-- Features Item -->
                        <div class=""alt-service-wr");
                WriteLiteral(@"ap"">
                            <div class=""alt-service-item"">
                                <div class=""alt-service-icon"">
                                    <i class=""fa fa-clock-o""></i>
                                </div>
                                <h3 class=""alt-services-title font-alt"">14 days moneyback</h3>
                                Vivamus neque orci, ultricies blandit ultricies vel, semper..
                            </div>
                        </div>
                        <!-- End Features Item -->
                        <!-- Features Item -->
                        <div class=""alt-service-wrap"">
                            <div class=""alt-service-item"">
                                <div class=""alt-service-icon"">
                                    <i class=""fa fa-gift""></i>
                                </div>
                                <h3 class=""alt-services-title font-alt"">100% Original</h3>
                                Vivamus neque orci, ");
                WriteLiteral(@"ultricies blandit ultricies vel, semper..
                            </div>
                        </div>
                        <!-- End Features Item -->



                    </div>
                    <!-- End Features -->

                </div>
                <!-- End Product Content -->
                <!-- Nav tabs -->
                <ul role=""tablist"" class=""nav nav-tabs tpl-tabs animate"">
                    <li>
                        <a href=""#one"" aria-controls=""one"" class=""nav-link active"" data-bs-toggle=""tab"" role=""tab"" aria-selected=""true"">Description</a>
                    </li>
                    <li>
                        <a href=""#two"" aria-controls=""two"" class=""nav-link"" data-bs-toggle=""tab"" role=""tab"" aria-selected=""false"">Parameters</a>
                    </li>

                </ul>
                <!-- End Nav tabs -->
                <!-- Tab panes -->
                <div class=""tab-content tpl-tabs-cont"">
                    <div role=""tabpanel""");
                WriteLiteral(" class=\"tab-pane fade show active\" id=\"one\">\r\n                        <p>\r\n                            ");
#nullable restore
#line (152,30)-(152,73) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>

                    </div>
                    <div role=""tabpanel"" class=""tab-pane fade"" id=""two"">

                        <table class=""table table-bordered table-striped"">
                            <tr>
                                <th>
                                    Parameter
                                </th>
                                <th>
                                    Value
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    Slot
                                </td>
                                <td>
                                    ");
#nullable restore
#line (172,38)-(172,81) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductSlot));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Series
                                </td>
                                <td>
                                    ");
#nullable restore
#line (180,38)-(180,76) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.Series));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    GPU Clock
                                </td>
                                <td>
                                    ");
#nullable restore
#line (188,38)-(188,80) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductGPU));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    VRAM
                                </td>
                                <td>
                                    ");
#nullable restore
#line (196,38)-(196,80) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductRam));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Length x Width x Height
                                </td>
                                <td>
                                    ");
#nullable restore
#line (204,38)-(204,81) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductSize));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Power Consumption
                                </td>
                                <td>
                                    ");
#nullable restore
#line (212,38)-(212,82) 6 "D:\Project\logintest\logintest\Views\Image\Details.cshtml"
Write(Html.DisplayFor(model => model.ProductPOWER));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                        </table>

                    </div>

                </div>
                <!-- End Tab panes -->

            </div>
        </section>
        <!-- End Section -->
    </main>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<logintest.Areas.Identity.Data.ImageModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
