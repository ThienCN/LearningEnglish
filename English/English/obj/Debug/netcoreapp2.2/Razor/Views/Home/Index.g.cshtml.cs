#pragma checksum "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc04152fb39891081c5fd580c4bf9394e44dc49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Admin\Desktop\English\English\Views\_ViewImports.cshtml"
using English;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\English\English\Views\_ViewImports.cshtml"
using English.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc04152fb39891081c5fd580c4bf9394e44dc49", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b578312621e83ae68625a253e0407302d9d2ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<English.ViewModels.AnimalsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(95, 121, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to study English website</h1>\r\n\r\n    <div class=\"board\">\r\n");
            EndContext();
#line 10 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
         foreach (var a in Model)
        {

#line default
#line hidden
            BeginContext(262, 88, true);
            WriteLiteral("            <div class=\"square\">\r\n\r\n                <img src=\"/images/question-mark.png\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 350, "\"", 361, 1);
#line 14 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
WriteAttributeValue("", 356, a.Id, 356, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(362, 12, true);
            WriteLiteral(" data-name=\"");
            EndContext();
            BeginContext(375, 6, false);
#line 14 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                                       Write(a.Name);

#line default
#line hidden
            EndContext();
            BeginContext(381, 19, true);
            WriteLiteral("\" data-vietnamese=\"");
            EndContext();
            BeginContext(401, 12, false);
#line 14 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                                                                 Write(a.Vietnamese);

#line default
#line hidden
            EndContext();
            BeginContext(413, 13, true);
            WriteLiteral("\" data-mode=\"");
            EndContext();
            BeginContext(427, 6, false);
#line 14 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                                                                                           Write(a.Mode);

#line default
#line hidden
            EndContext();
            BeginContext(433, 59, true);
            WriteLiteral("\"\r\n                     onerror=\"this.style.display=\'none\'\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                     onclick=\"", 492, "\"", 560, 4);
            WriteAttributeValue("", 524, "changeImage(\'", 524, 13, true);
#line 16 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
WriteAttributeValue("", 537, a.ImageUrl, 537, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 548, "\',", 548, 2, true);
            WriteAttributeValue(" ", 550, "$(this));", 551, 10, true);
            EndWriteAttribute();
            BeginContext(561, 13, true);
            WriteLiteral(" data-sound=\"");
            EndContext();
            BeginContext(575, 10, false);
#line 16 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                                           Write(a.SoundUrl);

#line default
#line hidden
            EndContext();
            BeginContext(585, 18, true);
            WriteLiteral("\" data-pronounce=\"");
            EndContext();
            BeginContext(604, 14, false);
#line 16 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                                                                        Write(a.PronounceUrl);

#line default
#line hidden
            EndContext();
            BeginContext(618, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("image", " image=\"", 619, "\"", 638, 1);
#line 16 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
WriteAttributeValue("", 627, a.ImageUrl, 627, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(639, 58, true);
            WriteLiteral(" />\r\n                <div class=\"text centered\" hidden><a>");
            EndContext();
            BeginContext(698, 6, false);
#line 17 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
                                                Write(a.Name);

#line default
#line hidden
            EndContext();
            BeginContext(704, 36, true);
            WriteLiteral("</a></div>\r\n\r\n\r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\Admin\Desktop\English\English\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(751, 1466, true);
            WriteLiteral(@"
    </div>

    <div class=""modal fade"" id=""myModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title""></h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>

                <!-- Modal body -->
                <div class=""modal-body"">
                    <img src=""//"" />
                </div>

                <!-- Modal footer -->
                <div class=""modal-footer"">
                    <audio controls id=""sound"" hidden>
                        <source src=""//"" type=""audio/mp3"" />
                        <source src=""//"" type=""audio/ogg"" />
                        <source src=""//"" type=""audio/mpeg"" />
                    </audio>
                    <audio controls id=""pronounce"">
                        <source src=""//"" type=""audio/mp3"" />
                 ");
            WriteLiteral(@"       <source src=""//"" type=""audio/ogg"" />
                        <source src=""//"" type=""audio/mpeg"" />
                    </audio>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                </div>

            </div>
        </div>
    </div>

    <div class=""complete"">
        <h1>Congratulation!</h1>
        <h3>You have completed the game</h3>
    </div>

    ");
            EndContext();
            BeginContext(2217, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc04152fb39891081c5fd580c4bf9394e44dc4910409", async() => {
                BeginContext(2285, 8, true);
                WriteLiteral("New game");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            EndContext();
            BeginContext(2297, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<English.ViewModels.AnimalsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591