#pragma checksum "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123b068cd9c626b246c0ec1c15fe205b32c34c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\_ViewImports.cshtml"
using MAXIM.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\_ViewImports.cshtml"
using MAXIM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123b068cd9c626b246c0ec1c15fe205b32c34c7d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ef3d7eb010927283237e450ffbe1d386674c1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/scss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123b068cd9c626b246c0ec1c15fe205b32c34c7d4143", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "123b068cd9c626b246c0ec1c15fe205b32c34c7d5146", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Document</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123b068cd9c626b246c0ec1c15fe205b32c34c7d7064", async() => {
                WriteLiteral(@"

    <header>
        <nav>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <a href=""#"">
                            <h3 class=""li"">MAXIM</h3>
                        </a>
                    </div>
                    <div class=""col-lg-6 mt-2 sub"">
                        <ul>
                            <li><a href=""#""><strong class=""li"">ABOUT</strong></a></li>
                            <li><a href=""#""><strong class=""li"">SERVICES</strong></a></li>
                            <li><a href=""#""><strong class=""li"">WORKS</strong></a></li>
                            <li><a href=""#""><strong class=""li"">BLOG</strong></a></li>
                            <li><a href=""#""><strong class=""li"">CONTACT</strong></a></li>
                            <li><a href=""#""><strong class=""li"">PAGE</strong></a></li>
                        </ul>
                    </div>
                </div>
            </div>
       ");
                WriteLiteral(" </nav>\r\n    </header>\r\n    ");
#nullable restore
#line 45 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <footer>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"icon\">\r\n                        <div class=\"i instagram\"><a href=\"#\"><i");
                BeginWriteAttribute("class", " class=\"", 2201, "\"", 2283, 1);
#nullable restore
#line 51 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2209, layout.GetSettings().Result.FirstOrDefault(u=>u.Key == "instagram").Value, 2209, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></div>\r\n                        <div class=\"i twitter\"><a href=\"#\"><i");
                BeginWriteAttribute("class", " class=\"", 2362, "\"", 2442, 1);
#nullable restore
#line 52 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2370, layout.GetSettings().Result.FirstOrDefault(u=>u.Key == "twitter").Value, 2370, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></div>\r\n                        <div class=\"i basketball\"><a href=\"#\"><i");
                BeginWriteAttribute("class", " class=\"", 2524, "\"", 2607, 1);
#nullable restore
#line 53 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2532, layout.GetSettings().Result.FirstOrDefault(u=>u.Key == "basketball").Value, 2532, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></div>\r\n                        <div class=\"i pinterest\"><a href=\"#\"><i");
                BeginWriteAttribute("class", " class=\"", 2688, "\"", 2770, 1);
#nullable restore
#line 54 "C:\Users\examone\Desktop\projected\bacend\MAXIM\MAXIM\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2696, layout.GetSettings().Result.FirstOrDefault(u=>u.Key == "pinterest").Value, 2696, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></i></a></div>
                    </div>
                    <div class=""mt-4"">
                        <p>© Maxim Theme. All rights reserved.</p>
                        <p class=""p"">Designed by <a href=""#"">BootstrapMade</a></p>
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MAXIM.Services.LayoutService layout { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591