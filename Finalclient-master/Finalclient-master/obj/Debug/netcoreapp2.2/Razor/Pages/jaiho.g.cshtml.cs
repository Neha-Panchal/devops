#pragma checksum "/CSYE 7220/hw2/web/Pages/jaiho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9fcba0deed6bd97514b20b562ed524355d3895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(web.Pages.Pages_jaiho), @"mvc.1.0.razor-page", @"/Pages/jaiho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/jaiho.cshtml", typeof(web.Pages.Pages_jaiho), null)]
namespace web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/CSYE 7220/hw2/web/Pages/_ViewImports.cshtml"
using web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9fcba0deed6bd97514b20b562ed524355d3895", @"/Pages/jaiho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899aeb869cd09b2ba6752583e2712da9d81d87c9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_jaiho : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: relative;font-family:fantasy;top:15px;left:2px; color:dodgerblue;font-size:22px;font-weight:900"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 256, true);
            WriteLiteral(@"<script>function ToggleMe() {
        $('#toggleMe').toggle();
        $('#nodis').toggle();
        return false;
    }
    function ToggleMe1() {
        $('#toggleMe').toggle();
        $('#nodis').show();
        return false;
    }</script>
");
            EndContext();
            BeginContext(289, 4198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9fcba0deed6bd97514b20b562ed524355d38954656", async() => {
                BeginContext(326, 34, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    ");
                EndContext();
                BeginContext(360, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9fcba0deed6bd97514b20b562ed524355d38955070", async() => {
                    BeginContext(507, 4, true);
                    WriteLiteral("Back");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(515, 962, true);
                WriteLiteral(@"

    <h1 style=""position: absolute;left: 220px;top:30px;color: white"">Jai Ho - A.R.Rahman</h1><br /><br />


    <a href=""https://open.spotify.com/artist/1mYsTxnqsietFxj1OgoGbG"">
        <img style=""height:40px;width:40px;left:220px;top:100px;position:absolute"" src=""https://flask.neocities.org/ss.jpg"" />
    </a>


    <a href=""https://www.youtube.com/user/Arrahman""><img style=""height:40px;width:40px;left:260px;top:100px;position:absolute"" src=""https://flask.neocities.org/y.jpg"" /></a>



    <div>
        <img src=""https://flask.neocities.org/jhh.jpg"" style=""width: 350px; height: 240px;position: absolute;left: 220px;top:150px""><br><br><br><br><br>
        <iframe width=""560"" height=""315"" style=""position:absolute;bottom:530px; left:660px;width:550px;height:330px"" src=""https://www.youtube.com/embed/xwwAVRyNmgQ"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
");
                EndContext();
                BeginContext(2020, 97, true);
                WriteLiteral("        <p style=\"position: absolute;left: 220px;font-family:monospace;color: white;top:440px\">\r\n");
                EndContext();
                BeginContext(2509, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2522, 24, false);
#line 47 "/CSYE 7220/hw2/web/Pages/jaiho.cshtml"
       Write(Html.Raw(@Model.Lyrics1));

#line default
#line hidden
                EndContext();
                BeginContext(2546, 403, true);
                WriteLiteral(@"
            <a id=""nodis"" onclick=""ToggleMe()"" style=""text-decoration: underline;font-family:cursive;font-size:15px;color:bisque"">...more</a>
        </p><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br /><br /><br /><br /><br /><br /><br /><br><br>
        <p id=""toggleMe"" style=""position: absolute;left: 220px;font-family:monospace;color: white;display:none"">
");
                EndContext();
                BeginContext(4277, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(4290, 24, false);
#line 79 "/CSYE 7220/hw2/web/Pages/jaiho.cshtml"
       Write(Html.Raw(@Model.Lyrics2));

#line default
#line hidden
                EndContext();
                BeginContext(4314, 166, true);
                WriteLiteral("\r\n\r\n            <a onclick=\"ToggleMe()\" style=\"text-decoration: underline;font-family:cursive;font-size:15px;color:bisque\">close</a><br>\r\n        </p>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4487, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<jaihoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jaihoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<jaihoModel>)PageContext?.ViewData;
        public jaihoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591