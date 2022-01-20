using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using ProtoBuf.Grpc.Client;
using JellyFishJuiceBlazorWebAssembly.Services;
using JellyStaticBlazor.Common.Models;


namespace JellyFishJuiceBlazorWebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // Get base address Uri
            var baseAddress = new Uri(builder.HostEnvironment.BaseAddress);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ICampService, CampService>();
            builder.Services.AddScoped<ITestService, TestService>();

            // Add the ApiService
            builder.Services.AddScoped<ApiService>();

            // Add the PeopleService that uses gRPC
            builder.Services.AddSingleton(services =>
            {
                // First we need a special Web Handler
                var handler = new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler());
                // Next we create a channel from the base address and a custom HttpClient based on the handler
                var channel = GrpcChannel.ForAddress(baseAddress, new GrpcChannelOptions() { HttpClient = new HttpClient(handler) });
                // Finally, we create the GrpcService to inject into any Blazor page or component
                return channel.CreateGrpcService<IPeopleService>();
            });

            await builder.Build().RunAsync();
        }
    }
}
