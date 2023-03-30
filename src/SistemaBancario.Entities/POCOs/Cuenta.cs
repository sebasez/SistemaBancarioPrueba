using SistemaBancario.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Entities.POCOs
{
    public class Cuenta : Entity
    {
        [Key]
        [Column(Order = 1)]
        public int NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaSaldo { get; set; }
        public DateTime FechaApertura { get; set; }
        public virtual TipoCuenta TipoCuenta { get; set; }
        public virtual ICollection<Transaccion> Transacciones { get; set; }
        public bool EstadoCuenta { get; set; } = true;
    }
}
