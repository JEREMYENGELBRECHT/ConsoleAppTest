using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using ConsoleAppTest.Interfaces;
using ConsoleAppTest.persistance;
using ConsoleAppTest.RepositoryLayer;
using ConsoleAppTest.TesterService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;


namespace ConsoleAppTest.EndPoint
{
    public class WebService
    {
        public WebService()
        {
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // 1. Add Authentication Services
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    options.Authority = "https://dev-ciz6a848.auth0.com/";
            //    options.Audience = "http://Fintech.com";
            //});

            services.AddSingleton<IService, TesterService1>();
            services.AddScoped<IRepository, Repository>();

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer("User ID = sa; password = Password123; Database = tester; Pooling = true; "));

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseAuthentication();

            app.UseMvc();
            
        }

    }
}
