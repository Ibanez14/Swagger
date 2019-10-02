using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Swagger.Learning
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region Step 2
            // ConfigureServices()

            services.AddSwaggerGen(ops =>
            {
                // SwaggerDoc
                ops.SwaggerDoc("v1", new Info()
                {
                    Title = "My Custom API",
                    Version = "v1",
                    Contact = new Contact() { Email = "shamilms@code.edu.az", Name = "Shamil Sov", Url = "something.com"},
                    Description = "Simple Swagger app for testing",
                    License = new License() { Name = "MIT Licence", Url = "mit.edu.az"}
                });


                #region Adding Documentation Generation Service

                // Adding Documentation Generation Service

                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                ops.IncludeXmlComments(xmlPath);



                #endregion



            });

            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {


            #region Step 2
            // Configure()
            app.UseSwagger();

            app.UseSwaggerUI(ops =>
            {
                ops.SwaggerEndpoint("/swagger/v1/swagger.json", "My Endpoint");
                
                // RoutePrefix
                // This enables swagger on the app root like localhost:5001/
                ops.RoutePrefix = string.Empty;

            });


            #endregion





            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
