namespace SistemaBancario.DTOs
{
    public class CrearCuentaDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaSaldo { get; set; }
        public int TipoCuenta { get; set; }
    }
}
