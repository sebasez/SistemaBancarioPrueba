using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.Repository.DataContext;

namespace SistemaBancario.Repository.Repositories
{
    public class CuentaRepository : ICuentaRepository
    {
        private readonly SistemaBancarioDbContext _context;
        public CuentaRepository(SistemaBancarioDbContext context)=> 
            _context = context;
        public async Task CancelarCuenta(Guid id)
        {
            var cuenta = await _context.Cuenta.FindAsync(id);
            cuenta.EstadoCuenta = false;
        }

        public async Task CrearCuenta(Cuenta cuenta)
        {
           await _context.AddAsync(cuenta);
        }

        public async Task<(decimal, DateTime)> ConsultaSaldo(Guid id)
        {
            var cuenta = await _context.Cuenta.FindAsync(id);
            return (cuenta.Saldo, cuenta.FechaSaldo);
        }

        public async Task<Cuenta> ConsultarCuenta(Cuenta cuenta)
        {
            return await _context.Cuenta.FindAsync(cuenta.NumeroCuenta,cuenta.Documento);
        }

        public async Task<bool> ValidarSiExisteCuenta(Guid id)
        {
            var cuenta = await _context.Cuenta.FindAsync(id);
            return cuenta is not null;
        }
    }
}
