#pragma checksum "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a8dda859caa5ebc35fc46219d1bf737d6cb03d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(XtendersProject.Pages.Pages_GetAQuote), @"mvc.1.0.razor-page", @"/Pages/GetAQuote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/GetAQuote.cshtml", typeof(XtendersProject.Pages.Pages_GetAQuote), null)]
namespace XtendersProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\it\Desktop\Xtenders\Pages\_ViewImports.cshtml"
using XtendersProject;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8dda859caa5ebc35fc46219d1bf737d6cb03d4", @"/Pages/GetAQuote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c65e41208f60d68b31d78ca12a808b17dedbe00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GetAQuote : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
  
    ViewData["Title"] = "Get A Quote";
    Layout = "~/Pages/Shared/_BulmaLayout.cshtml";

#line default
#line hidden
            BeginContext(145, 158, true);
            WriteLiteral("<style>\r\n    .card{\r\n        height:100%;\r\n    }\r\n</style>\r\n<section class=\"container\" style=\"margin-top:20px;\">\r\n    <div class=\"row columns is-multiline\">\r\n");
            EndContext();
#line 14 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
         foreach (var p in Model.Products)
        {

#line default
#line hidden
            BeginContext(358, 232, true);
            WriteLiteral("            <div class=\"column is-one-third \">\r\n                <div class=\"card round large is-shady\">\r\n                    <div class=\"card-image \">\r\n                        <figure class=\"image\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 590, "", 604, 1);
#line 20 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
WriteAttributeValue("", 595, p.PicUrl, 595, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 617, 1);
#line 20 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
WriteAttributeValue("", 610, p.Name, 610, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(618, 189, true);
            WriteLiteral(">\r\n                        </figure>\r\n                    </div>\r\n                    <div class=\"card-content has-text-centered\">\r\n                        <div class=\"title has-text-link\">");
            EndContext();
            BeginContext(808, 6, false);
#line 24 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
                                                    Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(814, 83, true);
            WriteLiteral("</div>\r\n                        <div class=\"content\">\r\n                            ");
            EndContext();
            BeginContext(898, 13, false);
#line 26 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
                       Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(911, 101, true);
            WriteLiteral("\r\n                        </div>\r\n                        <a class=\"button is-outlined is-link is-12\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1012, "\"", 1035, 2);
            WriteAttributeValue("", 1019, "/Quotation/", 1019, 11, true);
#line 28 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
WriteAttributeValue("", 1030, p.ID, 1030, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1036, 90, true);
            WriteLiteral(">Get A Quote</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 32 "C:\Users\it\Desktop\Xtenders\Pages\GetAQuote.cshtml"
        }

#line default
#line hidden
            BeginContext(1137, 24, true);
            WriteLiteral("    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<XtendersProject.GetAQuoteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<XtendersProject.GetAQuoteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<XtendersProject.GetAQuoteModel>)PageContext?.ViewData;
        public XtendersProject.GetAQuoteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
