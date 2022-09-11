using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;
using Microsoft.OpenApi.Models; // for swagger
using System.IO; //for using Path
using System; //for using AppContext.



namespace ParksApi
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
            services.AddDbContext<ParksApiContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers().AddNewtonsoftJson();//added newtonJson to attempt to use PATCH.
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                  Title = "ParksApi", 
                  Version = "V1", 
                  Description = "API for returning State and National Parks" 
                });
            // });

                //attempting to add xml comments to swagger, below we tell it to use xml file 
                var filePath = Path.Combine(AppContext.BaseDirectory, "ParksApi.xml");
                c.IncludeXmlComments(filePath);
            
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //keeping swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ParksApi V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // app.UseHttpsRedirection(); //commented out to ensure browser doesn't prevent access to site and slow things down while in development  
        }
    }
}
