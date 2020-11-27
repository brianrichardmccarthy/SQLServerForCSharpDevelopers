using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace SQLServerForCSharpDevelopers.Controllers {
    public class Startup {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostEnvironment env) {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true);
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddOptions();
            services.AddSwaggerGen(x => { x.SwaggerDoc("v1", new OpenApiInfo {
                   Title = "Bike Store API",
                   Version = "V1"
                });
            });
            
            services.Configure<SwaggerOptions>(Configuration.GetSection(nameof(SwaggerOptions)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            
            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

            app.UseSwagger(options => { options.RouteTemplate = swaggerOptions.JsonRoute; });
            app.UseSwaggerUI(options => options.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description));

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
