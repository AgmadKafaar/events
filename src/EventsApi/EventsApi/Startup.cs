using Events.Shared.Infrastructure.Data;
using EventsApi.MappingProfile;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using Events.Shared.Services;

namespace EventsApi
{
    /// <summary>
    /// The startup class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class
        /// </summary>
        /// <param name="configuration">The configuration</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the value of the configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// Configures the app
        /// </summary>
        /// <param name="app">The app</param>
        /// <param name="env">The env</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EventsApi v1"));
            }

            app.UseProblemDetails();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// Configures the services using the specified services
        /// </summary>
        /// <param name="services">The services</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(EventsMappingProfile)));
            services.AddProblemDetails();
            
            // in real world, would not use sqlite - but rather a DBMS like pgsql, mysql, mssql or mariadb.
            // and would get connection string from a .env file or secrets store.
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath = System.IO.Path.Join(path, "events.db");
            services.AddDbContext<EventsContext>(
                options => options.UseSqlite(dbPath)
                );

            services.AddScoped<IEventService, EventService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EventsApi", Version = "v1" });
            });
        }
    }
}