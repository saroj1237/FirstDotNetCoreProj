#pragma checksum "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8757748f86631eb81871d368d36b701c182bb72e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_ApplicationDetail), @"mvc.1.0.view", @"/Views/Application/ApplicationDetail.cshtml")]
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
#line 1 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\_ViewImports.cshtml"
using OnlineApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\_ViewImports.cshtml"
using OnlineApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8757748f86631eb81871d368d36b701c182bb72e", @"/Views/Application/ApplicationDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d263e1c0a349615db2fa61fac6980a62be9647a", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_ApplicationDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/applicationdetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8757748f86631eb81871d368d36b701c182bb72e3858", async() => {
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
            WriteLiteral("\r\n<div class=\"container application\" id=\"content\">\r\n    <div class=\"datefield\">\r\n        Date: ");
#nullable restore
#line 5 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
         Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div>\r\n        To the ");
#nullable restore
#line 9 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
          Write(Model.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
   Write(Model.ReceiverComanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div><div>\r\n        ");
#nullable restore
#line 14 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
   Write(Model.ReceiverAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br /><br />\r\n    <div class=\"subject\">Subject: ");
#nullable restore
#line 17 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
                             Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n    <div>\r\n        Dear Sir,<br />\r\n        <div class=\"body\"><span class=\"para-change\"></span>  ");
#nullable restore
#line 21 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
                                                        Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <br /><br />\r\n\r\n    </div>\r\n    <div class=\"sender-align\">\r\n        <div>Yours Sincerely,</div>\r\n        <div>");
#nullable restore
#line 27 "C:\Users\user\Desktop\DotNet\OnlineApplication\Views\Application\ApplicationDetail.cshtml"
        Write(Model.Sender);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>

</div>
<div id=""editor""></div>
<button id=""cmd"">Download PDF</button>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>

<script src=""https://unpkg.com/jspdf@latest/dist/jspdf.min.js""></script>

<script>
    var doc = new jsPDF();
    var specialElementHandlers = {
        '#editor': function (element, renderer) {
            return true;
        }
    };

    $('#cmd').click(function () {
        doc.fromHTML($('#content').html(), 15, 15, {
            'width': 170,
            'elementHandlers': specialElementHandlers
        });
        doc.save('sample-file.pdf');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application> Html { get; private set; }
    }
}
#pragma warning restore 1591
