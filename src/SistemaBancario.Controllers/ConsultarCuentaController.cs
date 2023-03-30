using Microsoft.AspNetCore.Mvc;
using SistemaBancario.DTOs;
using SistemaBancario.Presenters;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarCuentaController
    {
        private readonly IConsultarCuentaOutputPort _outputPort;
        private readonly IConsultarCuentaInputPort _inputPort;
        public ConsultarCuentaController(IConsultarCuentaOutputPort outputPort, IConsultarCuentaInputPort inputPort)
        {
            _outputPort = outputPort;
            _inputPort = inputPort;
        }
        [HttpPost]
        public async Task<CuentaDTO> ConsultarCuenta(ConsultaCuentaDTO cuenta)
        {
            await _inputPort.Handle(cuenta);
            return ((IPresenter<CuentaDTO>)_outputPort).Content;
        }
    }
}
