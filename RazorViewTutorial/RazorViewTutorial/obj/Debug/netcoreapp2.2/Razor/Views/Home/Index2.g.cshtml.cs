#pragma checksum "C:\Users\Nemanja Djordjevic\source\repos\RazorViewTutorial\RazorViewTutorial\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3e5e2b607502617dc1a856d5f3ac0fecc16e66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index2.cshtml", typeof(AspNetCore.Views_Home_Index2))]
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
#line 7 "C:\Users\Nemanja Djordjevic\source\repos\RazorViewTutorial\RazorViewTutorial\Views\_ViewImports.cshtml"
using RazorViewTutorial;

#line default
#line hidden
#line 8 "C:\Users\Nemanja Djordjevic\source\repos\RazorViewTutorial\RazorViewTutorial\Views\_ViewImports.cshtml"
using RazorViewTutorial.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3e5e2b607502617dc1a856d5f3ac0fecc16e66", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be294556c797a257be6c86af377cd792c1e75b93", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RazorViewTutorial.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 100, true);
            WriteLiteral("<p>\r\n    Hello. This text will be rendered in body of the layout\r\n    page\r\n</p>\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(151, 42, false);
#line 10 "C:\Users\Nemanja Djordjevic\source\repos\RazorViewTutorial\RazorViewTutorial\Views\Home\Index2.cshtml"
Write(Html.Partial("_PartialHelloWorld", @Model));

#line default
#line hidden
            EndContext();
            BeginContext(193, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RazorViewTutorial.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
