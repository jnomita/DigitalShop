#pragma checksum "E:\pdn\shoppingcart\DigitalShop\DigitalShop\DigitalShop\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95eb8bddd3c3280a550487f2050ca6300b5fb68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "E:\pdn\shoppingcart\DigitalShop\DigitalShop\DigitalShop\Views\_ViewImports.cshtml"
using DigitalShop;

#line default
#line hidden
#line 2 "E:\pdn\shoppingcart\DigitalShop\DigitalShop\DigitalShop\Views\_ViewImports.cshtml"
using DigitalShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95eb8bddd3c3280a550487f2050ca6300b5fb68", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bafa441670eb6cdf81c6a1d111a35fb128ead632", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1859, true);
            WriteLiteral(@"
<div class=""site-branding-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""logo"">
                    <h1><a href=""index.html"">e<span>Electronics</span></a></h1>
                </div>
            </div>

            <div class=""col-sm-6"">
                <div class=""shopping-item"">
                    <a href=""cart.html"">Cart - <span class=""cart-amunt"">$800</span> <i class=""fa fa-shopping-cart""></i> <span class=""product-count"">5</span></a>
                </div>
            </div>
        </div>
    </div>
</div> <!-- End site branding area -->

<div class=""mainmenu-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
              ");
            WriteLiteral(@"      <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
                    <li class=""active""><a href=""/"">Home</a></li>
                    <li><a href=""shop.html"">Shop page</a></li>
                    <li><a href=""single-product.html"">Single product</a></li>
                    <li><a href=""cart.html"">Cart</a></li>
                    <li><a href=""checkout.html"">Checkout</a></li>
                    <li><a href=""#"">Category</a></li>
                    <li><a href=""#"">Others</a></li>
                    <li><a href=""#"">Contact</a></li>
                </ul>
            </div>
        </div>
    </div>
</div> <!-- End mainmenu area -->");
            EndContext();
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
