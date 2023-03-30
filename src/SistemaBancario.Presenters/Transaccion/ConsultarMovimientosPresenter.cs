using SistemaBancario.DTOs;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.Presenters.Transaccion
{
    internal class ConsultarMovimientosPresenter : IConsultarMovimientosOutputPort, IPresenter<IEnumerable<TransaccionDTO>>
    {
        public IEnumerable<TransaccionDTO> Content { get; private set; }

        public Task Handle(IEnumerable<TransaccionDTO> transacciones)
        {
            Content= transacciones;
            return Task.CompletedTask;
        }
    }
}
