#pragma checksum "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\ExamAppDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde8718459cf0d6ebdadfdda7fafe4776b5f85be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SVU_University.Pages.Pages_ExamAppDelete), @"mvc.1.0.razor-page", @"/Pages/ExamAppDelete.cshtml")]
namespace SVU_University.Pages
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
#line 1 "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\_ViewImports.cshtml"
using SVU_University;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde8718459cf0d6ebdadfdda7fafe4776b5f85be", @"/Pages/ExamAppDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd7691a3290b10ea46bc96e01ca2464396f33c0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_ExamAppDelete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Projects\NetCore\UniversityApplication\SVUDDE\SVU_University\Pages\ExamAppDelete.cshtml"
  
    ViewData["Title"] = "ExamAppDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""section-body"">
                <div class=""section-title""> Delete Examination Application Details</div>
                <div class=""row"">
                  <div class=""col-md-12"">
                      <div class=""card""> 
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dde8718459cf0d6ebdadfdda7fafe4776b5f85be3683", async() => {
                WriteLiteral(@"
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label"">ID</label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> 05 </label>
                                </div>
                              </div>  
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label"">Code</label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> App001 </label>
                                </div>
                              </div>
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label"">Admission No.</label>
                        ");
                WriteLiteral(@"        <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> Ad20011001 </label>
                                </div>
                              </div>
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label"">Examination Code</label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> 001Eng </label>
                                </div>
                              </div>
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label""> Course Group </label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> B.Com(Accounts) </la");
                WriteLiteral(@"bel>
                                </div>
                              </div>
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label""> Academic Period Index </label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> 3 </label>
                                </div>
                              </div>
                              <div class=""form-group row"">
                                <label class=""col-md-6 label-title col-form-label"">Status</label>
                                <div class=""col-md-6"">
                                  <label type=""text"" readonly class=""form-control-valuetext form-control-lg""> Available </label>
                                </div>
                              </div>
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
            WriteLiteral(@"

                            <div class=""row"">
                                <div class=""col-md-12 d-flex"">
                                  <div class=""col-md-6"">
                                       <a href=""ExamApp"" class=""btn btn-dark ""> <i class=""fas fa-arrow-left""></i> Back </a>
                                  </div>
                                  <div class=""col-md-6 text-right"">
                                       <a href=""#"" class=""btn btn-danger ""> <i class=""fas fa-xmark""></i> Delete </a>
                                  </div>
                                </div>
                            </div>

                        </div>  
                      </div>
                  </div>
                </div>
            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SVU_University.Pages.ExamAppDeleteModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVU_University.Pages.ExamAppDeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVU_University.Pages.ExamAppDeleteModel>)PageContext?.ViewData;
        public SVU_University.Pages.ExamAppDeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
