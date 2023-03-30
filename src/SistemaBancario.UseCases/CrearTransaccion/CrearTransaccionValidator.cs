using FluentValidation;
using SistemaBancario.DTOs;

namespace SistemaBancario.UseCases.CrearTransaccion
{
    public class CrearTransaccionValidator : AbstractValidator<CrearTransaccionDTO>
    {
        public CrearTransaccionValidator()
        {
            RuleFor(x => x.TipoTransaccion)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearTransaccionDTO.TipoTransaccion)}")
                .GreaterThan(0).WithMessage($"El campo '{nameof(CrearTransaccionDTO.TipoTransaccion)}' nombre no puede estar vacío");
            RuleFor(x => x.Valor)
              .NotNull().WithMessage($"Se requiere el {nameof(CrearTransaccionDTO.Valor)}")
              .GreaterThan(0).WithMessage($"El campo '{nameof(CrearTransaccionDTO.Valor)}' nombre no puede estar vacío");
            RuleFor(x => x.Cuenta.Id)
              .NotNull().WithMessage($"Se requiere la cuenta")
              .NotEmpty().WithMessage($"El campo 'Cuenta' nombre no puede estar vacío");
        }
    }
}
