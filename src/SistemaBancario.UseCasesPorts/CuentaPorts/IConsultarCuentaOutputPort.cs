using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface IConsultarCuentaOutputPort
    {
        Task Handle(CuentaDTO cuenta);
    }
}
