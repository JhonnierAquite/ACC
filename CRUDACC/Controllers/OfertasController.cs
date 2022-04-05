using CRUDACC.Datos;
using CRUDACC.Models;
using Microsoft.AspNetCore.Mvc;
using CRUDACC.Datos;
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

        public IActionResult Index()
        {
            IEnumerable<Oferta> ListOfertas = _context.Oferta;

            return View(ListOfertas);
        }
    }
}
