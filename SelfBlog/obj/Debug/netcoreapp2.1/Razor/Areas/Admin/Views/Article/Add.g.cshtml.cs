#pragma checksum "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f49678fc5b4cbe9340bf8309a87d6ac5067fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Article_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Article/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Article/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Article_Add))]
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
#line 2 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\_ViewImports.cshtml"
using SelfBlog.Entities;

#line default
#line hidden
#line 3 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\_ViewImports.cshtml"
using SelfBlog.Models;

#line default
#line hidden
#line 4 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\_ViewImports.cshtml"
using SelfBlog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f49678fc5b4cbe9340bf8309a87d6ac5067fe4", @"/Areas/Admin/Views/Article/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bb245f01e2788a7c805caab2051c07b1846605", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Article_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kindeditor/themes/default/default.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kindeditor/kindeditor-all-min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/kindeditor/lang/zh-CN.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/article/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("am-form am-form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return checkValidate();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4baed12c6ac45a3898c41d244199f73", async() => {
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
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "445a20c249c8462b8f5088cbb10ebe23", async() => {
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
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(209, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965aa0b3792d4313a0875f1cc607a417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(263, 162, true);
            WriteLiteral("\r\n\r\n<section class=\"tool-box\">\r\n    <a href=\"javascript:history.go(-1);\" class=\"am-btn am-btn-xs am-btn-default\"><i class=\"am-icon-reply\"></i>返回</a>\r\n</section>\r\n");
            EndContext();
            BeginContext(425, 1140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33836cdec4ab459b85fcd39cf18df6b4", async() => {
                BeginContext(543, 141, true);
                WriteLiteral("\r\n    <div class=\"am-form-group\">\r\n        <label class=\"am-u-sm-2 am-form-label\">标题：</label>\r\n        <div class=\"am-u-sm-10\">\r\n            ");
                EndContext();
                BeginContext(685, 71, false);
#line 16 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { placeholder = "2-100个字符" }));

#line default
#line hidden
                EndContext();
                BeginContext(756, 169, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"am-form-group\">\r\n        <label class=\"am-u-sm-2 am-form-label\">分类：</label>\r\n        <div class=\"am-u-sm-10\">\r\n            ");
                EndContext();
                BeginContext(926, 39, false);
#line 22 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
       Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
                EndContext();
                BeginContext(965, 169, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"am-form-group\">\r\n        <label class=\"am-u-sm-2 am-form-label\">内容：</label>\r\n        <div class=\"am-u-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1135, 64, false);
#line 28 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
       Write(Html.TextAreaFor(model => model.Content,new {@id="kindeditor" }));

#line default
#line hidden
                EndContext();
                BeginContext(1199, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1310, 248, true);
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <div class=\"am-form-group\">\r\n        <div class=\"am-u-sm-10 am-u-sm-offset-2\">\r\n            <button type=\"submit\" class=\"am-btn am-btn-primary\"><i class=\"am-icon-check\"></i>保存</button>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1565, 109, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var editor;\r\n    function checkValidate() {\r\n        var $Title = $(\"#");
            EndContext();
            BeginContext(1675, 32, false);
#line 42 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
                    Write(Html.IdFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 35, true);
            WriteLiteral("\"),\r\n            $CategoryId = $(\"#");
            EndContext();
            BeginContext(1743, 37, false);
#line 43 "E:\Liusimawen个人资料\SelfBlog\SelfBlog\Areas\Admin\Views\Article\Add.cshtml"
                         Write(Html.IdFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 958, true);
            WriteLiteral(@""");
        if (!/.{2,100}/.test($Title.val())) {
            $Title.focus();
            return false;
        }
        if ($CategoryId.val()===""-1"") {
            alert(""请选择分类"");
            return false;
        }
        
        editor.sync();
        if ($('#kindeditor').val().length <= 0) {
            editor.focus();
            alert(""请输入内容！"");
            return false;
        }
        return true;
    }
    //实例化编辑器
    //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
    KindEditor.ready(function (K) {
        editor = K.create('#kindeditor', {
            width: '80%',
            height: '450px',
            uploadJson: '/Admin/Image/ImageUpload',
            fileManagerJson: '/Admin/Image/ImageUpload',
            allowFileManager: true,
            cssPath:""/lib/kindeditor/css/image.css"",
        });
    });
    function add() {
        alert();
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
