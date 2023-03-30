using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface ICrearTransaccionOutputPort
    {
        Task Handle(TransaccionDTO transaccion);
    }
}
