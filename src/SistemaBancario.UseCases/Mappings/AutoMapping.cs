using AutoMapper;
using SistemaBancario.DTOs;
using SistemaBancario.Entities.POCOs;

namespace SistemaBancario.UseCases.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping() {
            CreateMap<CrearCuentaDTO, Cuenta>().ReverseMap();
            CreateMap<ConsultaCuentaDTO,Cuenta>().ReverseMap();
            CreateMap<TransaccionDTO,Transaccion>().ReverseMap();
            CreateMap<CuentaDTO, Cuenta>().ReverseMap();
            CreateMap<CrearTransaccionDTO, Transaccion>().ReverseMap();
        }
    }
}
