﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Newtonsoft.Json.Serialization;

namespace aspCoreAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
/*                .AddJsonOptions(o =>
                            {
                                if (o.SerializerSettings.ContractResolver != null)
                                {
                                    var castedResolver = o.SerializerSettings.ContractResolver as DefaultContractResolver;
                                    castedResolver.NamingStrategy = null;//do this to return json attribute names exactly as defined in the class or create a custom naming strategy
                                }
                            });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
/*            else
            {
                app.UseExceptionHandler();
            }*/

            app.UseStatusCodePages();//returns HTML page with error status code when necessary

            app.UseMvc();

/*            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
