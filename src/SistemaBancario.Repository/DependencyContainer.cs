using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Repository.DataContext;
using SistemaBancario.Repository.Repositories;

namespace SistemaBancario.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SistemaBancarioDbContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<ICuentaRepository, CuentaRepository>();
            services.AddScoped<ITransaccionRepository, TransaccionRepository>();
            services.AddScoped<ITransferenciaRepository, TransferenciaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
