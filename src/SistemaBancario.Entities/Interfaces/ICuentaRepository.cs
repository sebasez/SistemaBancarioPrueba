using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.Entities.Interfaces
{
    public interface ICuentaRepository
    {
        Task CrearCuenta(Cuenta cuenta);
        Task<Cuenta> ConsultarCuenta(Cuenta cuenta);
        Task<(decimal,DateTime)> ConsultaSaldo(Guid id);
        Task CancelarCuenta(Guid id);
        Task<bool> ValidarSiExisteCuenta(Guid id);
    }
}
