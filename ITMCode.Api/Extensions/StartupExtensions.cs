using Autofac;
using Autofac.Extensions.DependencyInjection;
using ITMCode.Piatnica.Dal;
using ITMCode.Piatnica.Infrastructure.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api
{
    public static class StartupExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PiatnicaContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("Piatnica")), ServiceLifetime.Scoped);
            //services.AddDbContext<ApplicationIdentityDbContext>(options =>
            //       options.UseSqlServer(configuration.GetConnectionString("DampakIdentity")), ServiceLifetime.Scoped);
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                var security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer", new string[] { }},
                };
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.AddSecurityRequirement(security);
                c.IncludeXmlComments(string.Format(@"{0}\PiatnicaApi.xml",System.AppDomain.CurrentDomain.BaseDirectory));

            });
        }
        public static void ConfigureCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                 builder =>
                 {
                     builder.AllowAnyOrigin();
                     builder.AllowAnyMethod();
                     builder.AllowAnyHeader();
                     builder.AllowCredentials();
                 });
            });
        }
        public static IServiceProvider ConfigureAutofac(this IServiceCollection services, IConfiguration  configuration)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);
            containerBuilder.RegisterInstance(configuration);
            containerBuilder.RegisterModule<ContainerModule>();

            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }


        //public static void ConfigureIdentity(this IServiceCollection serviceProvider)
        //{
        //    serviceProvider.AddIdentity<ApplicationUser, IdentityRole>(options =>
        //    {
        //        // Password settings.
        //        options.Password.RequireDigit = true;
        //        options.Password.RequireLowercase = false;
        //        options.Password.RequireNonAlphanumeric = false;
        //        options.Password.RequireUppercase = true;
        //        options.Password.RequiredLength = 6;
        //        options.Password.RequiredUniqueChars = 0;

        //        // Lockout settings.
        //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        //        options.Lockout.MaxFailedAccessAttempts = 5;
        //        options.Lockout.AllowedForNewUsers = true;

        //        // User settings.
        //        options.User.AllowedUserNameCharacters =
        //        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
        //        options.User.RequireUniqueEmail = false;
        //    }).AddEntityFrameworkStores<ApplicationIdentityDbContext>()
        //     .AddDefaultTokenProviders();
        //}

        //public static async Task ConfigureAuthentication(this IServiceProvider serviceProvider, IConfiguration configuration)
        //{

        //    //initializing custom roles 
        //    var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //    string[] roleNames = { "Admin", "Serwisant", "Kierownik", "SuperAdmin" };
        //    IdentityResult roleResult;

        //    foreach (var roleName in roleNames)
        //    {
        //        var roleExist = await RoleManager.RoleExistsAsync(roleName);
        //        if (!roleExist)
        //        {
        //            //create the roles and seed them to the database: Question 1
        //            roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
        //        }
        //    }

        //    //Here you could create a super user who will maintain the web app
        //    var poweruser = new ApplicationUser
        //    {

        //        UserName = configuration["SuperAdmin:UserName"],
        //        Email = configuration["SuperAdmin:UserEmail"],
        //    };
        //    //Ensure you have these values in your appsettings.json file
        //    string userPWD = configuration["SuperAdmin:UserPassword"];
        //    var _user = await UserManager.FindByEmailAsync(configuration["SuperAdmin:UserEmail"]);

        //    if (_user == null)
        //    {
        //        var createPowerUser = await UserManager.CreateAsync(poweruser, userPWD);
        //        if (createPowerUser.Succeeded)
        //        {
        //            //here we tie the new user to the role
        //            await UserManager.AddToRoleAsync(poweruser, "SuperAdmin");

        //        }
        //    }
        //}

        public static void ConfigureAuthentication(this IServiceCollection serviceProvider, IConfiguration configuration)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            serviceProvider.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

           }).AddJwtBearer(cfg =>
           {
               cfg.RequireHttpsMetadata = false;
               cfg.SaveToken = true;
               cfg.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidIssuer = configuration["Jwt:JwtIssuer"],
                   ValidAudience = configuration["Jwt:JwtIssuer"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:JwtKey"])),
                   ClockSkew = TimeSpan.Zero // remove delay of token when expire
                };
           });
        }

    }
}
