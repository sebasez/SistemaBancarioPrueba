using AutoMapper;
using FluentValidation;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.UseCases.CancelarCuenta
{
    public class CancelarCuentaInteractor : ICancelarCuentaInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICuentaRepository _repository;
        private readonly ICancelarCuentaOutputPort _outputPort;
        public CancelarCuentaInteractor(IUnitOfWork unitOfWork,
            ICuentaRepository repository,
            IMapper mapper,
            ICancelarCuentaOutputPort outputPort) =>
        (_unitOfWork, _repository, _outputPort) = (unitOfWork, repository, outputPort);

        public async Task Handle(Guid id)
        {
            var validarSiExisteCuenta = new CancelarCuentaValidator(_repository).Validate(id);
            if (!validarSiExisteCuenta.IsValid) throw new ValidationException(validarSiExisteCuenta.Errors);
            await _repository.CancelarCuenta(id);
            await _unitOfWork.GuardarCambios();
            await _outputPort.Handle();
        }
    }
}
