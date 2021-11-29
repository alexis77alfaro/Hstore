using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class DetalleVenta
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "UnidadesVendidas")]
        [Required(ErrorMessage = "El campo Unidades Vendidas es obligatorio!")]
        public int UnidadesVendidas { get; set; }

        [Display(Name = "SubTotal")]
        [Required(ErrorMessage = "El campo SubTotal es obligatorio!")]
        public Double SubTotal { get; set; }

        [Display(Name = "TotalVenta")]
        [Required(ErrorMessage = "El campo Total Venta es obligatorio!")]
        public Double TotalVenta { get; set; }

        [Display(Name = "IdProducto")]
        public Producto producto { get; set; }

        [Display(Name = "IdVenta")]
        public Venta venta { get; set; }

        public int ProductoId { get; set; }

        public int VentaId { get; set; }
    }
}
