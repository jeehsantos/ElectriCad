#pragma checksum "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb213a00479200ed93b242e6be698d1c3b9aceb"
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
#line 1 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\_ViewImports.cshtml"
using Electricad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\_ViewImports.cshtml"
using Electricad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\_ViewImports.cshtml"
using Electricad.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb213a00479200ed93b242e6be698d1c3b9aceb", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155abf9e44446b34afc487c3c85311c2ce64a214", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logintest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb213a00479200ed93b242e6be698d1c3b9aceb6756", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Electricad</title>
    <!-- Favicons -->
    <link rel=""shortcut icon"" type=""image/jpg"" href=""assets/img/logo-icon.png"" />
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,600,600i,700,700i,900"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/icofont/icofont.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/animate.css/animate.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/venobox/venobox.css"" rel=""stylesheet"">
    <link href=""assets/vendor/owl.carousel/assets/owl.carousel.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""assets/vendor/boxicons/css/bootstrap-icons.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnj");
                WriteLiteral(@"s.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"" />
   
    <!-- Template Main CSS File
    <link href=""assets/css/style.css"" rel=""stylesheet"">-->
    <!--<link rel=""stylesheet"" href=""~/lib/bootstrap/dist/css/bootstrap.min.css"" />-->
    <link rel=""stylesheet"" href=""assets/css/style.css"" />
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb213a00479200ed93b242e6be698d1c3b9aceb9523", async() => {
                WriteLiteral(@"

    <!-- ======= Top Bar ======= -->
    <section id=""topbar"" class=""d-none d-lg-block"">
        <div class=""container clearfix"">
            <div class=""social-links float-right"">
                <a href=""https://www.facebook.com/ElectriCad-400795126746237"" target=""_blank"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
                <a href=""https://www.instagram.com/electricad_nz/"" target=""_blank"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
            </div>
            <div class=""contact-info float-right"">
                <i class=""icofont-phone""></i> <a href=""tel:220270465"">+64 22 027 0465</a>
                <i class=""icofont-envelope""></i><a href=""mailto:electricad2010@gmail.com"">electricad2010@gmail.com</a>
            </div>
        </div>
    </section>

    <!-- ======= Header ======= -->
    <header id=""header"">
        <div class=""container"">

            <div class=""logo float-left"">
                <a><img src=""assets/img/logo.png"" alt=""Electricad Logo");
                WriteLiteral("\" class=\"img-fluid\"></a>\r\n            </div>\r\n\r\n            <nav class=\"nav-menu float-right d-none d-lg-block\">\r\n                <ul>\r\n                    <li class=\"active\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb213a00479200ed93b242e6be698d1c3b9aceb11072", async() => {
                    WriteLiteral("Home");
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                    <li><a href=""#about"">About Us</a></li>
                    <li><a href=""#services"">Services</a></li>
                    <li><a href=""#portfolio"">Portfolio</a></li>
                    <li><a href=""#testimonials"">Experiences</a></li>
                    <li><a href=""#contact"">Contact Us</a></li>
                </ul>
            </nav><!-- .nav-menu -->

        </div>
    </header><!-- End Header -->

    <main role=""main"" class=""pb-3"">
        ");
#nullable restore
#line 67 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>



    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""footer-top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""logo float-left"">
                        <a href=""index.html""><img src=""assets/img/logowhite.png"" alt=""Electricad Logo"" class=""img-fluid""></a>
                    </div>
                    <div class=""col-lg- col-md- footer-info col-12 text-center"">
                        <div class=""social-links mt-6 text-center"">
                            <a href=""https://www.instagram.com/electricad_nz/"" target=""_blank"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
                            <a href=""https://www.facebook.com/ElectriCad-400795126746237"" target=""_blank"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
                            <a href=""mailto:electricad2010@gmail.com"" class=""google-plus""><i class=""bx bx-envelope""></i></a>
                        </div>
        ");
                WriteLiteral(@"                <div class=""form-row"">
                            <div class=""col-lg- col-md-2 footer-links"">
                                <a href=""#""><h4>Home</h4></a>
                            </div>
                            <div class=""col-lg- col-md-2 footer-links"">
                                <a href=""#about""><h4>About Us</h4></a>
                            </div>
                            <div class=""col-lg- col-md-2 footer-links"">
                                <a href=""#services""><h4>Services</h4></a>
                            </div>
                            <div class=""col-lg- col-md-2 footer-links"">
                                <a href=""#portfolio""><h4>Portfolio</h4></a>
                            </div>
                            <div class=""col-lg- col-md-2 footer-links"">
                                <a href=""#testimonials""><h4>Experiences</h4></a>
                            </div>
                            <div class=""col-lg- col-md-2 footer-links""");
                WriteLiteral(@">
                                <a href=""#contact""><h4>Contact Us</h4></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>Aspire2</span></strong>. All Rights Reserved
            </div>
            <div class=""credits"">
                Designed by <a href=""#"">the crew</a>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb213a00479200ed93b242e6be698d1c3b9aceb16167", async() => {
                    WriteLiteral("Login");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </footer><!-- End Footer -->\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cb213a00479200ed93b242e6be698d1c3b9aceb18085", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                WriteLiteral(@"    <a href=""#"" class=""back-to-top""><i class=""icofont-simple-up""></i></a>

    <!-- Vendor JS Files -->
    <script src=""assets/vendor/jquery/jquery.min.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/jquery.easing/jquery.easing.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb213a00479200ed93b242e6be698d1c3b9aceb19742", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""assets/vendor/jquery-sticky/jquery.sticky.js""></script>
    <script src=""assets/vendor/venobox/venobox.min.js""></script>
    <script src=""assets/vendor/waypoints/jquery.waypoints.min.js""></script>
    <script src=""assets/vendor/counterup/counterup.min.js""></script>
    <script src=""assets/vendor/owl.carousel/owl.carousel.min.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/aos/aos.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>
    <!--<script src=""~/lib/jquery/dist/jquery.min.js""></script>
    <script src=""~/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""~/js/site.js"" asp-append-version=""true""></script>
    ");
#nullable restore
#line 145 "C:\Users\jeehs\OneDrive\Documentos\GitHub\ElectriCad\Electricad\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        -->\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
