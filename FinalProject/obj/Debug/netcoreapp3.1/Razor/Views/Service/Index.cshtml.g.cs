#pragma checksum "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34b1e0db49dba8320004a7224c7d63f7eb6938a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34b1e0db49dba8320004a7224c7d63f7eb6938a", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/author-1.jpg 1x, ~/images/author-1@2x.jpg 2x"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Page Title-->
<div class=""rn-page-title"">
    <div class=""rn-pt-overlayer""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""rn-page-title-inner"">
                    <h1>Service</h1>
                    <p>Cras eros lorem, rhoncus ac risus sit amet, fringilla ultrices purus.</p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Page Title-->
<!-- What We Offer-->
<section class=""rn-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <!-- Section Title-->
                <div class=""rn-section-title   "">
                    <h2 class=""rn-title"">What We Offer</h2>
                    <p>Inbecilloque elegans errorem concedo etsi electram.</p>
                    <span class=""rn-title-bg"">What We Offer</span>
                </div>

            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 33 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
             foreach (var item in Model.Offers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n\r\n                    <!-- Service Item-->\r\n                    <div class=\"rn-service-item\">\r\n                        <div class=\"rn-service-icon\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 1328, "\"", 1350, 2);
            WriteAttributeValue("", 1336, "lnr", 1336, 3, true);
#nullable restore
#line 40 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
WriteAttributeValue(" ", 1339, item.Icon, 1340, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        </div>\r\n                        <div class=\"rn-service-title\">");
#nullable restore
#line 42 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"rn-service-desc\">\r\n                            <p>");
#nullable restore
#line 44 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <!-- End Service Item-->\r\n\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</section>
<!-- End What We Offer-->
<!-- Call To Action-->
<section class=""rn-section rn-service-c2a"">
    <div class=""rn-section-overlayer""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>Are you looking for renting your car?</h2>
                <p>Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus.</p>
                <a class=""btn btn-main btn-lg btn-shadow"" href=""#"">Contact US</a>
            </div>
        </div>
    </div>
</section>
<!-- End Call To Action-->
<!-- Clients-->
<section class=""rn-section rn-section-light-gray"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <!-- Section Title-->
                <div class=""rn-section-title   "">
                    <h2 class=""rn-title"">What Our Client Say</h2>
                    <p>Inbecilloque elegans errorem concedo etsi electram.</p>
  ");
            WriteLiteral(@"                  <span class=""rn-title-bg"">Client Review</span>
                </div>

                <div class=""rn-testimonials"">
                    <div class=""rn-testimonials-carousel carousel slide"" id=""rn-testimonials"" data-ride=""carousel"">
                        <div class=""carousel-inner"">
");
#nullable restore
#line 87 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                             for (int i = 0; i < Model.Testimonials.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 3194, "\"", 3239, 2);
            WriteAttributeValue("", 3202, "carousel-item", 3202, 13, true);
#nullable restore
#line 89 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
WriteAttributeValue(" ", 3215, i == 0? "active": "", 3216, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                                    <!-- Testimonial Item-->
                                    <blockquote class=""rn-testimonial-item"">
                                        <div class=""rn-testimonial-author"">
                                            <div class=""rn-testimonial-author-thumb"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a34b1e0db49dba8320004a7224c7d63f7eb6938a9674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3607, "~/images/", 3607, 9, true);
#nullable restore
#line 95 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
AddHtmlAttributeValue("", 3616, Model.Testimonials[i].Photo, 3616, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 95 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
AddHtmlAttributeValue("", 3651, Model.Testimonials[i].Name, 3651, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"rn-testimonial-author-info\">\r\n                                                <strong>");
#nullable restore
#line 98 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                                                   Write(Model.Testimonials[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                                <p>");
#nullable restore
#line 99 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                                              Write(Model.Testimonials[i].Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 99 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                                                                               Write(Model.Testimonials[i].Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                        <p>");
#nullable restore
#line 102 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                                      Write(Model.Testimonials[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <footer>
                                            <div class=""rn-testimonial-rating"">
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
                                                <i class=""fas fa-star""></i>
                                            </div>
                                        </footer>
                                    </blockquote>
                                    <!-- End Testimonial Item-->

                                </div>
");
#nullable restore
#line 116 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Views\Service\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <a class=""carousel-control-prev"" href=""#rn-testimonials"" role=""button"" data-slide=""prev"">
                            <i class=""fas fa-angle-left"" aria-hidden=""true""></i>
                        </a>
                        <a class=""carousel-control-next"" href=""#rn-testimonials"" role=""button"" data-slide=""next"">
                            <i class=""fas fa-angle-right"" aria-hidden=""true""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End Clients-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
