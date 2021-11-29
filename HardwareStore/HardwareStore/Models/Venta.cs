using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "FechaVenta")]
        [Required(ErrorMessage = "El campo Fecha es obligatorio!")]
        [DataType(DataType.Date)]
        public DateTime FechaVenta { get; set; }

        [Display(Name = "TotalVenta")]
        [Required(ErrorMessage = "El campo Total Venta es obligatorio!")]
        public Double TotalVenta { get; set; }

        [Display(Name = "IdCliente")]
        public Usuario usuario { get; set; }

        public int usuarioId { get; set; }

        public List<DetalleVenta> detallesVenta { get; set; }
    }
}
