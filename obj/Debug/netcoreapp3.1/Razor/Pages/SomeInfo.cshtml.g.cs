#pragma checksum "C:\Users\nafaa\source\repos\WebAppYN\Pages\SomeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc2f79aa17d555307275cec43c102f9feefe5d46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppYN.Pages.Pages_SomeInfo), @"mvc.1.0.razor-page", @"/Pages/SomeInfo.cshtml")]
namespace WebAppYN.Pages
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
#line 1 "C:\Users\nafaa\source\repos\WebAppYN\Pages\_ViewImports.cshtml"
using WebAppYN;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc2f79aa17d555307275cec43c102f9feefe5d46", @"/Pages/SomeInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e269412decd81d16b9acf5818f9a415bcf58d9bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SomeInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h5>Host Value</h5>\r\n<p>");
#nullable restore
#line 5 "C:\Users\nafaa\source\repos\WebAppYN\Pages\SomeInfo.cshtml"
Write(Request.Host.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h5>User Agent</h5>\r\n<p>");
#nullable restore
#line 8 "C:\Users\nafaa\source\repos\WebAppYN\Pages\SomeInfo.cshtml"
Write(Request.Headers["User-Agent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<h5>Accept</h5>\r\n<p>");
#nullable restore
#line 11 "C:\Users\nafaa\source\repos\WebAppYN\Pages\SomeInfo.cshtml"
Write(Request.Headers["Accept"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<h5>Content Encoding</h5>\r\n<p>");
#nullable restore
#line 15 "C:\Users\nafaa\source\repos\WebAppYN\Pages\SomeInfo.cshtml"
Write(Html.Encode("Hello"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYN.Pages.SomeInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppYN.Pages.SomeInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppYN.Pages.SomeInfoModel>)PageContext?.ViewData;
        public WebAppYN.Pages.SomeInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591