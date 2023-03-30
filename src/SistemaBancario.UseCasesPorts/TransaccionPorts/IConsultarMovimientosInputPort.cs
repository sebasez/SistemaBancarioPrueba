using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface IConsultarMovimientosInputPort
    {
        Task Handle(ConsultaMovimientosDTO consultaMovimientos);
    }
}
