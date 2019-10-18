#pragma checksum "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb3101ad009fb446ee1209718d030ac06ad3bc8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
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
#line 3 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
using BlazorApp1.Classes;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lime Cloud Users</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Some of our favorite portal implementations.</p>\r\n\r\n");
#line 8 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
 if (portals == null)
{

#line default
#line hidden
            __builder.AddMarkupContent(2, "<div class=\"spinner-border\" role=\"status\">\r\n    <span class=\"sr-only\">Loading...</span>\r\n</div>\r\n");
#line 13 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
}
else
{

#line default
#line hidden
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "customerCards");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n");
#line 17 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
     foreach (var port in portals)
    {

#line default
#line hidden
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-xl-3 col-lg-4 col-md-6 col-sm-12");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<BlazorApp1.Shared.PortalCard>(11);
            __builder.AddAttribute(12, "portal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Classes.Portal>(
#line 20 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
                             port

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 22 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
        
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#line 25 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(16, @"<style>

    .customerCard{
        margin-bottom:25px;
    }
    .customerCard .card-img-top {
        height: 150px;
        object-fit: cover;
        object-position:bottom;
    }
    .customerCard .card-footer{
        height: 120px;
        text-align:center;
        background-size: contain;
        background-position: center;
        background-repeat: no-repeat;
    }
    .customerCard .card-body{
        height: 300px;
        background-size: contain;
        background-position: center;
        background-repeat: no-repeat;
    }
</style>");
        }
        #pragma warning restore 1998
#line 50 "C:\Lime_Dev\CS\LimeCloud - Copy\BlazorApp1\Pages\Customers.razor"
       

    Portal[] portals;
    protected override async Task OnInitializedAsync()
    {
        portals = await Http.GetJsonAsync<Portal[]>("/sample-data/portals.json");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591