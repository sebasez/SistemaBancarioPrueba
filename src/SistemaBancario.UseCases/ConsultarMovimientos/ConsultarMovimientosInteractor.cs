using AutoMapper;
using SistemaBancario.DTOs;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.UseCases.ConsultarMovimientos
{
    public class ConsultarMovimientosInteractor : IConsultarMovimientosInputPort
    {
        private readonly ITransaccionRepository _repository;
        private readonly IConsultarMovimientosOutputPort _outputPort;
        private readonly IMapper _mapper;
        public ConsultarMovimientosInteractor(ITransaccionRepository repository, IConsultarMovimientosOutputPort outputPort, IMapper mapper) =>
            (_repository, _outputPort, _mapper) = (repository, outputPort, mapper);

        public async Task Handle(ConsultaMovimientosDTO consultaMovimientos)
        {
            var movimientos = _mapper.Map<IEnumerable<TransaccionDTO>>(await _repository.ConsultaMovimientos(consultaMovimientos.Id, consultaMovimientos.FechaInicio, consultaMovimientos.FechaFin));
            await _outputPort.Handle(movimientos);
        }
    }
}
