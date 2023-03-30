using Microsoft.Extensions.DependencyInjection;
using SistemaBancario.Presenters.Cuenta;
using SistemaBancario.Presenters.Transaccion;
using SistemaBancario.UseCasesPorts.CuentaPorts;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICancelarCuentaOutputPort, CancelarCuentaPresenter>();
            services.AddScoped<IConsultarCuentaOutputPort, ConsultarCuentaPresentar>();
            services.AddScoped<IConsultarSaldoOutputPort, ConsultarSaldoPresenter>();
            services.AddScoped<ICrearCuentaOutputPort, CrearCuentaPresenter>();
            services.AddScoped<IConsultarMovimientosOutputPort, ConsultarMovimientosPresenter>();
            services.AddScoped<ICrearTransaccionOutputPort, CrearTransaccionPresenter>();
            return services;
        }
    }
}
