using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SistemaBancario.Repository.DataContext
{
    public class SistemaBancarioDbContextFactory : IDesignTimeDbContextFactory<SistemaBancarioDbContext>
    {
        public SistemaBancarioDbContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<SistemaBancarioDbContext>();
            OptionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SistemaBancario;TrustServerCertificate=True;User Id=prueba;Password=prueba;");
            return new SistemaBancarioDbContext(OptionsBuilder.Options);
        }
    }
}
