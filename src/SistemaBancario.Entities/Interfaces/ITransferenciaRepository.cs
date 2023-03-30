using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.Entities.Interfaces
{
    public interface ITransferenciaRepository
    {
        Task CrearTransferecia(Transferencia transferencia);
        Task<Transferencia> ObtenerTransferencia(Guid id);
    }
}
