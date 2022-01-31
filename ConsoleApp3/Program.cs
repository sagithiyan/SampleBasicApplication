using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            createHostBuilder(args).Build().Run();
        }


        public static IHostBuilder createHostBuilder(string[] args) =>
        

            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost=> 
          {
                webHost.UseStartup<Startup>();
            
          }); 
        
        
    }
}
