#pragma checksum "C:\Users\nafaa\source\repos\WebAppYN\Pages\BlogPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c96d3e32c823165be4297b87621e68e9c937e7a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppYN.Pages.Pages_BlogPost), @"mvc.1.0.razor-page", @"/Pages/BlogPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c96d3e32c823165be4297b87621e68e9c937e7a9", @"/Pages/BlogPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e269412decd81d16b9acf5818f9a415bcf58d9bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BlogPost : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nafaa\source\repos\WebAppYN\Pages\BlogPost.cshtml"
  
    ViewData["Title"] = "Blog Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article>\r\n    <header>\r\n        <a href=\"#0\" class=\"badge badge-primary\">Category</a>\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\nafaa\source\repos\WebAppYN\Pages\BlogPost.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <div>Posted on: <time datetime=""2020-11-09T10:00"">November 09, 2020 at 10:00 AM</time></div>
        <div>
            <span class=""badge badge-secondary"">20 likes</span>
            <span class=""badge badge-danger"">2 dislikes</span>
            <span class=""badge badge-warning"">7 comments</span>
        </div>
    </header>
    <section>
        <br />
        <figure class=""figure"">
            <img src=""https://placehold.it/800x600"" class=""figure-img img-fluid"" alt=""snow-image"" />
            <figcaption class=""figure-caption"">
                <p style=""color:black;"">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book</p>
                <p>Photo By: Youssef NAFAA</p>
            </figcaption>
        </figure>
    </section>
    <section id=""comments"">
        <button type=""button"" c");
            WriteLiteral(@"lass=""btn btn-lg btn-primary"">Like</button>
        <h2>Comments</h2>
        <div class=""media"">
            <img src=""https://placehold.it/64x64"" alt=""media object image"" />
        </div>
        <p>
            Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            <hr />
            <div class=""media"">
                <img src=""https://placehold.it/64x64"" alt=""media object image"" />
            </div>
        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions o");
            WriteLiteral("f Lorem Ipsum.</p>\r\n    </section>\r\n</article>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPost> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogPost> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogPost>)PageContext?.ViewData;
        public BlogPost Model => ViewData.Model;
    }
}
#pragma warning restore 1591
