#pragma checksum "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f17133afccb2360a67d0640ad61a4e7dc74811bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\_ViewImports.cshtml"
using OryxWeb;

#line default
#line hidden
#line 2 "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\_ViewImports.cshtml"
using OryxWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17133afccb2360a67d0640ad61a4e7dc74811bc", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee72ab1b76bd2a5dc974fd074b4ae104e901930", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Partner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e3fde5d36b4180b89443ee5f9463ab", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 25, true);
                WriteLiteral(" - OryxAfrica</title>\r\n\r\n");
                EndContext();
                BeginContext(216, 411, true);
                WriteLiteral(@"    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">

    <!--Import materialize.css-->
    <link type=""text/css"" rel=""stylesheet"" href=""css/materialize.min.css"" media=""screen,projection"" />

    <!--Let browser know website is optimized for mobile-->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"" />
");
                EndContext();
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
            EndContext();
            BeginContext(634, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(638, 6007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a72c66701c184e8f8d69b1775636c158", async() => {
                BeginContext(644, 310, true);
                WriteLiteral(@"
    <header class=""nav"">
        <nav class=""purple darken-4"">
            <div class=""navbar-fixed"">
                <ul id=""nav-mobile"" class=""right hide-on-med-and-down"">
                    <li><a href=""#"">HOME</a></li>
                    <li><a href=""#"">ABOUT US</a></li>
                    <li>");
                EndContext();
                BeginContext(954, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b79444556d4da98ef7957d5ed187df", async() => {
                    BeginContext(1027, 8, true);
                    WriteLiteral("PARTNERS");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1039, 413, true);
                WriteLiteral(@"</li>
                    <li><a href=""#"">SOLUTIONS</a></li>
                    <li><a href=""#"">CLIENTS</a></li>
                    <li><a href=""#"">SUPPORT</a></li>
                    <li><a href=""#"">CAREER</a></li>
                    <li><a href=""#"">GALLERY</a></li>
                    <li><a href=""#"">CONTACT US</a></li>
                </ul>
            </div>
        </nav>
    </header>  

");
                EndContext();
                BeginContext(1498, 614, true);
                WriteLiteral(@"        <div class=""carousel"">
            <a class=""carousel-item"" href=""#one!""><img src=""https://lorempixel.com/250/250/nature/1""></a>
            <a class=""carousel-item"" href=""#two!""><img src=""https://lorempixel.com/250/250/nature/2""></a>
            <a class=""carousel-item"" href=""#three!""><img src=""https://lorempixel.com/250/250/nature/3""></a>
            <a class=""carousel-item"" href=""#four!""><img src=""https://lorempixel.com/250/250/nature/4""></a>
            <a class=""carousel-item"" href=""#five!""><img src=""https://lorempixel.com/250/250/nature/5""></a>
        </div>


       



        ");
                EndContext();
                BeginContext(2113, 12, false);
#line 51 "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2125, 22, true);
                WriteLiteral("\r\n        <hr />\r\n\r\n\r\n");
                EndContext();
                BeginContext(2186, 461, true);
                WriteLiteral(@"        <footer class=""page-footer purple darken-4"">
            <p class=""center-align  white purple-text"">REACH US</p>


            <div class=""container"">
                <div class=""row"">
                    <div class=""col l4 m6 s12"">
                        <h5 class=""white-text"">Want to be kept update?</h5>
                        <p>Subscribe to our newsletter and stay up to date with the latest news and deals!</p>
                        ");
                EndContext();
                BeginContext(2647, 753, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2028bd0a18bc463694995babfcbb6bf6", async() => {
                    BeginContext(2669, 304, true);
                    WriteLiteral(@"
                            <div class=""row"">
                                <div class=""input-field col s12"">

                                    <input value=""Email"" id=""email"" type=""email"" class=""validate"">
                                    <label for=""email"">Email and Your Name</label>

");
                    EndContext();
                    BeginContext(3070, 323, true);
                    WriteLiteral(@"                                    <input value=""First Name"" id=""first_name2"" type=""text"" class=""validate"">

                                    <input value=""Last Name"" id=""first_name2"" type=""text"" class=""validate"">

                                </div>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3400, 32, true);
                WriteLiteral("\r\n                    </div>\r\n\r\n");
                EndContext();
                BeginContext(3482, 813, true);
                WriteLiteral(@"                    <div class=""col l4 m6 s12"">
                        <h5 class=""white-text"">More About Us</h5>
                        <p class=""grey-text text-lighten-4"">
                            “Oryx is a business consultancy firm. Since inception in 2004, Oryx has garnered the
                            trust of the market leaders and is constantly unlocking world class best practice to
                            companies. Our unparalleled approach has witnessed success stories from start-ups to
                            growing and sophisticated ones; wholesale distribution, high-end retail items, and
                            professional services to complex manufacturing, engineering and construction operations.”
                        </p>
                    </div>


");
                EndContext();
                BeginContext(4354, 2240, true);
                WriteLiteral(@"                    <div class=""col l4 m6 s12"">
                        <h5 class=""white-text"">Links</h5>
                        <ul>
                            <li>
                                <!-- Sizes: tiny: 1rem small: 2remmedium: 4rem large: 6rem-->
                                <p><i class=""small material-icons"">home</i>     101B, Ikeja Way, Dolphin Estate,Ikoyi, Lagos.</p>
                            </li>
                            <li>
                                <!-- Sizes: tiny: 1rem small: 2remmedium: 4rem large: 6rem-->
                                <p><i class=""small material-icons"">contact_phone</i>    +234-703-180-6379, +234-706-462-0664</p>
                            </li>
                            <li>
                                <!-- Sizes: tiny: 1rem small: 2remmedium: 4rem large: 6rem-->
                                <p><i class=""small material-icons"">local_phone</i>      01-463-0603</p>
                            </li>
                            ");
                WriteLiteral(@"<li>
                                <!-- Sizes: tiny: 1rem small: 2remmedium: 4rem large: 6rem-->
                                <p><i class=""small material-icons"">contact_mail</i>     Email : info@oryx-wa.com</p>
                            </li>
                        </ul>
                    </div>




                </div>
            </div>
            <div class=""footer-copyright valign-wrapper"">
                <div class=""container"">
                    © 2018 Oryx
                    <a class=""grey-text text-lighten-4 right"" href=""#!"">More Links</a>
                </div>
            </div>
        </footer>




        <!--Import jQuery before materialize.js-->
        <script type=""text/javascript"" src=""https://code.jquery.com/jquery-2.1.1.min.js""></script>
        <script type=""text/javascript"" src=""js/materialize.min.js""></script>
        <script type=""text/javascript"">


            //carousel-item js for slide
            $(document).ready(function () {
     ");
                WriteLiteral("           $(\'.carousel\').carousel();\r\n            });\r\n\r\n\r\n            $(document).ready(function () {\r\n                M.updateTextFields();\r\n            });\r\n\r\n        </script>\r\n\r\n        ");
                EndContext();
                BeginContext(6595, 41, false);
#line 152 "C:\Users\Adeleke.Amoo\Documents\GitHub\Oryx-wa\OryxAfrica\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(6636, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(6645, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
