using SistemaBancario.DTOs;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.Presenters.Transaccion
{
    public class CrearTransaccionPresenter : ICrearTransaccionOutputPort, IPresenter<TransaccionDTO>
    {
        public TransaccionDTO Content { get; private set; }

        public Task Handle(TransaccionDTO transaccion)
        {
            Content = transaccion;
            return Task.CompletedTask;
        }
    }
}
