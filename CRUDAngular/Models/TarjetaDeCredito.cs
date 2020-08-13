using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAngular.Models
{
    public class TarjetaDeCredito
    {
        [Key, Column("TarjetaDeCreditoId")]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Titular { get; set; }

        [Required, Column(TypeName = "varchar(16)")]
        public string NumeroDeTarjeta { get; set; }

        [Required, Column(TypeName = "varchar(5)")]
        public string FechaExpiracion { get; set; }

        [Required, Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
