using Microsoft.Extensions.DependencyInjection;
using SistemaBancario.Presenters;
using SistemaBancario.Repository;
using SistemaBancario.UseCases;

namespace SistemaBancario.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRealEstateWeeloDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}