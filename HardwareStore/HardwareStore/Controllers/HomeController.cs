using HardwareStore.Data;
using HardwareStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static Usuario SesionUsuario;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
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
                    ViewBag.Password = SesionUsuario.Password;
                    ViewBag.Rol = SesionUsuario.Rol;
                }
                catch
                {

                }
            }

            return View();
        }
    }
}
