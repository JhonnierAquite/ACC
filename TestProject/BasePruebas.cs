using CRUDACC.Datos;
using Microsoft.EntityFrameworkCore;
using System;

namespace TestProject
{
    public class BasePruebas
    {
        protected static ApplicationDbContext ConstruirContex(String nomDB)
        {
            var opciones = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(nomDB).Options;

            var dbContex = new ApplicationDbContext(opciones);
            return dbContex;
        }
    }
}