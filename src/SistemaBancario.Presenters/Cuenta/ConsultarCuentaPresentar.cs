using SistemaBancario.DTOs;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Presenters.Cuenta
{
    public class ConsultarCuentaPresentar : IConsultarCuentaOutputPort, IPresenter<CuentaDTO>
    {
        public CuentaDTO Content { get; private set; }

        public Task Handle(CuentaDTO cuenta)
        {
            Content = cuenta;
            return Task.CompletedTask;
        }
    }
}
