using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Theprojector.Data;
using Npgsql.EntityFrameworkCore;

namespace theprojector_vs
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
            // Add framework services.
            services.AddMvc();
            
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<TheprojectorContext>(options =>
                        options.UseNpgsql(this.Configuration.GetConnectionString("TheprojectorContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "persons",
                    template: "{controller=Persons}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "create_person",
                    template: "{controller=Persons}/{action=Create}/{id?}");
                routes.MapRoute(
                    name: "edit_person",
                    template: "{controller=Persons}/{action=Edit}/{id?}");
                routes.MapRoute(
                    name: "delete_person",
                    template: "{controller=Persons}/{action=Delete}/{id?}");

                routes.MapRoute(
                    name: "projects",
                    template: "{controller=Projects}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "create_project",
                    template: "{controller=Projects}/{action=Create}/{id?}");
                routes.MapRoute(
                    name: "edit_project",
                    template: "{controller=Projects}/{action=Edit}/{id?}");
                routes.MapRoute(
                    name: "delete_project",
                    template: "{controller=Projects}/{action=Delete}/{id?}");

                routes.MapRoute(
                    name: "project_assignments",
                    template: "{controller=ProjectAssignments}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "create_project_assignments",
                    template: "{controller=ProjectAssignments}/{action=Create}/{id?}");
                routes.MapRoute(
                    name: "edit_project_assignments",
                    template: "{controller=ProjectAssignments}/{action=Edit}/{id?}");
                routes.MapRoute(
                    name: "delete_project_assignments",
                    template: "{controller=ProjectAssignments}/{action=Delete}/{id?}");
            });
        }
    }
}
