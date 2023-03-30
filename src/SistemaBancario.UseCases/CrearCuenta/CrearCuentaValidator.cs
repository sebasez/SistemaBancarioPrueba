using FluentValidation;
using SistemaBancario.DTOs;

namespace SistemaBancario.UseCases.CrearCuenta
{
    public class CrearCuentaValidator : AbstractValidator<CrearCuentaDTO>
    {
        public CrearCuentaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearCuentaDTO.Nombre)}")
                .NotEmpty().WithMessage($"El campo '{nameof(CrearCuentaDTO.Nombre)}' nombre no puede estar vacío");
            RuleFor(x => x.Apellido)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearCuentaDTO.Apellido)}")
                .NotEmpty().WithMessage($"El campo '{nameof(CrearCuentaDTO.Apellido)}' nombre no puede estar vacío");
            RuleFor(x => x.Direccion)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearCuentaDTO.Direccion)}")
                .NotEmpty().WithMessage($"El campo '{nameof(CrearCuentaDTO.Direccion)}' nombre no puede estar vacío");
            RuleFor(x => x.Telefono)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearCuentaDTO.Telefono)}")
                .NotEmpty().WithMessage($"El campo '{nameof(CrearCuentaDTO.Telefono)}' nombre no puede estar vacío");
            RuleFor(x => x.TipoCuenta)
                .NotNull().WithMessage($"Se requiere el {nameof(CrearCuentaDTO.TipoCuenta)}")
                .NotEmpty().WithMessage($"El campo '{nameof(CrearCuentaDTO.TipoCuenta)}' nombre no puede estar vacío");
        }

    }
}
