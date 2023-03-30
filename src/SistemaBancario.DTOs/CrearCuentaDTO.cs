using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.DTOs
{
    public class CrearCuentaDTO
    {
        public string NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaSaldo { get; set; }
        public int TipoCuenta { get; set; }
    }
}
