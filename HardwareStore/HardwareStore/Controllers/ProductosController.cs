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
                IEnumerable<Producto> listaProductos = _context.producto;
                return View(listaProductos);
            }
            else {
                return RedirectToAction("ErrorUsuario", "Usuarios");
            }
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


        [HttpPost]
        public IActionResult AgregarProducto(Producto pr)
        {

            if(ModelState.IsValid)
            {
                _context.producto.Add(pr);
                _context.SaveChanges();

                TempData["Mensaje"] = "Producto agregado";
                return RedirectToAction( "IndexAdmin","Productos");

            }

            return View(); 
        }





        //Método GET para EditarProducto(Retorna la View con el Form para Editar)
        public IActionResult EditarProducto(int? ID)
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

                    if (ID == null || ID == 0)
                    {
                        return NotFound();
                    }

                    //obtener id de los productos

                    var pro = _context.producto.Find(ID);

                    if (pro == null)
                    {
                        return NotFound();
                    }
                    return View(pro);

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


        //Método POST para EditarProducto Interactua con la base 
        [HttpPost]
        public IActionResult EditarProducto(Producto p)
         {

            if (ModelState.IsValid)
            {
                _context.producto.Update(p);
                _context.SaveChanges();

                TempData["Mensaje"] = "Producto actualizado";
                return RedirectToAction("IndexAdmin", "Productos");

            }

            return RedirectToAction("IndexAdmin", "Productos");
        }

        //Método GET Elimarproducto
        public IActionResult EliminarProducto(int? ID)
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

                    if (ID == null || ID == 0)
                    {
                        return NotFound();
                    }

                    //obtener id de los productos

                    var pro = _context.producto.Find(ID);

                    if (pro == null)
                    {
                        return NotFound();
                    }
                    return View(pro);

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


        //Metodo POST ELimarProducto 

        [HttpPost]
        public IActionResult EliminarProductos(int? ID)
        {
            //Obtener el Producto por el id para eliminar

            var p = _context.producto.Find(ID);

            if(p==null)
            {
                return NotFound();
            }


            
                _context.producto.Remove(p);
                _context.SaveChanges();

                return RedirectToAction("IndexAdmin", "Productos");

            

            


        }




    }
}
