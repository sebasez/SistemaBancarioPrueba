namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface ICancelarCuentaInputPort
    {
        Task Handle(Guid id);
    }
}
