using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.Repository.DataContext;

namespace SistemaBancario.Repository.Repositories
{
    public class TransferenciaRepository : ITransferenciaRepository
    {
        private readonly SistemaBancarioDbContext _context;
        public TransferenciaRepository(SistemaBancarioDbContext context) =>
            _context = context;
        public async Task CrearTransferecia(Transferencia transferencia)
        {
            await _context.Transferencia.AddAsync(transferencia);
        }

        public async Task<Transferencia> ObtenerTransferencia(Guid id)
        {
            return await _context.Transferencia.FindAsync(id);
        }
    }
}
