using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Presenters.Cuenta
{
    public class CancelarCuentaPresenter : ICancelarCuentaOutputPort
    {
        public Task Handle()
        {
            return Task.CompletedTask;
        }
    }
}
