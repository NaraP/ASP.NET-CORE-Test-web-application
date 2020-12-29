using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace YoYo_Web_App_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // Log.Logger = new LoggerConfiguration()
           // .WriteTo.RollingFile("G:\\Practices\\YoYo-Web-App\\log-{Date}.txt")
            //.CreateLogger();
            //Log.CloseAndFlush();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
               // .UseSerilog();

    }
}
