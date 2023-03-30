using SistemaBancario.Entities.Enums;

namespace SistemaBancario.Entities.POCOs
{
    public class Transaccion : Entity
    {
        public TipoTransaccion TipoTransaccion { get; set; }
        public Cuenta Cuenta { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public decimal Valor { get; set; }
    }
}
