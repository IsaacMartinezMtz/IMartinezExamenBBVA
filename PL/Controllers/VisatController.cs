using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class VisatController : Controller
    {
        // GET: Visat
        public ActionResult Maquina()
        {
            ML.Producto producto = new ML.Producto();
            ML.Result result = BL.Productos.GetAll();
            producto.Productos = result.Objects;
            return View(producto);
        }
        
    }
}