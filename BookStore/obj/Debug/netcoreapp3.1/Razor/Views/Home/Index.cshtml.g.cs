#pragma checksum "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "251f38e8f4c4e09b10b721677daa78d0e88215c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
using DataAccessLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251f38e8f4c4e09b10b721677daa78d0e88215c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c0b663a66c9346cdb5b06d9653ec0558d6689a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CreateBookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
   ViewBag.Title = "View Book Reading Event"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n<div class=\"container\">\n\n");
#nullable restore
#line 16 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
     if (signInManager.IsSignedIn(User))

    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n\n            <div class=\"left col-md-6 d-flex flex-column\">\n\n                <h1>Past Event</h1>\n\n\n\n");
#nullable restore
#line 28 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                 foreach (var book in Model)

                {

                    if (book.Date < DateTime.Now)

                    {

                        


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 602, "\"", 662, 1);
#nullable restore
#line 38 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 609, Url.Action("ViewBook", "Book", new { id = book.Id }), 609, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                                                                       Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\n");
#nullable restore
#line 39 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"

                       
                                            }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n            </div>\n\n            <div class=\"col-md-6 d-flex flex-column\">\n\n                <h1>Upcoming Event</h1>\n\n");
#nullable restore
#line 53 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                 foreach (var book in Model)

                {

                    if (book.Date > DateTime.Now)

                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1145, 2);
#nullable restore
#line 61 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1091, Url.Action("ViewBook", "Book", new { id = book.Id }), 1091, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1144, "", 1145, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                                                                    Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\n");
#nullable restore
#line 62 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                            }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n        </div>\n");
#nullable restore
#line 69 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                    }

                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\n\n                            <div class=\"left col-md-6 d-flex flex-column\">\n\n                                <h1>Past Event</h1>\n\n\n\n");
#nullable restore
#line 82 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                 foreach (var book in Model)

                                {

                                    if (book.Date < DateTime.Now && book.EventType == "Public")

                                    {

                                        


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 1860, "\"", 1920, 1);
#nullable restore
#line 92 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1867, Url.Action("ViewBook", "Book", new { id = book.Id }), 1867, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                                                                                       Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\n");
#nullable restore
#line 93 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"

                                        
                                                            }

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n                            </div>\n\n                            <div class=\"col-md-6 d-flex flex-column\">\n\n                                <h1>Upcoming Event</h1>\n\n");
#nullable restore
#line 107 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                 foreach (var book in Model)

                                {

                                    if (book.Date > DateTime.Now && book.EventType == "Public")

                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2610, 2);
#nullable restore
#line 115 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2556, Url.Action("ViewBook", "Book", new { id = book.Id }), 2556, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2609, "", 2610, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                                                                                    Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\n");
#nullable restore
#line 116 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                                            }

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n\n                        </div>\n");
#nullable restore
#line 123 "C:\Users\adarshrai\Downloads\BookStore (2)\BookStore\BookStore\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n\n\n\n\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CreateBookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
