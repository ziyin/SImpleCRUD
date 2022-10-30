#pragma checksum "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329647288b045a423814c12e011a4f4e88fa33fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Function_List), @"mvc.1.0.view", @"/Views/Function/List.cshtml")]
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
#line 1 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\_ViewImports.cshtml"
using SImpleCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\_ViewImports.cshtml"
using SImpleCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"329647288b045a423814c12e011a4f4e88fa33fe", @"/Views/Function/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391708d58fae6873fe83fcb7cb8528bed39a39f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Function_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SImpleCRUD.Models.House>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportExcell", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
  
    ViewData["Title"] = "House information list";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .table {
        text-align: center;
        border-collapse: separate;
    }

    font {
        font-family: Microsoft JhengHei;
        font-weight: bold;
        color: #4F4F4F;
        font-size: medium;
    }
</style>

<table class=""table"">
    <thead>
        <tr>
            <th>
                <font>房屋種類</font>
            </th>
            <th>
                <font>樓層</font>
            </th>
            <th>
                <font>坪數</font>
            </th>
            <th>
                <font>屋齡</font>
            </th>
            <th>
                <font>現在屋主</font>
            </th>
            <th>
                <font>價格</font>
            </th>
            <th>
                <font>地址</font>
            </th>
            <th  style=""text-align:left"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329647288b045a423814c12e011a4f4e88fa33fe4488", async() => {
                WriteLiteral("匯出");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 54 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.RoomNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("房 ");
#nullable restore
#line 54 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.HallNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("廳 ");
#nullable restore
#line 54 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
                                                                                                                                                Write(Html.DisplayFor(modelItem => item.BathNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("衛\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.floor));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 樓\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 坪\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.year));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 年\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 萬\r\n            </td>\r\n            <td colspan=\"2\" style=\"text-align:left\">\r\n                ");
#nullable restore
#line 72 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\ziyin\source\repos\SImpleCRUD\SImpleCRUD\Views\Function\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SImpleCRUD.Models.House>> Html { get; private set; }
    }
}
#pragma warning restore 1591