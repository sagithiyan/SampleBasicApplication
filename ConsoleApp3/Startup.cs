using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomeMiddleware>();

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env) 
        {
    

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {

                endpoints.MapControllers();
            });
            
        }

        private void Customcode(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Hello form Middleware route ");



            });
        }
    }
}
