using AutoMapper;
using SistemaBancario.Entities.Interfaces;
using SistemaBancario.UseCasesPorts.CuentaPorts;

namespace SistemaBancario.UseCases.ConsultarSaldo
{
    public class ConsultarSaldoInteractor : IConsultarSaldoInputPort
    {
        private readonly ICuentaRepository _repository;
        private readonly IConsultarSaldoOutputPort _outputPort;
        public ConsultarSaldoInteractor(ICuentaRepository repository, IConsultarSaldoOutputPort outputPort)
        {
            _repository = repository;
            _outputPort = outputPort;
        }

        public async Task Handle(Guid id)
        {
            var saldo = await _repository.ConsultarSaldo(id);
            await _outputPort.Handle(new DTOs.SaldoDTO() { Saldo= saldo.Item1, FechaSaldo= saldo.Item2 });
        }
    }
}
