using LAMS.Application.Interface;
using LAMS.Infrastructure.ServiceImplementation;
using Microsoft.CodeAnalysis;

namespace LAMS.WEB.Utility
{
    public static class ServiceInjection
    {
        public static void InjectService(this IServiceCollection services)
        {

            services.AddScoped<IMenu, MenuServices>();
        }
    }
}
