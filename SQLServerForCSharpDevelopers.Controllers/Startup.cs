using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using NSwag;

namespace SQLServerForCSharpDevelopers.Controllers {
    public class Startup {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddApiVersioning(o => {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });
            services.AddVersionedApiExplorer(options => options.SubstituteApiVersionInUrl = true);
            services.AddMvc();
            services.AddOpenApiDocument(
                config => {
                    config.PostProcess = doc => {
                        doc.Info.Version = "V1";
                        doc.Info.Title = "Bike Store";
                        doc.Info.Description = "Bike Store";
                        doc.Info.TermsOfService = "None";
                    };
                });
            services.Configure<SwaggerOptions>(Configuration.GetSection(nameof(SwaggerOptions)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
            app.Run(async context => {
                context.Response.Redirect("swagger/index.html");
            });
        }
    }
}
