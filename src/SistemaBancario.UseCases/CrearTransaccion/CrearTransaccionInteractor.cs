using AutoMapper;
using FluentValidation;
using SistemaBancario.DTOs;
using SistemaBancario.Entities.Exceptions;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.Entities.POCOs;
using SistemaBancario.UseCases.CrearCuenta;
using SistemaBancario.UseCasesPorts.TransaccionPorts;

namespace SistemaBancario.UseCases.CrearTransaccion
{
    public class CrearTransaccionInteractor : ICrearTransaccionInputPort
    {
        private readonly ITransaccionRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICrearTransaccionOutputPort _outputPort;
        private readonly IMapper _mapper;
        public CrearTransaccionInteractor(ITransaccionRepository repository, IUnitOfWork unitOfWork, ICrearTransaccionOutputPort outputPort, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task Handle(CrearTransaccionDTO transaccion)
        {
            var validarTransaccion = new CrearTransaccionValidator().Validate(transaccion);
            if (!validarTransaccion.IsValid) throw new ValidationException(validarTransaccion.Errors);
            Transaccion newTransaccion = _mapper.Map<Transaccion>(transaccion);
            await _repository.CrearTransaccion(newTransaccion);
            try
            {
                await _unitOfWork.GuardarCambios();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al guardar", ex.Message);
            }
            await _outputPort.Handle(_mapper.Map<TransaccionDTO>(newTransaccion));
        }
    }
}
