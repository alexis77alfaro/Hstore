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

        //Método GET para Mostrar View los Productos al usuario(No se si lo ocuparemos xd)
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

        //Método GET para Mostrar View del Crud de Productos(Ya carga la lista de productos)
        public IActionResult IndexAdmin()
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
                catch { }

                if (SesionUsuario.Rol == 0)
                {
                    //Codigo que ejecuta este metodo aquí
                    IEnumerable<Producto> listaProductos = _context.producto;
                    return View(listaProductos);
                }
                else
                {
                    return RedirectToAction("ErrorSoloAdmin", "Usuarios");
                }
            }
            else
            {
                SesionUsuario = new Usuario();
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }
        }

        //Método GET para AgregarProducto(Retorna la View con el Form para Agregar)
        public IActionResult AgregarProducto()
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
                catch { }

                if (SesionUsuario.Rol == 0)
                {
                    //Codigo que ejecuta este metodo aquí
                    return View();
                }
                else
                {
                    return RedirectToAction("ErrorSoloAdmin", "Usuarios");
                }
            }
            else
            {
                SesionUsuario = new Usuario();
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }
        }

        //Método GET para EditarProducto(Retorna la View con el Form para Editar)
        public IActionResult EditarProducto()
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
                catch { }

                if (SesionUsuario.Rol == 0)
                {
                    //Codigo que ejecuta este metodo aquí
                    return View();
                }
                else
                {
                    return RedirectToAction("ErrorSoloAdmin");
                }
            }
            else
            {
                SesionUsuario = new Usuario();
                return RedirectToAction("ErrorUsuario");
            }
        }

    }
}
