using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcore21_mvc_case.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hosting, logging) =>
                {
                    logging.AddConfiguration(hosting.Configuration.GetSection("logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseStartup<Startup>();
        }
    }
}
