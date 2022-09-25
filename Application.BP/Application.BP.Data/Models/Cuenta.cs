using System.ComponentModel.DataAnnotations;

namespace Application.BP.Data.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        [Required]
        public string NumeroCuenta { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int SaldoActual { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int ClienteId { get; set; }
    }
}
