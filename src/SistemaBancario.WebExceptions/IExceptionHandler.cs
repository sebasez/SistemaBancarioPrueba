using Microsoft.AspNetCore.Mvc.Filters;

namespace SistemaBancario.WebExceptions
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);
    }
}
