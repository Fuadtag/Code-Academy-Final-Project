#pragma checksum "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1c50bd8f2fa22853c1c72cbb2120249b10eb53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Control_Views_Cars_Details), @"mvc.1.0.view", @"/Areas/Control/Views/Cars/Details.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f1c50bd8f2fa22853c1c72cbb2120249b10eb53", @"/Areas/Control/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/Control/Views/_ViewImports.cshtml")]
    public class Areas_Control_Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"pl-4\">\r\n        <h1>Details</h1>\r\n\r\n        <div>\r\n            <h4>Car</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Transmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Transmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Fuel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Fuel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Passsenger));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Passsenger));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Luggage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Luggage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Door));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Door));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.DailyPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.DailyPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 77 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 83 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.CartPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.CartPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.DetailPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 95 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
               Write(Html.DisplayFor(model => model.DetailPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f1c50bd8f2fa22853c1c72cbb2120249b10eb5315866", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\USER\Desktop\Code-Academy-Final-Project\Code-Academy-Final-Project\FinalProject\Areas\Control\Views\Cars\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f1c50bd8f2fa22853c1c72cbb2120249b10eb5318075", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591