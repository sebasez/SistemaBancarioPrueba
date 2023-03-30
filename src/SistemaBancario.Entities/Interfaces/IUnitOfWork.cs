namespace SistemaBancario.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> GuardarCambios();
    }
}
