using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			env.EnvironmentName = EnvironmentName.Production;
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			// add static release files
			else
			{
				DefaultFilesOptions options = new DefaultFilesOptions();
				options.DefaultFileNames.Add("friendlyError.html");
				app.UseDefaultFiles(options);

				app.UseExceptionHandler("/friendlyError");
			}

			app.UseStaticFiles();

			//app.UseWelcomePage();
			// Link to Welcome Page
			//app.UseWelcomePage("/hello");

            app.Run(async (context) =>
            {
				//throw new Exception("Error in app.Run()");
                await context.Response.WriteAsync($"{DateTime.Now.ToString("dd MMM yyyy")}");
            });
        }
    }
}
