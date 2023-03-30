using SistemaBancario.DTOs;

namespace SistemaBancario.UseCasesPorts.TransaccionPorts
{
    public interface ICrearTransaccionInputPort
    {
        Task Handle(CrearTransaccionDTO crearTransaccion);
    }
}
