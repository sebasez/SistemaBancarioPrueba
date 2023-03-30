using Microsoft.AspNetCore.Mvc;
using SistemaBancario.DTOs;
using SistemaBancario.Presenters;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrearCuentaController
    {
        private readonly ICrearCuentaOutputPort _outputPort;
        private readonly ICrearCuentaInputPort _inputPort;
        public CrearCuentaController(ICrearCuentaOutputPort outputPort, ICrearCuentaInputPort inputPort)=>
            _outputPort = outputPort;
        [HttpPost]
        public async Task<CuentaDTO> CrearCuenta(CrearCuentaDTO cuenta)
        {
            await _inputPort.Handle(cuenta);
            return ((IPresenter<CuentaDTO>)_outputPort).Content;
        }
    }
}
