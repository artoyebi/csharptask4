#pragma checksum "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da3c1915ff8eedaa244710e7d24d498f15a7e351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sqrt_GetSquareRoot), @"mvc.1.0.view", @"/Views/Sqrt/GetSquareRoot.cshtml")]
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
#line 1 "C:\Users\Remote Learning\SquareRoot\Views\_ViewImports.cshtml"
using SquareRoot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Remote Learning\SquareRoot\Views\_ViewImports.cshtml"
using SquareRoot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da3c1915ff8eedaa244710e7d24d498f15a7e351", @"/Views/Sqrt/GetSquareRoot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9302147c1020688a0d938d9ca136c6de76106c17", @"/Views/_ViewImports.cshtml")]
    public class Views_Sqrt_GetSquareRoot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sqrt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetSquareRoot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
  
    ViewData["Title"] = "Compare Square Roots";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Enter The Two Numbers To Compare The Square Roots</p>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da3c1915ff8eedaa244710e7d24d498f15a7e3514600", async() => {
                WriteLiteral(@"
       <p> <input type=""number"" min=""0"" placeholder=""Enter First Number"" name=""firstNumber"" > </p>
       <p> <input type=""number"" min=""0"" placeholder=""Enter Second Number"" name=""secondNumber""> </p>
       <p> <button type=""submit"">Submit</button> </p>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
     if (@ViewBag.FirstNumber !=null && @ViewBag.SecondNumber != null)
    {
            


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>First Number is: ");
#nullable restore
#line 23 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
                       Write(ViewBag.FirstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n        <p>Second Number is: ");
#nullable restore
#line 24 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
                        Write(ViewBag.SecondNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Root of First Number: ");
#nullable restore
#line 25 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
                            Write(ViewBag.FirstRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n        <p>Root of Second Number: ");
#nullable restore
#line 26 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
                             Write(ViewBag.SecondRoot);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n        <p style=\"color: red;\"> ");
#nullable restore
#line 27 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 28 "C:\Users\Remote Learning\SquareRoot\Views\Sqrt\GetSquareRoot.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n</div>\r\n");
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