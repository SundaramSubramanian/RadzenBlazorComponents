#pragma checksum "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efb508b91ed011e7954c4b935548fd417b6d9ec9"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenBlazorComponents.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using RadzenBlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using RadzenBlazorComponents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"rz-sidebar\" b-p5zehkalwu></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "rz-sidebar");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\Shared\NavMenu.razor"
                                  ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "style", "top: 51px; bottom: 0px; width: 250px;; transform: translateX(0px);");
            __builder.AddAttribute(5, "b-p5zehkalwu");
            __builder.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(6);
            __builder.AddAttribute(7, "Style", "width:300px");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(9, "ul");
                __builder2.AddAttribute(10, "class", "rz-panel-menu");
                __builder2.AddAttribute(11, "b-p5zehkalwu");
                __builder2.OpenElement(12, "li");
                __builder2.AddAttribute(13, "class", "rz-navigation-item");
                __builder2.AddAttribute(14, "b-p5zehkalwu");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(15);
                __builder2.AddAttribute(16, "Text", "Home");
                __builder2.AddAttribute(17, "Icon", "home");
                __builder2.AddAttribute(18, "Path", "/");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "rz-navigation-item");
                __builder2.AddAttribute(22, "b-p5zehkalwu");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(23);
                __builder2.AddAttribute(24, "Text", "Counter");
                __builder2.AddAttribute(25, "Icon", "zoom_in");
                __builder2.AddAttribute(26, "Path", "counter");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "class", "rz-navigation-item");
                __builder2.AddAttribute(30, "b-p5zehkalwu");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(31);
                __builder2.AddAttribute(32, "Text", "Fetch Data");
                __builder2.AddAttribute(33, "Icon", "zoom_out");
                __builder2.AddAttribute(34, "Path", "fetchdata");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
