using System.ComponentModel.DataAnnotations;

namespace ContactoSemana2.Models
{
    public class ContactMessages
    {
public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electronico valido")]
        [StringLength(75, ErrorMessage = "El correo electronico no puede exceder los 75 caracteres")]

        public string Correo { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(150, ErrorMessage = "El mensaje no puede exceder los 150 caracteres")]

        public string Mensaje { get; set; }
    }
}
