#pragma checksum "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47012e1fc90f3817cc619458ea8ff2bd5d2ee90b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projekt2_programowanie.Pages.Users.Pages_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Users/Index.cshtml", typeof(Projekt2_programowanie.Pages.Users.Pages_Users_Index), null)]
namespace Projekt2_programowanie.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\_ViewImports.cshtml"
using Projekt2_programowanie;

#line default
#line hidden
#line 3 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\_ViewImports.cshtml"
using Projekt2_programowanie.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47012e1fc90f3817cc619458ea8ff2bd5d2ee90b", @"/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4d3ec816c1f37a0a05d9985ff3df2beba175e6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 3635, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47012e1fc90f3817cc619458ea8ff2bd5d2ee90b6353", async() => {
                BeginContext(187, 235, true);
                WriteLiteral("\r\n    <br /> <br />\r\n           <div class=\"row\">\r\n               <div class=\" col-6\">\r\n                   <h2 class=\"text-info\">Users List</h2>\r\n               </div>\r\n               <div class=\"col-6 text-right\">\r\n                   ");
                EndContext();
                BeginContext(422, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47012e1fc90f3817cc619458ea8ff2bd5d2ee90b6989", async() => {
                    BeginContext(495, 15, true);
                    WriteLiteral("Create New User");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(514, 404, true);
                WriteLiteral(@"
               </div>
           </div>

    <div class=""border backgroundWhite"" style=""background-color:white;"">
        <div style=""height:60px;"" class=""container border border-secondary"">
            <div class=""row"">
                <div class=""col-11"">
                    <div class=""row"" style=""padding-top:10px"">
                        <div class=""col-4"">
                            ");
                EndContext();
                BeginContext(919, 110, false);
#line 25 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control", placeholder = "Email..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1029, 107, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            ");
                EndContext();
                BeginContext(1137, 108, false);
#line 28 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", placeholder = "Name..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1245, 107, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            ");
                EndContext();
                BeginContext(1353, 110, false);
#line 31 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control", placeholder = "Phone..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1463, 609, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-1"">
                    <div class=""row"" style=""padding-top:10px; padding-right:15px;"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-info form-control"">Search </button>

                    </div>
                </div>
            </div>

        </div>
        <br/>
        <div>
            <table class=""table table-striped border"">
                <tr class=""table-secondary"">
                    <th>
                        ");
                EndContext();
                BeginContext(2073, 67, false);
#line 49 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].Name));

#line default
#line hidden
                EndContext();
                BeginContext(2140, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2220, 74, false);
#line 52 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2294, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2374, 68, false);
#line 55 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.UsersListVM.ApplicationUserList[0].Email));

#line default
#line hidden
                EndContext();
                BeginContext(2442, 114, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
                EndContext();
#line 60 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                 foreach (var item in Model.UsersListVM.ApplicationUserList)
                {

#line default
#line hidden
                BeginContext(2653, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2726, 31, false);
#line 64 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2757, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2837, 38, false);
#line 67 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2875, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2955, 32, false);
#line 70 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2987, 185, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n    \r\n                    </td>\r\n                    <td style=\"text-align:right;\">\r\n\r\n                 \r\n                        ");
                EndContext();
                BeginContext(3172, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47012e1fc90f3817cc619458ea8ff2bd5d2ee90b15278", async() => {
                    BeginContext(3240, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 78 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3250, 54, true);
                WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 82 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3323, 107, true);
                WriteLiteral("                <tr>\r\n                    <td colspan=\"5\" class=\"text-right\">\r\n                        <div");
                EndContext();
                BeginWriteAttribute("page-model", " page-model=\"", 3430, "\"", 3472, 1);
#line 85 "C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\Projekt2_programowanie\Pages\Users\Index.cshtml"
WriteAttributeValue("", 3443, Model.UsersListVM.PagingInfo, 3443, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3473, 306, true);
                WriteLiteral(@" asp-action=""Index"" page-class=""btn border""
                             page-class-normal=""btn btn-light"" page-class-selected=""btn btn-info active"" class=""btn-group"">

                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3786, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projekt2_programowanie.Pages.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projekt2_programowanie.Pages.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projekt2_programowanie.Pages.Users.IndexModel>)PageContext?.ViewData;
        public Projekt2_programowanie.Pages.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
