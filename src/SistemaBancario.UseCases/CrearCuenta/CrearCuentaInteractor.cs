using AutoMapper;
using FluentValidation;
using SistemaBancario.DTOs;
using SistemaBancario.Entities.Exceptions;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.UseCases.CancelarCuenta;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.UseCases.CrearCuenta
{
    public class CrearCuentaInteractor : ICrearCuentaInputPort
    {
        private readonly ICuentaRepository _repository;
        private readonly ICrearCuentaOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CrearCuentaInteractor(ICuentaRepository repository, ICrearCuentaOutputPort outputPort, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _outputPort = outputPort;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(CrearCuentaDTO cuenta)
        {
            var validarSiExisteCuenta = new CrearCuentaValidator().Validate(cuenta);
            if (!validarSiExisteCuenta.IsValid) throw new ValidationException(validarSiExisteCuenta.Errors);
            Cuenta newCuenta = _mapper.Map<Cuenta>(cuenta);
            newCuenta.NumeroCuenta = new Random().Next(0, 10000).ToString();
            newCuenta.NumeroCuenta = newCuenta.NumeroCuenta.PadLeft(10, '0');
            await _repository.CrearCuenta(newCuenta);
            try
            {
                await _unitOfWork.GuardarCambios();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al guardar", ex.Message);
            }
            await _outputPort.Handle(_mapper.Map<CuentaDTO>(newCuenta));
        }
    }
}
