#pragma checksum "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\subjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bd9df712f0c033047b3f712d55e7f4e05a52b13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_search_subjects), @"mvc.1.0.razor-page", @"/pages/search/subjects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bd9df712f0c033047b3f712d55e7f4e05a52b13", @"/pages/search/subjects.cshtml")]
    public class pages_search_subjects : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\subjects.cshtml"
  
  Layout = "../shared/_AdminMenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n  <h1 class=\"display-3\">Subjects</h1>\r\n  <table class=\"table\">\r\n    <thead class=\"thead-inverse\">\r\n      <tr><th>School Subjects</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\subjects.cshtml"
     foreach(var subject in Model.Subjects)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr><td>");
#nullable restore
#line 18 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\subjects.cshtml"
         Write(subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 19 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\subjects.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.SubjectsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.SubjectsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.SubjectsModel>)PageContext?.ViewData;
        public WebApp.Pages.SubjectsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591