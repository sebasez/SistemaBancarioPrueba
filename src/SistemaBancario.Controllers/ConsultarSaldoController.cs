using Microsoft.AspNetCore.Mvc;
using SistemaBancario.DTOs;
using SistemaBancario.Presenters;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarSaldoController
    {
        private readonly IConsultarSaldoOutputPort _outputPort;
        private readonly IConsultarSaldoInputPort _inputPort;
        public ConsultarSaldoController(IConsultarSaldoOutputPort outputPort, IConsultarSaldoInputPort inputPort)
        {
            _outputPort = outputPort;
            _inputPort = inputPort;
        }
        [HttpPost]
        public async Task<SaldoDTO> ConsultarSaldo(Guid id)
        {
            await _inputPort.Handle(id);
            return ((IPresenter<SaldoDTO>)_outputPort).Content;
        }
    }
}
