using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.User
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo {0} no es una dirección de e-mail válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Password { get; set; }
    }
}