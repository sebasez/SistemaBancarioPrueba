using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface IConsultaMovimientosInputPort
    {
        Task Handle(ConsultaMovimientosDTO consultaMovimientos);
    }
}
