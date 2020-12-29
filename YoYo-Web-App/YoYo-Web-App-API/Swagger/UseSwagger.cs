using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoYo_Web_App_API.Swagger
{
    public static class UseSwagger
    {
        /// <summary>Uses the swagger middle ware.</summary>
        /// <param name="app">The application.</param>
        public static void UseSwaggerMiddleWare(this IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Yoyo fitness test APIs V1");
            });
        }

        /// <summary>Adds the swagger configuration setting.</summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddSwaggerConfigurationSetting(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Yoyo fitness test APIs", Version = "v1" });
            });
        }
    }
}
