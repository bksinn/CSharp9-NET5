#pragma checksum "C:\Users\bksin\OneDrive\Desktop\Projects_Misc\CSharp9-.NET5\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\HtmlBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb63372e5244cdddf9e2a13a05e357d9761abe9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_HtmlBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
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
#line 1 "C:\Users\bksin\OneDrive\Desktop\Projects_Misc\CSharp9-.NET5\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bksin\OneDrive\Desktop\Projects_Misc\CSharp9-.NET5\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using NorthwindCms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb63372e5244cdddf9e2a13a05e357d9761abe9f", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6678a70b82dc05f14c5ff659ec3564cb98c831e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_HtmlBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.HtmlBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\bksin\OneDrive\Desktop\Projects_Misc\CSharp9-.NET5\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\HtmlBlock.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Authorization.IAuthorizationService Auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.HtmlBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
