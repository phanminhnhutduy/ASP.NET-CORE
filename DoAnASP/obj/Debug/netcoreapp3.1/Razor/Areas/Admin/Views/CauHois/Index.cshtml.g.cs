#pragma checksum "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2580028802bb18dc2f79b5c9142e6e08c0b0e4e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CauHois_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CauHois/Index.cshtml")]
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
#line 1 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2580028802bb18dc2f79b5c9142e6e08c0b0e4e0", @"/Areas/Admin/Views/CauHois/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41c8f12160b4158443b76ffed93fd2231c0e0d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CauHois_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnASP.Areas.Admin.Models.CauHoi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Duyet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
              Tiêu Đề
            </th>
            <th>
                Hình Ảnh
            </th>

            <th>
              Loại
            </th>
            <th>
                Nguời tạo
            </th>
            <th>
               Ngày Tạo
            </th>
            <th>
                Ngày Duyệt
            </th>
            <th>
                View
            </th>
            <th>
               Người duyệt
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2580028802bb18dc2f79b5c9142e6e08c0b0e4e06755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1005, "~/cauhoi/", 1005, 9, true);
#nullable restore
#line 50 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
AddHtmlAttributeValue("", 1014, Html.DisplayFor(modelItem => item.HinhAnh), 1014, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.loai.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 57 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                     foreach (var item1 in ViewBag.tentk)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                         if (item.IDNguoiTao == item1.IDTK)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                       Write(item1.Ten);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                                      ;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayDuyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.View));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 75 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                     foreach (var item1 in ViewBag.tentk)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                         if (item.IDNguoiDuyet == item1.IDTK)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                       Write(item1.Ten);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                                      ;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 83 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                 if (item.TrangThai == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n\r\n                     \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2580028802bb18dc2f79b5c9142e6e08c0b0e4e012668", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                                                  WriteLiteral(item.IDBlog);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2580028802bb18dc2f79b5c9142e6e08c0b0e4e014865", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                                                 WriteLiteral(item.IDBlog);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 91 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                 if (item.TrangThai != 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2580028802bb18dc2f79b5c9142e6e08c0b0e4e017547", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2702, "\"", 2722, 1);
#nullable restore
#line 97 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
WriteAttributeValue("", 2710, item.IDBlog, 2710, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Duyet\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </td>\r\n");
#nullable restore
#line 102 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 104 "C:\Users\MacBook\Desktop\ASP.NET-CORE\DoAnASP\Areas\Admin\Views\CauHois\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnASP.Areas.Admin.Models.CauHoi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
