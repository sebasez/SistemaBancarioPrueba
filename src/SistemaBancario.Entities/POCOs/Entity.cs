using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBancario.Entities.POCOs
{
    public class Entity
    {
        [Column(Order = 0)]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
