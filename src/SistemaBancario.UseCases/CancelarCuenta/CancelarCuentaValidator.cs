using FluentValidation;
using SistemaBancario.Entities.Interfaces;

namespace SistemaBancario.UseCases.CancelarCuenta
{
    public class CancelarCuentaValidator : AbstractValidator<Guid>
    {
        private readonly ICuentaRepository _repository;
        public CancelarCuentaValidator(ICuentaRepository repository)
        {
            _repository= repository;
            RuleFor(x => x).Must(IsPropertyExist).WithMessage("¡Cuenta no existe!");
        }
        private bool IsPropertyExist(Guid id)
        {
            var siExiste = _repository.ValidarSiExisteCuenta(id).GetAwaiter().GetResult();
            return siExiste;
        }
    }
}
