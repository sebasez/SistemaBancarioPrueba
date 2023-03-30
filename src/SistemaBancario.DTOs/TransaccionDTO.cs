namespace SistemaBancario.DTOs
{
    public class TransaccionDTO : BaseDTO
    {
        public int TipoTransaccion { get; set; }
        public CuentaDTO Cuenta { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public decimal Valor { get; set; }
        public TransferenciaDTO Transferencia { get; set; }
    }
}
