using Microsoft.EntityFrameworkCore;
using SistemaBancario.Entities.Enums;
using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.Repository.DataContext
{
    public class SistemaBancarioDbContext : DbContext
    {
        public SistemaBancarioDbContext(DbContextOptions<SistemaBancarioDbContext> options)
            : base(options)
        {

        }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Cuenta>()
                .Property(x => x.TipoCuenta)
                .HasConversion<int>();
            modelBuilder
                .Entity<Cuenta>()
                .HasKey(x => new { x.Id, x.Documento, x.NumeroCuenta });
            modelBuilder
                .Entity<Transaccion>()
                .Property(x => x.TipoTransaccion)
                .HasConversion<int>();
        }
    }
}
