using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EventsApi
{
    /// <summary>
    /// The program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main the args
        /// </summary>
        /// <param name="args">The args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host builder using the specified args
        /// </summary>
        /// <param name="args">The args</param>
        /// <returns>The host builder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}