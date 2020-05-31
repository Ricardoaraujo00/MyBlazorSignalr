#pragma checksum "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0467879e1b7061797b74f7f7ae001b46debd0d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyBlazorSignalr.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using MyBlazorSignalr.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\_Imports.razor"
using MyBlazorSignalr.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

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
#line 20 "C:\Users\ricar\source\repos\MyBlazorSignalr\MyBlazorSignalr\Client\Pages\Index.razor"
       
    string url = "http://localhost:44375/notificationhub";

    HubConnection _connection = null;
    bool isConnected = false;
    string connectionStatus = "Closed";

    List<string> notifications = new List<string>();

    private async Task ConnectToServer()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/notificationhub"))
            .Build();

        await _connection.StartAsync();
        isConnected = true;
        connectionStatus = "Connected :-)";

        _connection.Closed += async (s) =>
        {
            isConnected = false;
            connectionStatus = "Disconnected";
            await _connection.StartAsync();
            isConnected = true;
        };

        _connection.On<string>("notification", m =>
        {
            notifications.Add(m);
            StateHasChanged();
        });


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
