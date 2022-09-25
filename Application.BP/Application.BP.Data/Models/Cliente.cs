using System.ComponentModel.DataAnnotations;

namespace Application.BP.Data.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
