#pragma checksum "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "997ec9d7bad996d490f298b86cb769090529eca7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClientSideBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using ClientSideBlazor.Client;

#line default
#line hidden
#line 8 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using ClientSideBlazor.Client.Shared;

#line default
#line hidden
#line 9 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using ClientSideBlazor.Client.Services;

#line default
#line hidden
#line 11 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#line 3 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\Pages\FetchData.razor"
using BlazorAuthorization.Shared;

#line default
#line hidden
#line 2 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\Pages\FetchData.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 39 "Z:\Git\chrissainty\RoleBasedAuthWithClientSideBlazor\src\ClientSideBlazor.Client\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
