using AutoMapper;
using SistemaBancario.DTOs;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.UseCases.ConsultaCuenta
{
    public class ConsultaCuentaInteractor : IConsultarCuentaInputPort
    {
        private readonly ICuentaRepository _repository;
        private readonly IConsultarCuentaOutputPort _outputPort;
        private readonly IMapper _mapper;
        public ConsultaCuentaInteractor(ICuentaRepository repository, IMapper mapper, IConsultarCuentaOutputPort outputPort) =>
            (_repository, _mapper, _outputPort) = (repository, mapper, outputPort);
        public async Task Handle(ConsultaCuentaDTO consultaCuenta)
        {
            var cuentaDto = _mapper.Map<CuentaDTO>(await _repository.ConsultarCuenta(_mapper.Map<Cuenta>(consultaCuenta)));
            await _outputPort.Handle(cuentaDto);
        }
    }
}
