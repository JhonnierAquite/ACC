using CRUDACC.Datos;
using CRUDACC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUDACC.Controllers
{
    public class OfertasController : Controller
    {
        private readonly ApplicationDbContext _context;

      
        public OfertasController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Oferta> ListOfertas = _context.Oferta;

            return View(ListOfertas);
        }

        //Http get create
        public IActionResult Create()
        {

            return View();
        }

        //Http Post create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                _context.Oferta.Add(oferta);
                _context.SaveChanges();

//Arreglar
//                TempData["mensaje"] = "La oferta se ha creado correctamente";
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
            var oferta=_context.Oferta.Find(id);

            if(oferta == null)
            {
                return NotFound();
            }
            return View(oferta);
        }

        //Http Post edit
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                _context.Oferta.Update(oferta);
                _context.SaveChanges();

                //TempData["mensaje"] = "La oferta se ha actualizado correctamente";
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
            var oferta = _context.Oferta.Find(id);

            if (oferta == null)
            {
                return NotFound();
            }
            return View(oferta);
        }

        //Http Post Delete
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteOferta(int? id)
        {
            //obtener la oferta por id
            var oferta = _context.Oferta.Find(id);

            if (oferta == null)
            {
                return NotFound();
            }

           
                _context.Oferta.Remove(oferta);
                _context.SaveChanges();

                TempData["mensaje"] = "La oferta se ha eliminado correctamente";
                return RedirectToAction("Index");
            
        }
    }
}
