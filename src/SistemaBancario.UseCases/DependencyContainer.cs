using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SistemaBancario.UseCases.CancelarCuenta;
using SistemaBancario.UseCases.ConsultaCuenta;
using SistemaBancario.UseCases.ConsultarMovimientos;
using SistemaBancario.UseCases.ConsultarSaldo;
using SistemaBancario.UseCases.CrearCuenta;
using SistemaBancario.UseCases.CrearTransaccion;
using SistemaBancario.UseCases.Mappings;
using SistemaBancario.UseCasesPorts.CuentaPorts;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

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
            services.AddTransient<ICancelarCuentaInputPort, CancelarCuentaInteractor>();
            services.AddTransient<IConsultarCuentaInputPort, ConsultarCuentaInteractor>();
            services.AddTransient<IConsultarSaldoInputPort, ConsultarSaldoInteractor>();
            services.AddTransient<ICrearCuentaInputPort, CrearCuentaInteractor>();
            services.AddTransient<IConsultarMovimientosInputPort, ConsultarMovimientosInteractor>();
            services.AddTransient<ICrearTransaccionInputPort, CrearTransaccionInteractor>();
            return services;
        }
    }
}
