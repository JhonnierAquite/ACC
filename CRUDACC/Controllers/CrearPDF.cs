using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;
using CRUDACC.Models;

namespace CRUDACC.Controllers
{
    public class CrearPDF : Controller
    {
        public IActionResult Index()
        {
            var R_producto = new R_Producto()
            {
                Nombre = "javier el manco",
                productos = new List<Producto1>()
                {
                    new Producto1()
                    {
                        Nombre = " hacks",
                        Descripcion = "por que no tiene manos"
                    }
                }
            };
            
            return new ViewAsPdf("index", R_producto)
            {

            };
        }
    }
}
