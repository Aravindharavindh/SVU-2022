#pragma checksum "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c116352e8491ec90730c39381b19e478e13b1551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SVUStudent.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
namespace SVUStudent.Pages
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
#line 1 "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\_ViewImports.cshtml"
using SVUStudent;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c116352e8491ec90730c39381b19e478e13b1551", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892fe96ed1254782af74736dc5b6db601a0f28a4", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""app"">
    <div class=""main-wrapper container"">
       <div class=""main-content"">
        <section class=""section"">
          <div class=""section-body"">
            <div class=""row"">
              <div class=""col-12 col-sm-12 col-lg-12"">
                <div class=""card"">
                  <div class=""card-header"">
                    <h4><i class=""fa-solid fa-user-tie""></i> Student Profile </h4>
                  </div>
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-12 col-sm-12 col-md-4"">
                        <ul class=""nav nav-pills flex-column"" id=""myTab4"" role=""tablist"">
                          <li class=""nav-item"">
                            <a class=""nav-link active mt-2 mb-2"" id=""home-tab4"" data-toggle=""tab"" href=""#home4"" role=""tab""
                              aria-controls=""home"" aria-selected=""true""> <i class=""fa-solid fa-lock""></i> Change Password</a>
                          </li>
        ");
            WriteLiteral(@"                  <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""profile-tab4"" data-toggle=""tab"" href=""#profile4"" role=""tab""
                              aria-controls=""profile"" aria-selected=""false""> <i class=""fa-solid fa-envelope-open-text""></i> Email Change</a>
                          </li>
                          <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""contact-tab4"" data-toggle=""tab"" href=""#contact4"" role=""tab""
                              aria-controls=""contact"" aria-selected=""false""> <i class=""fa-solid fa-mobile-screen-button""></i> Change Mobile Number </a>
                          </li>
                        </ul>
                      </div>
                      <div class=""col-12 col-sm-12 col-md-8"">
                        <div class=""tab-content no-padding"" id=""myTab2Content"">
                          <div class=""tab-pane fade show active"" id=""home4"" role=""tabpanel"" aria-labelledby=""home-tab4"">
");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c116352e8491ec90730c39381b19e478e13b15515472", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Current Password</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 2364, "\"", 2375, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Password</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 2606, "\"", 2617, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                              </div>
                              <div class=""form-group"">
                                <label>Confirm New Password</label>
                                <input type=""email"" class=""form-control"">
                              </div>
                              <button class=""btn btn-primary mt-2"">Update Password</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n                          <div class=\"tab-pane fade\" id=\"profile4\" role=\"tabpanel\" aria-labelledby=\"profile-tab4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c116352e8491ec90730c39381b19e478e13b15518068", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Old Email Id</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 3401, "\"", 3412, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Email Id</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 3643, "\"", 3654, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <button class=\"btn btn-primary mt-2\">Update Email Id</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n                          <div class=\"tab-pane fade\" id=\"contact4\" role=\"tabpanel\" aria-labelledby=\"contact-tab4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c116352e8491ec90730c39381b19e478e13b155110421", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Old Mobile</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 4198, "\"", 4209, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Mobile Number</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 4445, "\"", 4456, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <button class=\"btn btn-primary mt-2\">Update Mobile Number</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
      </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SVUStudent.Pages.ProfileModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVUStudent.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVUStudent.Pages.ProfileModel>)PageContext?.ViewData;
        public SVUStudent.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
