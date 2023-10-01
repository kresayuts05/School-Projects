using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Services;
using HireProgrammer.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class HireProgrammerServiceCollectionExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProgrammerService, ProgrammerService>();
            services.AddScoped<IFirmService, FirmService>();
            services.AddScoped<IPostService, PostService>();

            return services;
        }
    }
}
