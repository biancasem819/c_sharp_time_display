using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TimeDisplay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // DateTime now = DateTime.Now;
            // Console.WriteLine(now.ToString("ddd MMM %d, yyyy"));
            // Console.WriteLine(now.ToString("hh:mm:ss tt"));
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



