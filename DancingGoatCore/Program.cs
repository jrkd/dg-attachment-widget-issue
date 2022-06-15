using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DancingGoat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .UseIISIntegration()
                    .ConfigureKestrel(options =>
                    {
                        options.Listen(System.Net.IPAddress.Parse("127.0.0.1"), 80);
                        options.Listen(System.Net.IPAddress.Parse("127.0.0.1"), 443, opts => { opts.UseHttps(); });
                        options.AddServerHeader = false;
                    })
                    .UseStartup<Startup>();
                });
    }
}
