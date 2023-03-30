using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface IConsultarSaldoOutputPort
    {
        Task Handle(SaldoDTO saldo);
    }
}
