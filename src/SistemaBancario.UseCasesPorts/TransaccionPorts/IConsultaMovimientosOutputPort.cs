using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface IConsultaMovimientosOutputPort
    {
        Task Handle(IEnumerable<TransaccionDTO> transacciones);
    }
}
