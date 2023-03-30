using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Repository.DataContext;

namespace SistemaBancario.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SistemaBancarioDbContext _context;
        public UnitOfWork(SistemaBancarioDbContext context)=>
            _context = context;
        public async Task<int> GuardarCambios()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
