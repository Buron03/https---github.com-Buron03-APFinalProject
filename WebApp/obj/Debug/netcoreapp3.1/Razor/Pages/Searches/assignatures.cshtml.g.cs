#pragma checksum "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411b02e2f6cc1825df55543cc459d701a5059279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Searches_assignatures), @"mvc.1.0.razor-page", @"/Pages/Searches/assignatures.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411b02e2f6cc1825df55543cc459d701a5059279", @"/Pages/Searches/assignatures.cshtml")]
    public class Pages_Searches_assignatures : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n  <h1 class=\"display-2\">Assignatures</h1>\r\n  <table class=\"table\">\r\n    <thead class=\"thead-inverse\">\r\n      <tr><th>School Assignatures</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml"
     foreach(var assignature in Model.Assignatures)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr><td>");
#nullable restore
#line 14 "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml"
         Write(assignature.IdTeacher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" teaches ");
#nullable restore
#line 14 "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml"
                                        Write(assignature.IdSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 14 "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml"
                                                                  Write(assignature.IdGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 15 "C:\Users\eilopez\Desktop\FinalProject\WebApp\Pages\Searches\assignatures.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div>\r\n<div class=\"row\">\r\n\r\n");
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.AssignaturesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AssignaturesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AssignaturesModel>)PageContext?.ViewData;
        public WebApp.Pages.AssignaturesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591