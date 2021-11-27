using HardwareStore.Models;
using HardwareStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static Usuario SesionUsuario;

        public UsuariosController(ApplicationDbContext context)
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
                    ViewBag.Rol = SesionUsuario.Rol;
                }
                catch
                {

                }
            }
            else
            {
                SesionUsuario = new Usuario();
            }
            return View();
        }

        //Http Get LoginUsuario
        public IActionResult LoginUsuario()
        {
            return View();
        }

        //Http Post LoginUsuario
        [HttpPost]
        public ActionResult DoLoginUsuario(Usuario user)
        {
            Usuario usuario = _context.usuario.Where(s => s.Correo == user.Correo && s.Password == user.Password).FirstOrDefault();

            if (usuario != null)
            {
                HttpContext.Session.SetString("IdUsuario", usuario.Id.ToString());
                return RedirectToAction("Index", "Usuarios");
            }

            return RedirectToAction("Error", "Home");
        }

        //Http Post LoginUsuario
        public ActionResult AgregarUsuario()
        {

            return View();
        }

        //Http Post LoginUsuario
        [HttpPost]
        public ActionResult DoAgregarUsuario(Usuario user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
            }

            return View();
        }
    }
}
