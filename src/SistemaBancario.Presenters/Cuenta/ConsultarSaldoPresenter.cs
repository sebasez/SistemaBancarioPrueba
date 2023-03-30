using SistemaBancario.DTOs;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Presenters.Cuenta
{
    public class ConsultarSaldoPresenter : IConsultarSaldoOutputPort, IPresenter<SaldoDTO>
    {
        public SaldoDTO Content { get; private set; }

        public Task Handle(SaldoDTO saldo)
        {
            Content = saldo;
            return Task.CompletedTask;
        }
    }
}
