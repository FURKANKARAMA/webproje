#pragma checksum "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e2f42a62088183088d23a80a7365606d19cc73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\_ViewImports.cshtml"
using webproje2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\_ViewImports.cshtml"
using webproje2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e2f42a62088183088d23a80a7365606d19cc73", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7590a12a408c3e52b91c7b2c7bec241b0827c1ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<webproje2021.Models.urunler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<\n<!DOCTYPE html>\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2f42a62088183088d23a80a7365606d19cc735501", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <title>Simple House Template</title>
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:400"" rel=""stylesheet"" />
    <link href=""/lib/bootstrap/dist/css/templatemo-style.css"" rel=""stylesheet"" />
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
            WriteLiteral("\n<!--\n\nSimple House\n\nhttps://templatemo.com/tm-539-simple-house\n\n-->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2f42a62088183088d23a80a7365606d19cc736936", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <!-- Top box -->
        <!-- Logo & Site Name -->
        <div class=""placeholder"">
            <div class=""parallax-window"" data-parallax=""scroll"" data-image-src=""/lib/bootstrap/dist/img/photo/simple-house-01.jpg"">
                <div class=""tm-header"">
                    <div class=""row tm-header-inner"">
                        <div class=""col-md-6 col-12"">
                            <img src=""/lib/bootstrap/dist/img/photo/simple-house-logo.png"" alt=""Logo"" class=""tm-site-logo"" />
                            <div class=""tm-site-text-box"">
                                <h1 class=""tm-site-title"">SERDİVAN RESTORANT</h1>
                                <h6 class=""tm-site-description"">Ucuza Kalitenin Adresi</h6>
                            </div>
                        </div>
                        <nav class=""col-md-6 col-12 tm-nav"">
                            <ul class=""tm-nav-ul"">
                                <li class=""tm-nav-ul"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2f42a62088183088d23a80a7365606d19cc738219", async() => {
                    WriteLiteral("<span style=\"color:#ffffff;\">ANASAYFA</span> ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("&emsp;</li>\n                                <li class=\"tm-nav-ul\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2f42a62088183088d23a80a7365606d19cc7310053", async() => {
                    WriteLiteral("<span style=\"color:#ffffff;\">HAKKIMIZDA</span> ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("&emsp;</li>\n                                <li class=\"tm-nav-ul\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e2f42a62088183088d23a80a7365606d19cc7311890", async() => {
                    WriteLiteral("<span style=\"color:#ffffff;\">İLETİŞİM</span> ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>

        <main>
           <br /><br />
            

            <div class=""tm-paging-links"">
                <nav>
                    <ul>
                        <li class=""tm-paging-item""><a href=""#"" class=""tm-paging-link active"">Pizza</a></li>
                        <li class=""tm-paging-item""><a href=""#"" class=""tm-paging-link"">Salad</a></li>
                        <li class=""tm-paging-item""><a href=""#"" class=""tm-paging-link"">Noodle</a></li>
                    </ul>
                </nav>
            </div>

            <!-- Gallery -->
            <div class=""row tm-gallery"">
                <!-- gallery page 1 -->
                <div id=""tm-gallery-page-pizza"" class=""tm-gallery-page"">


");
#nullable restore
#line 76 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                          if (@item.kategori == kategori.Pizza)
                          {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                  <article class=\"col-lg-3 col-md-4 col-sm-6 col-12 tm-gallery-item\">\n                                     <figure>\n                                       <img");
                BeginWriteAttribute("src", " src=\"", 3459, "\"", 3476, 1);
#nullable restore
#line 82 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 3465, item.resim, 3465, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" class=\"img-fluid tm-gallery-img\" />\n                                       <figcaption>\n                                         <h4");
                BeginWriteAttribute("class", " class=\"", 3622, "\"", 3643, 1);
#nullable restore
#line 84 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 3630, item.urunadi, 3630, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 84 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                              Write(item.urunadi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                                            <p");
                BeginWriteAttribute("class", " class=\"", 3710, "\"", 3730, 1);
#nullable restore
#line 85 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 3718, item.kalori, 3718, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Kalori : ");
#nullable restore
#line 85 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                                        Write(item.kalori);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                            <p");
                BeginWriteAttribute("class", " class=\"", 3804, "\"", 3824, 1);
#nullable restore
#line 86 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 3812, item.fiyati, 3812, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span style=\"color:#ff0000;\">");
#nullable restore
#line 86 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                                                            Write(item.fiyati);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span></p>\n                                       </figcaption>\n                                     </figure>\n                                  </article>                \n");
#nullable restore
#line 90 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                           
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                </div> <!-- gallery page 1 -->\n                <!-- gallery page 2 -->\n                <div id=\"tm-gallery-page-salad\" class=\"tm-gallery-page hidden\">\n");
#nullable restore
#line 97 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                 if (@item.kategori == kategori.Salata)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <article class=\"col-lg-3 col-md-4 col-sm-6 col-12 tm-gallery-item\">\n                        <figure>\n                            <img");
                BeginWriteAttribute("src", " src=\"", 4560, "\"", 4577, 1);
#nullable restore
#line 103 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 4566, item.resim, 4566, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" class=\"img-fluid tm-gallery-img\" />\n                            <figcaption>\n                                <h4");
                BeginWriteAttribute("class", " class=\"", 4703, "\"", 4724, 1);
#nullable restore
#line 105 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 4711, item.urunadi, 4711, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 105 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                     Write(item.urunadi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                                <p");
                BeginWriteAttribute("class", " class=\"", 4779, "\"", 4799, 1);
#nullable restore
#line 106 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 4787, item.kalori, 4787, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Kalori : ");
#nullable restore
#line 106 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                            Write(item.kalori);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                <p");
                BeginWriteAttribute("class", " class=\"", 4861, "\"", 4881, 1);
#nullable restore
#line 107 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 4869, item.fiyati, 4869, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span style=\"color:#ff0000;\">");
#nullable restore
#line 107 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                                                Write(item.fiyati);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span></p>\n                            </figcaption>\n                        </figure>\n                    </article>\n");
#nullable restore
#line 111 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div> <!-- gallery page 2 -->\n                <!-- gallery page 3 -->\n                <div id=\"tm-gallery-page-noodle\" class=\"tm-gallery-page hidden\">\n");
#nullable restore
#line 116 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                 if (@item.kategori == kategori.Noodle)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <article class=\"col-lg-3 col-md-4 col-sm-6 col-12 tm-gallery-item\">\n                    <figure>\n                        <img");
                BeginWriteAttribute("src", " src=\"", 5535, "\"", 5552, 1);
#nullable restore
#line 122 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 5541, item.resim, 5541, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" class=\"img-fluid tm-gallery-img\" />\n                        <figcaption>\n                            <h4");
                BeginWriteAttribute("class", " class=\"", 5670, "\"", 5691, 1);
#nullable restore
#line 124 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 5678, item.urunadi, 5678, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 124 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                 Write(item.urunadi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                            <p");
                BeginWriteAttribute("class", " class=\"", 5742, "\"", 5762, 1);
#nullable restore
#line 125 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 5750, item.kalori, 5750, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Kalori : ");
#nullable restore
#line 125 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                        Write(item.kalori);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            <p");
                BeginWriteAttribute("class", " class=\"", 5820, "\"", 5840, 1);
#nullable restore
#line 126 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
WriteAttributeValue("", 5828, item.fiyati, 5828, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span style=\"color:#ff0000;\">");
#nullable restore
#line 126 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                                                            Write(item.fiyati);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span></p>\n                        </figcaption>\n                    </figure>\n                </article>                ");
#nullable restore
#line 129 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\vmain\OneDrive\Masaüstü\webproje9.yükleme\webproje2021\Views\Home\Index.cshtml"
                                           
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div> <!-- gallery page 3 -->
            </div>
            <div class=""tm-section tm-container-inner"">
                <div class=""row"">
                    <div class=""col-md-6"">

                    </div>
                    <div class=""col-md-6"">

                    </div>
                </div>
            </div>
        </main>

        <footer class=""tm-footer text-center"">
        </footer>
    </div>
    <script src=""/lib/bootstrap/dist/js/jquery.min.js""></script>
    <script src=""/lib/bootstrap/dist/js/parallax.min.js""></script>
    <script>$(document).ready(function(){
			// Handle click on paging links
			$('.tm-paging-link').click(function(e){
				e.preventDefault();

				var page = $(this).text().toLowerCase();
				$('.tm-gallery-page').addClass('hidden');
				$('#tm-gallery-page-' + page).removeClass('hidden');
				$('.tm-paging-link').removeClass('active');
				$(this).addClass(""active"");
			});
		});</script>
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<webproje2021.Models.urunler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
