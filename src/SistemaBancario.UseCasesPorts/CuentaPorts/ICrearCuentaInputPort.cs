using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface ICrearCuentaInputPort
    {
        Task Handle(CrearCuentaDTO cuenta);
    }
}
