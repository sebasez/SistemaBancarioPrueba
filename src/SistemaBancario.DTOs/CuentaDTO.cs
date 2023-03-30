namespace SistemaBancario.DTOs
{
    public class CuentaDTO : BaseDTO
    {
        public string NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaSaldo { get; set; }
        public DateTime FechaApertura { get; set; }
        public int TipoCuenta { get; set; }
        public ICollection<TransaccionDTO> Transacciones { get; set; }
        public bool EstadoCuenta { get; set; }
    }
}
