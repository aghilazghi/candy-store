#pragma checksum "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2153e6126d493676b918f05317e58ee4a841480b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candy_List), @"mvc.1.0.view", @"/Views/Candy/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2153e6126d493676b918f05317e58ee4a841480b", @"/Views/Candy/List.cshtml")]
    public class Views_Candy_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CandyStore.Models.Candy>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2153e6126d493676b918f05317e58ee4a841480b2776", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\"/>\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"/>\r\n    <meta name=\"viewport\"/ content=\"width=device-width, initial-scale=1\">\r\n    <title>Candy Store</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2153e6126d493676b918f05317e58ee4a841480b3956", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml"
         foreach(var candy in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <h2>");
#nullable restore
#line 14 "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml"
               Write(candy.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <h3>");
#nullable restore
#line 15 "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml"
               Write(candy.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <h4>");
#nullable restore
#line 16 "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml"
               Write(candy.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\amine.ghilazghi\source\repos\candy-store\CandyStore\CandyStore\Views\Candy\List.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CandyStore.Models.Candy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
