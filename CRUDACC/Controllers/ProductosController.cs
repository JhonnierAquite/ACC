using CRUDACC.Datos;
using CRUDACC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUDACC.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;


        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Producto> ListProductos = _context.Producto;

            return View(ListProductos);
        }

        //Http get create
        public IActionResult Create()
        {

            return View();
        }

        //Http Post create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Producto.Add(producto);
                _context.SaveChanges();

//Arreglar
//                TempData["mensaje"] = "El producto se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            { 
                return NotFound();
            }

            //obtener oferta
            var producto=_context.Producto.Find(id);

            if(producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        //Http Post edit
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Producto.Update(producto);
                _context.SaveChanges();

                //TempData["mensaje"] = "El Producto se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //obtener oferta
            var Producto = _context.Producto.Find(id);

            if (Producto == null)
            {
                return NotFound();
            }
            return View(Producto);
        }

        //Http Post Delete
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteProducto(int? id)
        {
            //obtener la oferta por id
            var producto = _context.Producto.Find(id);

            if (producto == null)
            {
                return NotFound();
            }

           
                _context.Producto.Remove(producto);
                _context.SaveChanges();

                TempData["mensaje"] = "El Producto se ha eliminado correctamente";
                return RedirectToAction("Index");
            
        }
    }
}
