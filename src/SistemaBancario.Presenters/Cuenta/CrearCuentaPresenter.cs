using SistemaBancario.DTOs;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Presenters.Cuenta
{
    internal class CrearCuentaPresenter : ICrearCuentaOutputPort, IPresenter<CuentaDTO>
    {
        public CuentaDTO Content { get; private set; }

        public Task Handle(CuentaDTO cuenta)
        {
            Content = cuenta;
            return Task.CompletedTask;
        }
    }
}
