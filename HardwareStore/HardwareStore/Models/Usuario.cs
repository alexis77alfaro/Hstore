using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es obligatorio!")]
        public string Nombre { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo correo es obligatorio!")]
        [EmailAddress(ErrorMessage = "El correo ingresado no es válido!")]
        public string Correo { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo contraseña es obligatorio!")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser almenos de {2}", MinimumLength = 6)]
        public string Password { get; set; }

        public int Rol { get; set; } // 0 = admin; 1 = cliente
    }
}
