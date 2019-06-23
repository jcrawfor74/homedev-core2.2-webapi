using HomeDev.Core.WebApi.Configuration;
using HomeDev.Core.WebApi.Interfaces;
using HomeDev.Core.WebApi.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HomeDev.Core.WebApi
{
    public static class DependencyRegistrar
    {
        public static void RegisterComponents(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, TokenAuthenticationService>();
            services.AddScoped<IUserManagementService, UserManagementService>();
            // swagger setup
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SetupSwaggerOptions>();
        }
    }
}