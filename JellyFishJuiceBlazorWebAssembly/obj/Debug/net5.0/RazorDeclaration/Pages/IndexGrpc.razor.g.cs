// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JellyFishJuiceBlazorWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyStaticBlazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\IndexGrpc.razor"
using JellyStaticBlazor.Common.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/indexgrpc")]
    public partial class IndexGrpc : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\IndexGrpc.razor"
 
    string APIResult = "";
    string GRPCResult = "";
    string PersonResult = "";
    List<Person> People;

    async Task APIButtonClicked()
    {
        APIResult = "Loading...";
        await InvokeAsync(StateHasChanged);
        var startTime = DateTime.Now;
        People = await ApiService.GetAll();
        if (People != null)
        {
            var elapsed = DateTime.Now.Subtract(startTime);
            APIResult = $"{People.Count} records returned via API in {elapsed.TotalMilliseconds} ms.";
            await InvokeAsync(StateHasChanged);
        }

    }

    async Task GRPCButtonClicked()
    {
        GRPCResult = "Loading...";
        await InvokeAsync(StateHasChanged);

        var startTime = DateTime.Now;
        var list = await PeopleClient.GetAll(new GetAllPeopleRequest());

        if (list != null)
        {
            People = list.People.ToList();
            var elapsed = DateTime.Now.Subtract(startTime);
            GRPCResult = $"{People.Count} records returned via gRPC in {elapsed.TotalMilliseconds} ms.";
            await InvokeAsync(StateHasChanged);
        }
    }

    async Task GRPCGetRandomPersonButtonClicked()
    {
        var obj = new object();
        var rnd = new Random(obj.GetHashCode());
        int RandomId = rnd.Next(1, 5000);
        var request = new GetPersonByIdRequest { Id = RandomId };

        var person = await PeopleClient.GetPersonById(request);

        if (person != null)
        {
            PersonResult = $"{person.Id} {person.FirstName} {person.LastName}";
            await InvokeAsync(StateHasChanged);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleService PeopleClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
