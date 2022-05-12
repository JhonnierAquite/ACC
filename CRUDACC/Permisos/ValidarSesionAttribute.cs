using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDACC.Permisos
{
    public class ValidarSesionAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtercontext)
        {
          /*if (HttpContext.Current.Session["usuario"] == null)
            {
                FilterContext.Result = new RedirectResult("/Acceso/Login");
            }
          */
            base.OnActionExecuting(filtercontext);
        }
    }
}
