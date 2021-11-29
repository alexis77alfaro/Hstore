using HardwareStore.Data;
using HardwareStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Controllers
{
    public class VentasController : Controller
    {
        private static Usuario SesionUsuario;
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HacerVenta()
        {
            if (HttpContext.Session.GetString("IdUsuario") != null)
            {
                string id = HttpContext.Session.GetString("IdUsuario");

                SesionUsuario = new Usuario();
                SesionUsuario.Id = int.Parse(id);
                SesionUsuario = _context.usuario.Where(s => s.Id == SesionUsuario.Id).FirstOrDefault();

                try
                {
                    ViewBag.Id = SesionUsuario.Id;
                    ViewBag.Nombre = SesionUsuario.Nombre;
                    ViewBag.Correo = SesionUsuario.Correo;
                    ViewBag.Rol = SesionUsuario.Rol;
                }
                catch
                {

                }
            }
            else
            {
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }

            IEnumerable<Producto> listaProductos = _context.producto;
            ViewBag.ListaProductos = listaProductos;
            ViewBag.Usuario = SesionUsuario;
            return View();
        }

        [HttpPost]
        public IActionResult Vender(Venta venta)
        {
            venta.usuarioId = SesionUsuario.Id;
            //Nueva Venta
            _context.Add(venta);
            _context.SaveChanges();

            int lastId = venta.Id;
            if (venta.detallesVenta.Count() > 0)
            {
                for (int i = 0; i < venta.detallesVenta.Count(); i++)
                {
                    Producto producto = new Producto();
                    producto.Id = venta.detallesVenta[i].ProductoId;
                    producto = _context.producto.Where(p => p.Id == producto.Id).FirstOrDefault();

                    producto.Stock = (producto.Stock - venta.detallesVenta[i].UnidadesVendidas);
                    _context.producto.Update(producto);
                    _context.SaveChanges();
                }
            }
            else {
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }

            TempData["compraCompleta"] = "La compra se completó con éxito";

            return RedirectToAction("HacerVenta");
        }
    }
}
