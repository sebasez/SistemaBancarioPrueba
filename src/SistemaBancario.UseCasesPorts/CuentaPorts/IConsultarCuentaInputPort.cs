using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface IConsultarCuentaInputPort
    {
        Task Handle(ConsultaCuentaDTO consultaCuenta);
    }
}
