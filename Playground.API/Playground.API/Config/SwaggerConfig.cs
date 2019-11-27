using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.API.Config
{
    public static class SwaggerConfig
    {
        public static void RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("MyCRM", new Info { Title = "API", Version = "v1" });
            });
        }

        public static void RegisterSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/MyCRM/swagger.json", "MyCRM API V1");
                c.RoutePrefix = "api/swagger";
            });

        }
    }
}
