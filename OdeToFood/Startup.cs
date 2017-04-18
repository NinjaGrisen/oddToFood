using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using OdeToFood.Services;
using Microsoft.AspNetCore.Routing;
using System;
using OdeToFood.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OdeToFood
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(env.ContentRootPath)
                            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddEntityFrameworkSqlServer()
                .AddEntityFrameworkSqlServer()
                .AddDbContext<OdeToFoodDbContext>(
                options => options.UseSqlServer(Configuration["database:connection"]));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<OdeToFoodDbContext>();

            services.AddSingleton(privider => Configuration);
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IResturantData, SqlResturantData>();
            services.AddScoped<IUserData, SqlUserData>();
            services.AddScoped<IFriendsData, SqlFriendsData>();
        }

        // This method gets called by the runtime. 
        // Use this method to configure the HTTP request pipeline.sss
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env,
            //IGreeter greeter,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /*Includes UseDefaultFiles() and UseStaticFiles() in correct order
             UseDefaultFiles() => looks for a index.html in directory
             UseStaticFiles() Serves upp static files */

            app.UseFileServer();

            app.UseIdentity();

            app.UseMvc(ConfigureRoutes);

            // .Run is a terminal middleware so no other middleware after this will get chained
            app.Run(async (context) =>
            {
                var greeting = "greeter.GetGreeting()";
                await context.Response.WriteAsync(greeting);
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //--Convention routes--//
            //How the default router works
            //Controller=defaultController/Action(public method) name = Default action/Id
            routeBuilder.MapRoute("Default", 
                "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
//ASP.NET Core 1.0 Fundamentals
//aspdotnet-core-1-0-fundamentals 
//https://app.pluralsight.com/player?course=aspdotnet-core-1-0-fundamentals&author=scott-allen&name=aspdotnet-core-1-0-fundamentals-m4&clip=6&mode=live
// Entity framework https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro