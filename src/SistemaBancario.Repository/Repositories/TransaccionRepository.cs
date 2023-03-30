using Microsoft.EntityFrameworkCore;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.Repository.DataContext;

namespace SistemaBancario.Repository.Repositories
{
    public class TransaccionRepository : ITransaccionRepository
    {
        private readonly SistemaBancarioDbContext _context;

        public TransaccionRepository(SistemaBancarioDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transaccion>> ConsultaMovimientos(Guid id, DateTime fechaInicio, DateTime fechaFin)
        {
            return await _context.Transaccion.Where(it => it.Cuenta.Id == id && it.FechaTransaccion >= fechaInicio && it.FechaTransaccion <= fechaFin).ToListAsync();
        }

        public async Task CrearTransaccion(Transaccion transaccion)
        {
            await _context.AddAsync(transaccion);
        }
    }
}
