using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface IConsultarMovimientosOutputPort
    {
        Task Handle(IEnumerable<TransaccionDTO> transacciones);
    }
}
