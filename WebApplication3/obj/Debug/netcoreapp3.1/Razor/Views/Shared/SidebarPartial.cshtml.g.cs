#pragma checksum "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\Shared\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedc1ee5fea7762f49b35fde55b1bdaa98261141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/SidebarPartial.cshtml")]
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
#line 2 "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedc1ee5fea7762f49b35fde55b1bdaa98261141", @"/Views/Shared/SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c09ce7f2657c0dc574d8b4aa75c25e68408db32", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-4 col-12-medium\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fedc1ee5fea7762f49b35fde55b1bdaa982611413663", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 3 "C:\Users\Жаныбек\source\repos\WebApplication3\WebApplication3\Views\Shared\SidebarPartial.cshtml"
    Write(await Component.InvokeAsync<SidebarViewComponent>());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
