using System.Globalization;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


using Catalog.Architecture.Services;
using Catalog.Infrastructure;

namespace Catalog
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddLocalization(options =>
            {
                options.ResourcesPath = "Resources";
            });
            builder.Services.AddScoped<IStringLocalizer<App>, StringLocalizer<App>>();

            builder.Services.AddArchitecturePageViewModel();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var app = builder.Build();

            await builder.Build().RunAsync();
        }
    }
}
