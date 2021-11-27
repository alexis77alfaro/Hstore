using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareStore.Controllers;
using HardwareStore.Data;
using HardwareStore.Models;

namespace HardwareStore.Controllers
{
    public class ProductosController : Controller
    {
        private static Usuario SesionUsuario;
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult IndexUsuario()
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
            else {
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }
            return View();
        }

    }
}
