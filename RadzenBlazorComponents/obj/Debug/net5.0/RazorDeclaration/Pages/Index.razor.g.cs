// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenBlazorComponents.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 222 "D:\Projects\RadzenBlazorComponents\RadzenBlazorComponents\Pages\Index.razor"
       
    public class Order
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardHolder { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Country { get; set; }
        public int StoreId { get; set; }
        public string Warehouse { get; set; }
        public string Region { get; set; }
        public string System { get; set; }
        public int TransId { get; set; }
        public string Register { get; set; }
        public string Clerk { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
    }

    public class CreditCard
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    Order order = new Order()
    {
        ExpiryDate = DateTime.Parse("10/10/2022"),
        OrderDate = DateTime.Now,
        ShipDate = DateTime.Now
    };

    List<CreditCard> cards = new List<CreditCard>()
{
        new CreditCard() { CardId = 1, CardNr = "5555555555554444" },
        new CreditCard() { CardId = 2, CardNr = "4012888888881881" }
    };

    List<Country> countries = new List<Country>()
{
        new Country() { Id = 1, Name = "USA" },
        new Country() { Id = 2, Name = "Germany" }
    };

    void Submit(Order arg)
    {
        //
    }

    void Cancel()
    {
        //
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
