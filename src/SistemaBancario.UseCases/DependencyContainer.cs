using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SistemaBancario.UseCases.Mappings;

namespace SistemaBancario.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
;
            return services;
        }
    }
}
