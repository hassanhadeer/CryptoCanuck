#pragma checksum "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\CoinGraph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742700b6885bcb47f8e805bc12c15bfea48e9ade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CryptoCanuck.Pages.Pages_CoinGraph), @"mvc.1.0.razor-page", @"/Pages/CoinGraph.cshtml")]
namespace CryptoCanuck.Pages
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
#line 1 "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\_ViewImports.cshtml"
using CryptoCanuck;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742700b6885bcb47f8e805bc12c15bfea48e9ade", @"/Pages/CoinGraph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d79f4520d4da280e60cfdd7abce10546eb1d75", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CoinGraph : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\CoinGraph.cshtml"
  
    ViewData["Title"] = "Coin Graph";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script type=\"text/javascript\">\n    var BTCweekly = \"");
#nullable restore
#line 8 "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\CoinGraph.cshtml"
                Write(Model.weeklyOnly);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var javaScriptAPI = \"");
#nullable restore
#line 9 "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\CoinGraph.cshtml"
                    Write(Model.javaScriptString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var coinName = \"");
#nullable restore
#line 10 "C:\Users\Hassan Abu Hadeer\OneDrive - triOS College\WinMobileDev\file\CryptoCanuck\final copy\CryptoCanuck-master\CryptoCanuck-master\Pages\CoinGraph.cshtml"
               Write(Model.coinName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n</script>\n\n<div id=\"graphContainer\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoinGraphModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoinGraphModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoinGraphModel>)PageContext?.ViewData;
        public CoinGraphModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591