using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            //esta modificacion la estoy haciendo desde 
            //esta es la segunda modificacion
            return View();
        }
    }
}