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
#line 12 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\CodeTests.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\CodeTests.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\CodeTests.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\CodeTests.razor"
using JellyFishJuiceBlazorWebAssembly.Controllers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/codetests")]
    public partial class CodeTests : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\CodeTests.razor"
       

    public List<TestDTO> codecamps = new List<TestDTO>();

    protected override async Task OnInitializedAsync()
    {
        codecamps = await TestService.GetTests();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService TestService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
