using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDACC.Models
{
    public class R_Producto
    {
        public string Nombre { get; set; }
        public List<Producto1> productos { get; set; }
    }
    public class Producto1
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}
