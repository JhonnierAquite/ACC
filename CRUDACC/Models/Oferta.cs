using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDACC.Models
{
    public class Oferta
    {
        //Data notations
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se Necesita un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se Necesita una descripcion")]
        public String Descripcion { get; set; }
        [Required(ErrorMessage = "Se Necesita una cantidad")]
        public int CantidadP { get; set; }


    }
    
}
