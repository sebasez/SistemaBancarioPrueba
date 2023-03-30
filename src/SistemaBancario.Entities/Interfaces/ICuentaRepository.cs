using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.Entities.Interfaces
{
    public interface ICuentaRepository
    {
        Task<Cuenta> CrearCuenta(Cuenta cuenta);
        Task<Cuenta> ConsultarCuenta(Cuenta cuenta);
        Task<(decimal,DateTime)> ConsultarSaldo(Guid id);
        Task CancelarCuenta(Guid id);
        Task<bool> ValidarSiExisteCuenta(Guid id);
    }
}
