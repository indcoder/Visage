using System.Net.Http;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Checkins.API
{
    public class Program
    {
        private static readonly HttpClient restClient = new HttpClient();
        public IConfiguration Configuration { get; }


        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                    {
                        var builtConfig = config.Build();
                        config.AddAzureKeyVault(
                            $"https://{builtConfig["Vault"]}.vault.azure.net/",
                            builtConfig["CLIENTID"],
                            builtConfig["CLIENTSecret"]
                       );
                    }
                )
                .UseStartup<Startup>();
    }
}
