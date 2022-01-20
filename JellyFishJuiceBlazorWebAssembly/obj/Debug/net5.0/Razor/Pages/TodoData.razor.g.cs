#pragma checksum "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e2143720293a9f6b3df5e2365e3e6da4735362"
// <auto-generated/>
#pragma warning disable 1591
namespace JellyFishJuiceBlazorWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
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
#line 3 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
using JellyFishJuiceBlazorWebAssembly.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tododata")]
    public partial class TodoData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
 if (todoItems == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>No Todo Items found.</p>");
#nullable restore
#line 13 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "ul");
#nullable restore
#line 17 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
         foreach (var item in todoItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
#nullable restore
#line 19 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
__builder.AddContent(3, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\TodoData.razor"
       

    private TodoItem[] todoItems;

    protected override async Task OnInitializedAsync() =>
        todoItems = await Http.GetFromJsonAsync<TodoItem[]>("https://jellyfishjuice"); // https://localhost:44324/api/TodoItems");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
