#pragma checksum "C:\Users\nafaa\source\repos\WebAppYN\Pages\ArrayList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4aac6723c6295a3f7e98164054f009111daeaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppYN.Pages.Pages_ArrayList), @"mvc.1.0.razor-page", @"/Pages/ArrayList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4aac6723c6295a3f7e98164054f009111daeaf", @"/Pages/ArrayList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e269412decd81d16b9acf5818f9a415bcf58d9bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArrayList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 5 "C:\Users\nafaa\source\repos\WebAppYN\Pages\ArrayList.cshtml"
         for (int i = 0; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Cat ");
#nullable restore
#line 7 "C:\Users\nafaa\source\repos\WebAppYN\Pages\ArrayList.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\nafaa\source\repos\WebAppYN\Pages\ArrayList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYN.Pages.ArrayListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppYN.Pages.ArrayListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppYN.Pages.ArrayListModel>)PageContext?.ViewData;
        public WebAppYN.Pages.ArrayListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
