#pragma checksum "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fdf5da5a130c3ed5e8488fa829dc5a9bb9f30e8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#line 7 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"top-row px-4\">\r\n        <a href=\"https://limeinst.com\" target=\"_blank\" class=\"ml-md-auto\">Lime Instruments</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.AddAttribute(6, "style", "max-width:1400px; margin:auto;");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#line 13 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
