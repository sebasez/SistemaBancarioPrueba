using Microsoft.AspNetCore.Mvc;
using SistemaBancario.DTOs;
using SistemaBancario.Presenters;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarMovimientosController
    {
        public readonly IConsultarMovimientosOutputPort _outputPort;
        public readonly IConsultarMovimientosInputPort _inputPort;
        public ConsultarMovimientosController(IConsultarMovimientosOutputPort outputPort, IConsultarMovimientosInputPort inputPort)
        {
            _outputPort = outputPort;
            _inputPort = inputPort;
        }
        [HttpPost]
        public async Task<IEnumerable<TransaccionDTO>> ConsultarMovimientos(ConsultaMovimientosDTO movimientos)
        {
            await _inputPort.Handle(movimientos);
            return ((IPresenter<IEnumerable<TransaccionDTO>>)_outputPort).Content;
        }
    }
}
