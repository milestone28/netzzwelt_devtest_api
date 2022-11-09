using Microsoft.Extensions.DependencyInjection;
using netzzwelt_devtest_api.Application.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
