using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "NombreProducto")]
        [Required(ErrorMessage = "El campo Nombre del Producto es obligatorio!")]
        public string NombreProducto { get; set; }

        [Display(Name = "PrecioInicial")]
        [Required(ErrorMessage = "El campo Precio Inicial es obligatorio!")]
        public Double PrecioInicial { get; set; }

        [Display(Name = "PrecioVenta")]
        [Required(ErrorMessage = "El campo Precio Venta es obligatorio!")]
        public Double PrecioVenta { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "El campo Stock es obligatorio!")]
        public int Stock { get; set; }
    }
}
