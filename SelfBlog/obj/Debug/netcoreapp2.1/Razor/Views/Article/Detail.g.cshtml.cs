#pragma checksum "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74299339078efc9734fcd7302edd9ffa6e5ba022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Detail), @"mvc.1.0.view", @"/Views/Article/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Article/Detail.cshtml", typeof(AspNetCore.Views_Article_Detail))]
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
#line 1 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\_ViewImports.cshtml"
using SelfBlog;

#line default
#line hidden
#line 2 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\_ViewImports.cshtml"
using SelfBlog.Models;

#line default
#line hidden
#line 1 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
using SelfBlog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74299339078efc9734fcd7302edd9ffa6e5ba022", @"/Views/Article/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a4ed0ed94554199767bf3e07d970b31d143194", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/utf8-net/third-party/SyntaxHighlighter/shCoreDefault.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/utf8-net/third-party/SyntaxHighlighter/shCore.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(90, 72, true);
            WriteLiteral("<div class=\"article-header\">\r\n    <h2 class=\"article-title\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 162, "\"", 223, 1);
#line 8 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
WriteAttributeValue("", 169, Url.Action("Detail", "Article", new { id = Model.Id}), 169, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(224, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(226, 11, false);
#line 8 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(237, 66, true);
            WriteLiteral("</a>\r\n    </h2>\r\n    <p class=\"article-cite\">\r\n        <span>- 作者：");
            EndContext();
            BeginContext(304, 17, false);
#line 11 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
              Write(Model.AccountName);

#line default
#line hidden
            EndContext();
            BeginContext(321, 28, true);
            WriteLiteral("</span>\r\n        <span>- 日期：");
            EndContext();
            BeginContext(350, 48, false);
#line 12 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
              Write(Model.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(398, 30, true);
            WriteLiteral("</span>\r\n        <span>- 分类：<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 428, "\"", 513, 1);
#line 13 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
WriteAttributeValue("", 435, Url.Action("List", "Article", new { page = 1, categoryId = Model.CategoryId}), 435, 78, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(514, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(516, 19, false);
#line 13 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                                                       Write(Model.CategoryTitle);

#line default
#line hidden
            EndContext();
            BeginContext(535, 63, true);
            WriteLiteral("</a></span>\r\n    </p>\r\n</div>\r\n<div class=\"article-body\">\r\n    ");
            EndContext();
            BeginContext(599, 23, false);
#line 17 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(622, 58, true);
            WriteLiteral("\r\n</div>\r\n<nav class=\"article-nav\">\r\n    <p>\r\n        上一篇：");
            EndContext();
#line 21 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
             if (Model.Prev == null)
        {
            

#line default
#line hidden
            BeginContext(735, 2, true);
            WriteLiteral("无。");
            EndContext();
#line 23 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                           
        }
        else
        {

#line default
#line hidden
            BeginContext(782, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 862, 1);
#line 27 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
WriteAttributeValue("", 803, Url.Action("Detail", "Article", new { id = Model.Prev.Id}), 803, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(863, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(865, 16, false);
#line 27 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                             Write(Model.Prev.Title);

#line default
#line hidden
            EndContext();
            BeginContext(881, 8, true);
            WriteLiteral(" (<span>");
            EndContext();
            BeginContext(890, 44, false);
#line 27 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                                                      Write(Model.Prev.CreateTime.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(934, 14, true);
            WriteLiteral("</span>)</a>\r\n");
            EndContext();
#line 28 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(959, 31, true);
            WriteLiteral("    </p>\r\n    <p>\r\n        下一篇：");
            EndContext();
#line 31 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
             if (Model.Next == null)
        {
            

#line default
#line hidden
            BeginContext(1045, 2, true);
            WriteLiteral("无。");
            EndContext();
#line 33 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                           
        }
        else
        {

#line default
#line hidden
            BeginContext(1092, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1172, 1);
#line 37 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
WriteAttributeValue("", 1113, Url.Action("Detail", "Article", new { id = Model.Next.Id}), 1113, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1173, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1175, 16, false);
#line 37 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                             Write(Model.Next.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1191, 8, true);
            WriteLiteral(" (<span>");
            EndContext();
            BeginContext(1200, 44, false);
#line 37 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
                                                                                                      Write(Model.Next.CreateTime.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 14, true);
            WriteLiteral("</span>)</a>\r\n");
            EndContext();
#line 38 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(1269, 18, true);
            WriteLiteral("    </p>\r\n</nav>\r\n");
            EndContext();
            BeginContext(1287, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f433e43c41a474aa2a0383a67e20c2b", async() => {
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
            EndContext();
            BeginContext(1382, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1384, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e701deeefb2144d4800d2abe45a69671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 50, true);
            WriteLiteral("\r\n<script>\r\n    SyntaxHighlighter.all()\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
