using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;


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

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseMvc();
            
        }

    }
}
