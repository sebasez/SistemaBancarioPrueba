using Microsoft.AspNetCore.Mvc;
using SistemaBancario.UseCasesPorts.CuentaPorts;
using System.Runtime.InteropServices;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancelarCuentaController
    {
        private readonly ICancelarCuentaInputPort _inputPort;
        private readonly ICancelarCuentaOutputPort _outputPort;
        public CancelarCuentaController(ICancelarCuentaInputPort inputPort, ICancelarCuentaOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }
        [HttpPost]
        public async Task CancelarCuenta(Guid id)
        {
            await _inputPort.Handle(id);
        }
    }
}
