using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    [TestClass]
    public class UnitTest1: BasePruebas
    {

        [TestMethod]
        public async Task TestMethod1()
        {
            CRUDACC.Models.Oferta oferta = new CRUDACC.Models.Oferta();
            CRUDACC.Models.Oferta oferta1 = new CRUDACC.Models.Oferta();
          
            //Preparacion
            var nombreBD = Guid.NewGuid().ToString();
            var contexto = ConstruirContex(nombreBD);

            oferta1.Id =1;
            oferta1.Nombre = "raspachines";
            oferta1.Descripcion = "Se solicita personal con esperiencia";
            oferta1.CantidadP = 12;


            contexto.Oferta.Add(oferta1);
            await contexto.SaveChangesAsync();

            oferta.Id = 2;
            oferta.Nombre = "raspachines";
            oferta.Descripcion = "Se solicita personal con esperiencia";
            oferta.CantidadP = 12;

            CRUDACC.Controllers.OfertasController oferC = new CRUDACC.Controllers.OfertasController(contexto);

            var respuesta = oferC.Create(oferta);


            //Prueba
            Assert.AreEqual(respuesta, respuesta);
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            CRUDACC.Models.Producto producto = new CRUDACC.Models.Producto();
            CRUDACC.Models.Producto producto1 = new CRUDACC.Models.Producto();

            //Preparacion
            var nombreBD = Guid.NewGuid().ToString();
            var contexto = ConstruirContex(nombreBD);

            producto1.Id = 1;
            producto1.Nombre = "pico";
            producto1.Descripcion = "Se solicita personal con esperiencia";
            producto1.Valor = 12;


            contexto.Producto.Add(producto1);
            await contexto.SaveChangesAsync();

            producto.Id = 2;
            producto.Nombre = "pala";
            producto.Descripcion = "Se solicita personal con esperiencia";
            producto.Valor = 12;

            CRUDACC.Controllers.ProductosController proC = new CRUDACC.Controllers.ProductosController(contexto);

            var respuesta = proC.Create(producto);


            //Prueba
            Assert.AreEqual(respuesta, respuesta);

        }


    }
}
