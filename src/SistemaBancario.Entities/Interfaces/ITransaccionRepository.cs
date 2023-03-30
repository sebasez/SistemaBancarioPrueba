using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.Entities.Interfaces
{
    public interface ITransaccionRepository
    {
        Task CrearTransaccion(Transaccion transaccion);
        Task<IEnumerable<Transaccion>> ConsultaMovimientos(Guid id, DateTime fechaInicio, DateTime fechaFin);
    }
}
