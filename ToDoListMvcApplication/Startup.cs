using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NServiceBus;
using ToDoListApplication.Contract;
using ToDoListApplication.Data.Repositories;
using ToDoListApplication.Services;

namespace ToDoListMvcApplication
{
    public class Startup
    {
        IEndpointInstance _endpointInstance;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddLogging(loggingBuilder => loggingBuilder.AddConsole());
            services.AddSingleton(sp => _endpointInstance);
            services.AddSingleton<IToDoRepository, ToDoRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IToDoService, ToDoService>();
            services.AddScoped<IUserRepository, UserRepository>();

            var endpointConfiguration = new EndpointConfiguration("Sample.Core");
            var transport = endpointConfiguration.UseTransport<LearningTransport>();


            var routing = transport.Routing();
            routing.RouteToEndpoint(typeof(CreateToDoCommand).Assembly, destination: "Sample.Core");

            endpointConfiguration.UseContainer<ServicesBuilder>(
                customizations: customizations =>
                {
                    customizations.ExistingServices(services);
                });

            _endpointInstance = Endpoint.Start(endpointConfiguration).GetAwaiter().GetResult();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IApplicationLifetime applicationLifetime, IHostingEnvironment env)
        {
            applicationLifetime.ApplicationStopping.Register(OnShutdown);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        void OnShutdown()
        {
            _endpointInstance?.Stop().GetAwaiter().GetResult();
        }
    }
}
