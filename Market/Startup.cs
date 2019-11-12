using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation.AspNetCore;
using Market.API.Filters;
//using Market.Application.Cameras.Queries.GetCamera;
using Market.Application.Infrastructure;
using Market.Application.Infrastructure.AutoMapper;
using Market.Application.Interfaces;
using Market.Common;
using Market.Infrastructure;
using Market.Persistence;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Cors;
using Market.Application.Hubs;
using Market.Application.BackgroundJob;
using Market.Application.InOutInfo;
using Market.Application.Coordinates;
using Market.API.Logic.PresentationVisits.Query;

namespace Market
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
            services.AddSignalR(hubOptions =>
            {
                hubOptions.KeepAliveInterval = TimeSpan.FromMinutes(1);
            });

            services.AddHostedService<Worker>();

            //where the logic of sending to front resists
            services.AddSingleton<InOut>();

            // Add AutoMapper
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

            // Add framework services.
            services.AddTransient<IDateTime, MachineDateTime>();
            services.AddTransient<IReadService, FileReadService>();

            // Add MediatR
            services.AddMediatR(typeof(GetCoordinatesQueryHandler).GetTypeInfo().Assembly, typeof(GetAllVisitsHandler).GetTypeInfo().Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            // Add DbContext using Postgre SQL Provider
            services.AddDbContext<IConDbContext, ConDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("MarketDatabase"));
            });


            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });


            services
                .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(); //TODO


            services.AddOpenApiDocument(document =>
            {
                document.Title = "MarketAPI";
                document.DocumentName = "1.0";
            });

            services.AddSwaggerDocument(document =>
            {
                document.Title = "Market API";
                document.DocumentName = "b";
            });


            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }



            app.UseSignalR(routes =>
            {
                routes.MapHub<InOutHub>("/inOut");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseOpenApi();
            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/swagger";
                //settings.DocumentPath = "/swagger/specification.json";
            });

            app.UseCors(options => options.AllowAnyOrigin());


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
