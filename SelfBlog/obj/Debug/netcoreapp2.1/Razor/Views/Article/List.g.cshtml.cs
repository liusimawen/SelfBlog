#pragma checksum "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65531bc18686730d97c6434da095ba8951bb1048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_List), @"mvc.1.0.view", @"/Views/Article/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Article/List.cshtml", typeof(AspNetCore.Views_Article_List))]
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
#line 1 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
using SelfBlog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65531bc18686730d97c6434da095ba8951bb1048", @"/Views/Article/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a4ed0ed94554199767bf3e07d970b31d143194", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<ArticleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
  
    ViewBag.Title = "基于.Net Core个人博客";

#line default
#line hidden
            BeginContext(103, 103, true);
            WriteLiteral("<style>\r\n    .title {\r\n        margin:20px;\r\n        font-size:20px;\r\n    }\n</style>\n<ul class=\"list\">\n");
            EndContext();
#line 14 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(245, 41, true);
            WriteLiteral("        <li class=\"title\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 286, "\"", 347, 1);
#line 17 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
WriteAttributeValue("", 293, Url.Action("Detail", "Article", new { id = item.Id }), 293, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 348, "\"", 367, 1);
#line 17 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
WriteAttributeValue("", 356, item.Title, 356, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(368, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(370, 20, false);
#line 17 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
                                                                                            Write(Html.Raw(item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(390, 8, true);
            WriteLiteral(" (<span>");
            EndContext();
            BeginContext(399, 38, false);
#line 17 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
                                                                                                                         Write(item.CreateTime.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(437, 27, true);
            WriteLiteral("</span>)</a>\n        </li>\n");
            EndContext();
#line 19 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
    }

#line default
#line hidden
            BeginContext(470, 26, true);
            WriteLiteral("</ul>\n<div class=\"pager\">\n");
            EndContext();
#line 22 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
     if (Model.Page <= 1)
    {

#line default
#line hidden
            BeginContext(528, 54, true);
            WriteLiteral("        <a href=\"javascript:void(0);\">&laquo; 上一页</a>\n");
            EndContext();
#line 25 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
    }
    else
    {


#line default
#line hidden
            BeginContext(604, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 614, "\"", 715, 1);
#line 29 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
WriteAttributeValue("", 621, Url.Action("List", "Article", new { page = (Model.Page -1), categoryId = ViewBag.CategoryId}), 621, 94, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(716, 17, true);
            WriteLiteral(">&laquo; 上一页</a>\n");
            EndContext();
#line 30 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
    }

#line default
#line hidden
            BeginContext(739, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 31 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
     if (Model.Page >= Model.PageCount)
    {

#line default
#line hidden
            BeginContext(785, 54, true);
            WriteLiteral("        <a href=\"javascript:void(0);\">下一页 &raquo;</a>\n");
            EndContext();
#line 34 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(860, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 870, "\"", 972, 1);
#line 37 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
WriteAttributeValue("", 877, Url.Action("List", "Article", new { page = (Model.Page + 1), categoryId = ViewBag.CategoryId}), 877, 95, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(973, 17, true);
            WriteLiteral(">下一页 &raquo;</a>\n");
            EndContext();
#line 38 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
    }

#line default
#line hidden
            BeginContext(996, 44, true);
            WriteLiteral("    <small style=\"float:right\">\n        当前页：");
            EndContext();
            BeginContext(1041, 10, false);
#line 40 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
       Write(Model.Page);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 6, true);
            WriteLiteral(" - 页数：");
            EndContext();
            BeginContext(1058, 15, false);
#line 40 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
                        Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 7, true);
            WriteLiteral(" - 文章数：");
            EndContext();
            BeginContext(1081, 11, false);
#line 40 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Views\Article\List.cshtml"
                                               Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 20, true);
            WriteLiteral("\n    </small>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<ArticleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
