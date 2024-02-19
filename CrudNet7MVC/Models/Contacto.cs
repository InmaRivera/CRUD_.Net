using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
     
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]

        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]

        public string Celular { get; set; }
        [Required(ErrorMessage = "El Celular es obligatorio")]

        public string Email { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public DateTime FechaCreacion {  get; set; }

    }
}
