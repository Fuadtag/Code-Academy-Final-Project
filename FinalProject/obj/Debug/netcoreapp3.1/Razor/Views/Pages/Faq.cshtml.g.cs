#pragma checksum "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\Pages\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba46ae8b02fc91bf52c7a2c289968d960ba28d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Faq), @"mvc.1.0.view", @"/Views/Pages/Faq.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba46ae8b02fc91bf52c7a2c289968d960ba28d3", @"/Views/Pages/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Faq>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Page Title-->
<div class=""rn-page-title"">
    <div class=""rn-pt-overlayer""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""rn-page-title-inner"">
                    <h1>FAQ</h1>
                    <p>Cras eros lorem, rhoncus ac risus sit amet, fringilla ultrices purus.</p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Page Title-->
<!-- Page Content-->
<section class=""rn-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
");
#nullable restore
#line 23 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\Pages\Faq.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""rn-faq-item"">
                        <div class=""rn-faq-icon"">
                            <i class=""fas fa-question""></i>
                        </div>
                        <div class=""rn-faq-content"">
                            <h2 class=""rn-faq-title"">");
#nullable restore
#line 30 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\Pages\Faq.cshtml"
                                                Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 31 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\Pages\Faq.cshtml"
                          Write(item.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\USER\Desktop\aspcore final\Code-Academy-Final-Project\FinalProject\Views\Pages\Faq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- FAQ Item-->
                <!-- End FAQ Item-->
                <!-- FAQ Item-->
                <div class=""rn-faq-item"">
                    <div class=""rn-faq-icon"">
                        <i class=""fas fa-question""></i>
                    </div>
                    <div class=""rn-faq-content"">
                        <h2 class=""rn-faq-title"">What is your favorite fruit?</h2>
                        <p>Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia. Nam ligula augue, volutpat nec tempus a, lobortis et lacus.</p>
                    </div>
                </div>
                <!-- End FAQ Item-->
                <!-- FAQ Item-->
                <div class=""rn-faq-item"">
                    <div class=""rn-faq-icon"">
                        <i class=""fas fa-question""></i>
                   ");
            WriteLiteral(@" </div>
                    <div class=""rn-faq-content"">
                        <h2 class=""rn-faq-title"">What is your favorite fruit?</h2>
                        <p>Praesent sed ex non leo sodales lacinia. Nam ligula augue, volutpat nec tempus a, lobortis et lacus. Ut aliquam augue nulla, in bibendum tellus dictum sit amet.</p>
                    </div>
                </div>
                <!-- End FAQ Item-->
                <!-- FAQ Item-->
                <div class=""rn-faq-item"">
                    <div class=""rn-faq-icon"">
                        <i class=""fas fa-question""></i>
                    </div>
                    <div class=""rn-faq-content"">
                        <h2 class=""rn-faq-title"">What is your favorite fruit?</h2>
                        <p>Mauris pharetra ligula tincidunt tincidunt rhoncus. Curabitur volutpat lacinia bibendum. Aenean sit amet semper urna. Curabitur gravida erat eget blandit tincidunt. Integer ex dui, interdum quis ligula ac, varius rhoncus massa. ");
            WriteLiteral(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus porttitor dolor at libero accumsan rutrum.</p>
                        <p>In blandit dui augue, nec aliquam eros ullamcorper id. Cras pretium tellus varius posuere posuere. Phasellus id mauris id nisi mollis viverra. Etiam vitae molestie orci, vitae laoreet lectus. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
                    </div>
                </div>
                <!-- End FAQ Item-->
                <!-- FAQ Item-->
                <div class=""rn-faq-item"">
                    <div class=""rn-faq-icon"">
                        <i class=""fas fa-question""></i>
                    </div>
                    <div class=""rn-faq-content"">
                        <h2 class=""rn-faq-title"">What is your favorite fruit?</h2>
                        <p>Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus");
            WriteLiteral(@" eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia. Nam ligula augue, volutpat nec tempus a, lobortis et lacus. Ut aliquam augue nulla, in bibendum tellus dictum sit amet.</p>
                    </div>
                </div>
                <!-- End FAQ Item-->

            </div>
            <div class=""col-lg-4"">

                <!-- Sidebar-->
                <aside class=""rn-widget-area"" id=""secondary"">

                    <!-- Widget Item-->
                    <section class=""rn-widget"">
                        <div class=""rn-widget-content"">
                            <div class=""rn-support-widget"">
                                <i class=""far fa-life-ring""></i>
                                <h2 class=""rn-support-widget-title"">Do you need support?</h2>
                                <p>Our support agents are available 24/7/365. Call u");
            WriteLiteral(@"s now</p>
                                <div class=""rn-phone-number"">+1 562-807-8394</div>
                                <div class=""rn-phone-number"">+1 260-557-8432</div>
                            </div>
                        </div>
                    </section>
                    <!-- End Widget Item-->

                </aside>
                <!-- End Sidebar-->

            </div>
        </div>
    </div>
</section>
<!-- End Page Content-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Faq>> Html { get; private set; }
    }
}
#pragma warning restore 1591
