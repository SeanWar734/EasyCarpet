using EasyCarpet.Web.Services;
using MediatR;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyCarpet.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMediatR(typeof(Program).Assembly);
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddMudServices();
            builder.Services.AddLocalization();

            await builder.Build().RunAsync();
        }
    }
}
