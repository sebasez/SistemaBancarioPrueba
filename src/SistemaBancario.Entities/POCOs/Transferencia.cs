namespace SistemaBancario.Entities.POCOs
{
    public class Transferencia : Entity
    {
        public string NumeroDeCuenta { get; set; }
        public string NombreBanco { get; set;}
        public Transaccion Transaccion { get; set; }
    }
}
