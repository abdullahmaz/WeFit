#pragma checksum "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a11c933f5512bb5dbbdbf0439b314d63680c5377c1d1520fbdb3f92495149d2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\_ViewImports.cshtml"
using FitnessTracker.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\_ViewImports.cshtml"
using FitnessTracker.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using FitnessTracker.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a11c933f5512bb5dbbdbf0439b314d63680c5377c1d1520fbdb3f92495149d2a", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d97c7cb270b259247449391b06d7cd3a9a6aeb3a8fe41980b3c664fc4ee9f181", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1848e634328f39ee33e11da3f84c0202591d5e1eade29935aa7dd5341426f164", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#nullable restore
#line 6 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
#nullable restore
#line 8 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "C:\Users\abdullah\Downloads\FitnessTracker-master\WeFit\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591