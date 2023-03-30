using Microsoft.AspNetCore.Mvc;
using SistemaBancario.DTOs;
using SistemaBancario.Presenters;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrearTransaccionController
    {
        private readonly ICrearTransaccionOutputPort _outputPort;
        private readonly ICrearTransaccionInputPort _inputPort;
        public CrearTransaccionController(ICrearTransaccionOutputPort outputPort, ICrearTransaccionInputPort inputPort)
        {
            _outputPort = outputPort;
            _inputPort = inputPort;
        }
        [HttpPost]
        public async Task<TransaccionDTO> CrearTransaccion(CrearTransaccionDTO transaccion)
        {
            await _inputPort.Handle(transaccion);
            return ((IPresenter<TransaccionDTO>)_outputPort).Content;
        }
    }
}
