using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface ICrearCuentaOutputPort
    {
        Task Handle(CuentaDTO cuenta);
    }
}
