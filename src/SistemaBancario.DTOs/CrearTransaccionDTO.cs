namespace SistemaBancario.DTOs
{
    public class CrearTransaccionDTO
    {
        public int TipoTransaccion { get; set; }
        public CuentaDTO Cuenta { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public decimal Valor { get; set; }
    }
}
