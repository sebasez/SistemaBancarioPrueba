namespace SistemaBancario.UseCasesPorts.CuentaPorts
{
    public interface IConsultarSaldoInputPort
    {
        Task Handle(Guid id);
    }
}
