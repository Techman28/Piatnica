using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using ITMCode.Piatnica.Api;
using ITMCode.Piatnica.Dal;
using ITMCode.Piatnica.Dal.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog.Extensions.Logging;

namespace ITMCode.Patnica.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc().AddFluentValidation();
            services.ConfigureDbContext(Configuration);
            //services.ConfigureIdentity();
            //services.ConfigureAuthentication(Configuration);
            services.ConfigureSwagger();
            services.ConfigureCORS();

            var provider = services.ConfigureAutofac(Configuration);
          //  provider.ConfigureAuthentication(Configuration).GetAwaiter().GetResult();

            return provider;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddNLog();
            NLog.LogManager.LoadConfiguration("nlog.config");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHsts();

            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "B2B API V1");
            });
            app.ConfigureCustomExceptionMiddleware();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseCors("AllowAllOrigins");
            app.UseMvc();
        }
    }
}
